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
    public partial class FormConsultarRecibos : Form
    {
        int id_usuario_rol_pagina = 0;
        int TNC = 0;
        public FormConsultarRecibos(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }
        private void btn_consultar_tickets_Click(object sender, EventArgs e)
        {
            cargarTicket();
            TNC = 1;
        }
        private void btn_consultar_notas_credito_Click(object sender, EventArgs e)
        {
            cargarNotasCredito();
            TNC = 2;
        }
        public void cargarTicket()
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_GET_CARRITO_TICKET", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_ticket", txt_id.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg_consulta.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void cargarNotasCredito()
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_GET_CARRITO_NOTA_CREDITO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_detalles_devolucion", txt_id.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg_consulta.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_reimprimir_Click(object sender, EventArgs e)
        {
            if(TNC == 1)
            {
                imprimirTicket();
            }
            if(TNC == 2 )
            {
                imprimirNotaCredito();
            }
        }

        private void imprimirTicket()
        {
            Utilidades.CreaTicket ticket = new Utilidades.CreaTicket();
            ticket.TextoCentro("CORNERSTORE");
            ticket.TextoCentro("--------------------------------------------------");

            ticket.TextoIzquierda("");
            ticket.TextoCentro("Ticket de venta");
            ticket.TextoIzquierda("No. de ticket: " + txt_id.Value);
            ticket.TextoIzquierda("Fecha: " + DateTime.Now.ToString());
            ticket.TextoIzquierda("Caja: " + dg_consulta.CurrentRow.Cells[2].Value);
            ticket.TextoIzquierda("Le atendió: " + Utilidades.getNombreUsuario(id_usuario_rol_pagina));
            ticket.TextoIzquierda("");
            Utilidades.CreaTicket.LineasGuion();
            Utilidades.CreaTicket.EncabezadoVenta();
            Utilidades.CreaTicket.LineasGuion();

            foreach (DataGridViewRow row in dg_consulta.Rows)
            {
                ticket.AgregaArticulo((string)row.Cells[3].Value.ToString(), (double)row.Cells[6].Value, (int)row.Cells[5].Value, (double)row.Cells[8].Value, (int)row.Cells[7].Value);
            }
            Utilidades.CreaTicket.LineasGuion();
            ticket.AgregaTotales("Subtotal: ", (double)dg_consulta.CurrentRow.Cells[10].Value);
            //ticket.AgregaTotales("Descuento: ", (double)descuentoPago);
            //ticket.AgregaTotales("IVA: ", (subtotalPago - descuentoPago) * 0.16);
            ticket.AgregaTotales("Total: ", (double)dg_consulta.CurrentRow.Cells[11].Value);
            ticket.AgregaTotales("Pago en efectivo: ", (double)dg_consulta.CurrentRow.Cells[12].Value);
            ticket.AgregaTotales("Pago en tarjeta: ", (double)dg_consulta.CurrentRow.Cells[13].Value);
            ticket.AgregaTotales("Pago en vales: ", (double)dg_consulta.CurrentRow.Cells[14].Value);
            //ticket.AgregaTotales("Cambio de efectivo: ", Math.Round(cambio, 2));

            ticket.TextoIzquierda("");
            ticket.TextoCentro("--------------------------------------------------");
            ticket.TextoCentro("---------  Gracias por su preferencia :)  --------");
            ticket.TextoCentro("--------------------------------------------------");
            ticket.TextoIzquierda("");

            ticket.ImprimirTiket("Microsoft Print to PDF");
        }
        private void imprimirNotaCredito()
        {
            Utilidades.CreaTicket ticket = new Utilidades.CreaTicket();
            ticket.TextoCentro("CORNERSTORE");
            ticket.TextoCentro("--------------------------------------------------");

            ticket.TextoIzquierda("");
            ticket.TextoCentro("Nota de credito");
            ticket.TextoIzquierda("No. de nota de credito: " + txt_id.Value);
            ticket.TextoIzquierda("Fecha: " + DateTime.Now.ToString());
            ticket.TextoIzquierda("Caja: " + dg_consulta.CurrentRow.Cells[2].Value);
            ticket.TextoIzquierda("Le atendió: " + Utilidades.getNombreUsuario(id_usuario_rol_pagina));
            ticket.TextoIzquierda("");
            Utilidades.CreaTicket.LineasGuion();
            Utilidades.CreaTicket.EncabezadoVenta();
            Utilidades.CreaTicket.LineasGuion();

            string nombre_producto = dg_consulta.CurrentRow.Cells[3].Value.ToString();
            ticket.AgregaArticulo(nombre_producto,
                                  (double)dg_consulta.CurrentRow.Cells[6].Value,
                                  (int)dg_consulta.CurrentRow.Cells[5].Value,
                                  Math.Round((double)dg_consulta.CurrentRow.Cells[8].Value, 2),
                                  (int)dg_consulta.CurrentRow.Cells[7].Value);

            Utilidades.CreaTicket.LineasGuion();

            ticket.TextoIzquierda("Motivo: " + dg_consulta.CurrentRow.Cells[10].Value.ToString());

            Utilidades.CreaTicket.LineasGuion();

            ticket.AgregaTotales("Subtotal: ", (double)dg_consulta.CurrentRow.Cells[11].Value);
            //ticket.AgregaTotales("IVA: ", (double)subtotal * 0.16);
            //ticket.AgregaTotales("Descuento: ", Math.Round(((double)subtotal * ((double)((int)dg_devolucion.Rows[dg_devolucion.CurrentRow.Index].Cells[6].Value / 100) / 100)), 2));
            ticket.AgregaTotales("Total: ", Math.Round((double)dg_consulta.CurrentRow.Cells[12].Value, 2));

            ticket.TextoIzquierda("");
            ticket.TextoCentro("--------------------------------------------------");
            ticket.TextoCentro("--------  Lamentamos el inconveniente :(  --------");
            ticket.TextoCentro("--------------------------------------------------");
            ticket.TextoIzquierda("");

            ticket.ImprimirTiket("Microsoft Print to PDF");
        }
    }
}
