using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fina
{
    public partial class FormDevolucion : Form
    {
        int id_usuario_rol_pagina = 0;
        int caja_activa = 0;
        public FormDevolucion(int id_usuario_rol, int caja)
        {
            caja_activa = caja;
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }

        private void FormDevolucion_Load(object sender, EventArgs e)
        {
            dg_devolucion.MultiSelect = false;
        }
        public void cargarTicket()
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_GET_CARRITO_TICKET", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id_ticket", txt_codigo_ticket.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg_devolucion.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_buscar_producto_Click(object sender, EventArgs e)
        {
            cargarTicket();
        }

        private void btn_devolucion_Click(object sender, EventArgs e)
        {
            crearDevolucion();
        }
        private void crearDevolucion()
        {
            if((double)txt_cantidad_devolucion.Value > (int)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[5].Value)
            {
                MessageBox.Show("No se pueden devolver más productos de los que se compraron", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_cantidad_devolucion.Value>0 && cb_motivo_devolucion.SelectedIndex>=0 && dg_devolucion.SelectedRows.Count > 0)
            {
                try
                {
                    Conexion con = new Conexion();
                    SqlCommand cmd = new SqlCommand("SP_DEVOLUCION", con.conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productos_devueltos", txt_cantidad_devolucion.Value);
                    cmd.Parameters.AddWithValue("@id_producto", dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[0].Value);
                    cmd.ExecuteNonQuery();

                    Conexion con2 = new Conexion();
                    SqlCommand cmd2 = new SqlCommand("SP_CREAR_DEVOLUCION", con2.conectar());
                    cmd2.CommandType = CommandType.StoredProcedure;
                    double subtotal = (double)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[5].Value * (double)txt_cantidad_devolucion.Value;
                    cmd2.Parameters.AddWithValue("@subtotal_devolucion", subtotal);
                    double total_descuento = Math.Round(((double)subtotal * ((double)((int)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[5].Value / 100) / 100)), 2);
                    cmd2.Parameters.AddWithValue("@total_devolucion", (double)(subtotal - (total_descuento)) * 1.16f);
                    cmd2.Parameters.AddWithValue("@id_cajero", id_usuario_rol_pagina);
                    cmd2.Parameters.AddWithValue("@id_caja", caja_activa);
                    cmd2.ExecuteNonQuery();

                    Conexion con3 = new Conexion();
                    SqlCommand cmd3 = new SqlCommand("SP_GET_ULTIMO_ID_DEVOLUCION", con3.conectar());
                    cmd3.CommandType = CommandType.StoredProcedure;
                    int ultimo_id = Convert.ToInt32(cmd3.ExecuteScalar());

                    Conexion con4 = new Conexion();
                    SqlCommand cmd4 = new SqlCommand("SP_AGREGAR_CARRITO_DEVOLUCION", con4.conectar());
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@id_detalles_devolucion", ultimo_id);
                    cmd4.Parameters.AddWithValue("@id_producto", dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[1].Value);
                    cmd4.Parameters.AddWithValue("@cantidad", (double)txt_cantidad_devolucion.Value);
                    cmd4.Parameters.AddWithValue("@precio", (double)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[5].Value);
                    cmd4.Parameters.AddWithValue("@cantidad_descuento", (int)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[6].Value);
                    cmd4.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd4.Parameters.AddWithValue("@total", (double)(subtotal - (total_descuento)) * 1.16f);
                    cmd4.Parameters.AddWithValue("@motivo_devolucion", cb_motivo_devolucion.Text);
                    cmd4.ExecuteNonQuery();

                    if (cb_motivo_devolucion.Text != "Deficiencia de producto")
                    {
                        Conexion con5 = new Conexion();
                        SqlCommand cmd5 = new SqlCommand("SP_DEVOLVER_A_INVENTARIO", con5.conectar());
                        cmd5.CommandType = CommandType.StoredProcedure;
                        cmd5.Parameters.AddWithValue("@productos_devueltos", txt_cantidad_devolucion.Value);
                        cmd5.Parameters.AddWithValue("@id_producto", dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[0].Value);
                        cmd5.ExecuteNonQuery();
                    }


                    Utilidades.CreaTicket ticket = new Utilidades.CreaTicket();
                    ticket.TextoCentro("CORNERSTORE");
                    ticket.TextoCentro("--------------------------------------------------");

                    ticket.TextoIzquierda("");
                    ticket.TextoCentro("Nota de credito");
                    ticket.TextoIzquierda("No. de nota de credito: " + ultimo_id);
                    ticket.TextoIzquierda("Fecha: " + DateTime.Now.ToString());
                    ticket.TextoIzquierda("Caja: " + caja_activa);
                    ticket.TextoIzquierda("Le atendió: " + Utilidades.getNombreUsuario(id_usuario_rol_pagina));
                    ticket.TextoIzquierda("");
                    Utilidades.CreaTicket.LineasGuion();
                    Utilidades.CreaTicket.EncabezadoVenta();
                    Utilidades.CreaTicket.LineasGuion();

                    string nombre_producto = dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[2].Value.ToString();
                    ticket.AgregaArticulo(nombre_producto,
                                          (double)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[5].Value,
                                          (int)txt_cantidad_devolucion.Value,
                                          Math.Round(subtotal, 2),
                                          (int)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[6].Value);

                    Utilidades.CreaTicket.LineasGuion();

                    ticket.TextoIzquierda("Motivo: " + cb_motivo_devolucion.Text);

                    Utilidades.CreaTicket.LineasGuion();

                    ticket.AgregaTotales("Subtotal: ", (double)subtotal);
                    ticket.AgregaTotales("IVA: ", (double)subtotal*0.16);
                    ticket.AgregaTotales("Descuento: ", Math.Round(((double)subtotal * ((double)((int)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[6].Value / 100) / 100)), 2));
                    ticket.AgregaTotales("Total: ", Math.Round((double)(subtotal - (total_descuento)) * 1.16f, 2));

                    ticket.TextoIzquierda("");
                    ticket.TextoCentro("--------------------------------------------------");
                    ticket.TextoCentro("--------  Lamentamos el inconveniente :(  --------");
                    ticket.TextoCentro("--------------------------------------------------");
                    ticket.TextoIzquierda("");

                    ticket.ImprimirTiket("Microsoft Print to PDF");

                    dg_devolucion.Rows.Clear();
                    txt_cantidad_devolucion.Value = 0;
                    txt_codigo_ticket.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Seleccione todos los datos para completar la devolución", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
