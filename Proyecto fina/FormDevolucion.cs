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
        DateTime fecha_operaciones_caja;
        int id_usuario_rol_pagina = 0;
        int caja_activa = 0;
        public FormDevolucion(int id_usuario_rol, int caja, DateTime fecha_operaciones)
        {
            fecha_operaciones_caja = fecha_operaciones;
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
                SqlCommand cmd = new SqlCommand("SP_GET_CARRITO_TICKET_PARA_DEVOLUCION", con.conectar());
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
        private void btn_buscar_ticket_Click(object sender, EventArgs e)
        {
            cargarTicket();
            txt_codigo_ticket.Enabled = false;
        }
        private void btn_devolucion_Click_1(object sender, EventArgs e)
        {
            crearDevolucion();
        }
        private void crearDevolucion()
        {
            try
            {
                Conexion con2 = new Conexion();
                SqlCommand cmd2 = new SqlCommand("SP_CREAR_DEVOLUCION", con2.conectar());
                cmd2.CommandType = CommandType.StoredProcedure;
                double subtotal = (double)txt_subtotal_devolucion.Value;
                cmd2.Parameters.AddWithValue("@subtotal_devolucion", subtotal);
                cmd2.Parameters.AddWithValue("@total_devolucion", (double)txt_total_devolucion.Value);
                cmd2.Parameters.AddWithValue("@id_cajero", id_usuario_rol_pagina);
                cmd2.Parameters.AddWithValue("@id_caja", caja_activa);
                cmd2.Parameters.AddWithValue("@fecha_devolucion", fecha_operaciones_caja);
                cmd2.ExecuteNonQuery();

                Conexion con3 = new Conexion();
                SqlCommand cmd3 = new SqlCommand("SP_GET_ULTIMO_ID_DEVOLUCION", con3.conectar());
                cmd3.CommandType = CommandType.StoredProcedure;
                int ultimo_id = Convert.ToInt32(cmd3.ExecuteScalar());

                foreach (DataGridViewRow row in dg_carrito_devolucion.Rows)
                {
                    //---CARRITO DE DEVOLUCION---//
                    Conexion con4 = new Conexion();
                    SqlCommand cmd4 = new SqlCommand("SP_AGREGAR_CARRITO_DEVOLUCION", con4.conectar());
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@id_detalles_devolucion", ultimo_id);
                    cmd4.Parameters.AddWithValue("@id_producto", row.Cells[0].Value);
                    cmd4.Parameters.AddWithValue("@cantidad", (double)row.Cells[1].Value);
                    cmd4.Parameters.AddWithValue("@precio", (double)row.Cells[2].Value);
                    cmd4.Parameters.AddWithValue("@cantidad_descuento", (int)row.Cells[3].Value);
                    cmd4.Parameters.AddWithValue("@subtotal", subtotal);
                    cmd4.Parameters.AddWithValue("@total", (double)(subtotal - (subtotal * ((int)row.Cells[3].Value/100))));
                    cmd4.Parameters.AddWithValue("@motivo_devolucion", cb_motivo_devolucion.Text);
                    cmd4.ExecuteNonQuery();

                    //---DESCONTAR DE INVENTARIO---//
                    //if (row.Cells[6].Value.ToString() != "Deficiencia de producto")
                    //{
                    //    Conexion con5 = new Conexion();
                    //    SqlCommand cmd5 = new SqlCommand("SP_DEVOLVER_A_INVENTARIO", con5.conectar());
                    //    cmd5.CommandType = CommandType.StoredProcedure;
                    //    cmd5.Parameters.AddWithValue("@productos_devueltos", (double)row.Cells[1].Value);
                    //    cmd5.Parameters.AddWithValue("@id_producto", (int)row.Cells[0].Value);
                    //    cmd5.ExecuteNonQuery();
                    //}
                }

                Utilidades.CreaTicket ticket = new Utilidades.CreaTicket();
                ticket.TextoCentro("CORNERSTORE");
                ticket.TextoCentro("--------------------------------------------------");

                ticket.TextoIzquierda("");
                ticket.TextoCentro("Nota de credito");
                ticket.TextoCentro("No. de nota de credito: " + ultimo_id);
                ticket.TextoCentro("Fecha: " + fecha_operaciones_caja);
                ticket.TextoCentro("Caja: " + caja_activa);
                ticket.TextoCentro("Le atendió: " + Utilidades.getNombreUsuario(id_usuario_rol_pagina));
                ticket.TextoCentro("");
                Utilidades.CreaTicket.LineasGuion();
                Utilidades.CreaTicket.EncabezadoVenta();
                Utilidades.CreaTicket.LineasGuion();

                foreach(DataGridViewRow row in dg_carrito_devolucion.Rows)
                {
                    string nombre_producto = "";
                    Conexion con4 = new Conexion();
                    SqlCommand cmd4 = new SqlCommand("SP_GET_NOMBRE_PRODUCTO", con4.conectar());
                    cmd4.CommandType = CommandType.StoredProcedure;
                    cmd4.Parameters.AddWithValue("@id_producto", row.Cells[0].Value);
                    SqlDataReader rd4 = cmd4.ExecuteReader();
                    if(rd4.HasRows)
                    {
                        rd4.Read();
                        nombre_producto = rd4.GetString(0);
                    }
                    ticket.AgregaArticulo(nombre_producto,
                                            (double)row.Cells[2].Value,
                                            (double)row.Cells[1].Value,
                                            (double)row.Cells[4].Value,
                                            (int)row.Cells[3].Value);
                }

                Utilidades.CreaTicket.LineasGuion();

                //ticket.TextoIzquierda("Motivo: " + cb_motivo_devolucion.Text);

                Utilidades.CreaTicket.LineasGuion();

                ticket.AgregaTotales("Subtotal: ", (double)txt_subtotal_devolucion.Value);
                //ticket.AgregaTotales("IVA: ", (double)subtotal * 0.16);
                //ticket.AgregaTotales("Descuento: ", Math.Round(((double)subtotal * ((double)((int)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[7].Value / 100) / 100)), 2));
                ticket.AgregaTotales("Total: ", (double)txt_total_devolucion.Value);

                ticket.TextoIzquierda("");
                ticket.TextoCentro("--------------------------------------------------");
                ticket.TextoCentro("--------  Lamentamos el inconveniente :(  --------");
                ticket.TextoCentro("--------------------------------------------------");
                ticket.TextoIzquierda("");

                ticket.ImprimirTiket("Microsoft Print to PDF");

                //dg_devolucion.DataSource = null;
                //dg_devolucion.Rows.Clear();
                //txt_producto_devolucion.Text = "";
                //cb_motivo_devolucion.SelectedIndex = -1;
                //txt_cantidad_devolucion.Value = 0;
                //txt_codigo_ticket.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_devolucion_SelectionChanged(object sender, EventArgs e)
        {
            txt_producto_devolucion.Text = dg_devolucion.CurrentRow.Cells[1].Value.ToString();
        }
        private int getDepartamentoDevolucion()
        {
            int permite_devoluciones = 0;
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_DEPARTAMENTO_DEVOLUCION", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", (int)dg_devolucion.CurrentRow.Cells[0].Value);
            permite_devoluciones = Convert.ToInt32(cmd.ExecuteScalar());
            return permite_devoluciones;
        }
        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            if (getDepartamentoDevolucion() == 1)
            {
                if (txt_cantidad_devolucion.Value != 0 && cb_motivo_devolucion.SelectedIndex != -1)
                {
                    if ((double)txt_cantidad_devolucion.Value <= (double)dg_devolucion.CurrentRow.Cells[2].Value)
                    {
                        try
                        {
                            if (dg_carrito_devolucion.RowCount == 0)
                            {
                                int id = (int)dg_devolucion.CurrentRow.Cells[0].Value;

                                Conexion con = new Conexion();
                                SqlCommand cmd = new SqlCommand("SP_GET_PRODUCTO_DEVOLUCION", con.conectar());
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_ticket", txt_codigo_ticket.Value);
                                cmd.Parameters.AddWithValue("@id_producto", id);
                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);

                                double cantidad = (double)txt_cantidad_devolucion.Value;
                                double precio = (double)dt.Rows[0][2];
                                int descuento = (int)dt.Rows[0][3];
                                double subtotal = (double)dt.Rows[0][4];
                                double total = (double)dt.Rows[0][5];
                                string motivo_devolucion = cb_motivo_devolucion.Text;
                                dg_carrito_devolucion.Rows.Add(id, cantidad, precio, descuento, subtotal, total, motivo_devolucion);
                            }
                            else
                            {
                                int id = (int)dg_devolucion.CurrentRow.Cells[0].Value;
                                double sumaCantidadEnCarrito = 0;
                                foreach (DataGridViewRow row in dg_carrito_devolucion.Rows)
                                {
                                    if ((int)row.Cells[0].Value == id)
                                    {
                                        sumaCantidadEnCarrito += (double)row.Cells[1].Value;
                                    }
                                }
                                double cantidadADevolver = sumaCantidadEnCarrito + (double)txt_cantidad_devolucion.Value;
                                if ((double)dg_devolucion.CurrentRow.Cells[2].Value >= cantidadADevolver)
                                {
                                    Conexion con = new Conexion();
                                    SqlCommand cmd = new SqlCommand("SP_GET_PRODUCTO_DEVOLUCION", con.conectar());
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@id_ticket", txt_codigo_ticket.Value);
                                    cmd.Parameters.AddWithValue("@id_producto", id);
                                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);

                                    double cantidad = (double)txt_cantidad_devolucion.Value;
                                    double precio = (double)dt.Rows[0][2];
                                    int descuento = (int)dt.Rows[0][3];
                                    double subtotal = (double)dt.Rows[0][4];
                                    double total = (double)dt.Rows[0][5];
                                    string motivo_devolucion = cb_motivo_devolucion.Text;
                                    dg_carrito_devolucion.Rows.Add(id, cantidad, precio, descuento, subtotal, total, motivo_devolucion);
                                }
                                else
                                {
                                    MessageBox.Show("No pueden devolver más productos de los comprados", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No pueden devolver más productos de los comprados", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una cantidad de productos a devolver y un motivo de devolución válidos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El departamento perteneciente a este producto no permite devoluciones", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double subtotal_carrito = 0;
            double total_carrito = 0;
            foreach (DataGridViewRow row in dg_carrito_devolucion.Rows)
            {
                subtotal_carrito += (double)row.Cells[4].Value;
                total_carrito += (double)row.Cells[5].Value;
            }
            txt_subtotal_devolucion.Value = (decimal)(double)subtotal_carrito;
            txt_total_devolucion.Value = (decimal)(double)total_carrito;
        }
    }
}
