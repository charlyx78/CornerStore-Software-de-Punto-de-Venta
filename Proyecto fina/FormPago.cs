using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Proyecto_fina
{
    public partial class FormPago : Form
    {
        double subtotalPago;
        double totalPago;
        double descuentoPago;
        private int id_usuario_rol_pagina = 0;
        DataGridView carritoCompra;
        double pagando;
        double cambio;
        int caja_activa=0;
        public FormPago(int id_cajero, int caja, double total, double subtotal, double descuento, DataGridView carrito)
        {
            caja_activa = caja;
            id_usuario_rol_pagina = id_cajero;
            descuentoPago = descuento;
            subtotalPago = subtotal;
            totalPago = total;
            carritoCompra = carrito;
            InitializeComponent();
        }
        private void InstalledPrintersCombo()
        {
            // Add list of installed printers found to the combo box.
            // The pkInstalledPrinters string will be used to provide the display string.
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                cb_impresoras.Items.Add(pkInstalledPrinters);

            }
            cb_impresoras.Text = "Microsoft Print to PDF";
        }
        private void FormPago_Load(object sender, EventArgs e)
        {
            lbl_total.Text = totalPago.ToString();
            lbl_sutotal.Text = subtotalPago.ToString();
            InstalledPrintersCombo();
        }
        private void btn_pagar_Click(object sender, EventArgs e)
        {
            pagando = (double)txt_pago_efectivo.Value + (double)txt_pago_tarjeta.Value + (double)txt_pago_vales.Value;
            if(pagando>=totalPago)
            {
                if (crearTicket())
                {
                    if(txt_pago_efectivo.Value>0)
                    {
                        cambio = (double)txt_pago_efectivo.Value - (totalPago - (double)txt_pago_tarjeta.Value - (double)txt_pago_vales.Value);

                    }
                    crearCarrito();
                    descontarInventario();
                    FormVenta frm = Owner as FormVenta;
                    frm.dg_carrito.Rows.Clear();
                    frm.txt_codigo_producto_carrito.Value = 0;
                    frm.txt_cantidad_producto_carrito.Value = 0;
                    frm.txt_subtotal_carrito.Value = 0;
                    frm.txt_total_carrito.Value = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ticket no pudo ser creado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Pago incompleto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public bool crearTicket()
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_CREAR_DETALLES_TICKET", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@subtotal_ticket", subtotalPago);
                cmd.Parameters.AddWithValue("@total_ticket", totalPago);
                cmd.Parameters.AddWithValue("@id_cajero", id_usuario_rol_pagina);
                cmd.Parameters.AddWithValue("@id_caja", caja_activa);
                int cantidad = cmd.ExecuteNonQuery();

                Conexion con2 = new Conexion();
                SqlCommand cmd2 = new SqlCommand("SP_CREAR_PAGO_TICKET", con2.conectar());
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@pago_efectivo", (double)txt_pago_efectivo.Value);
                cmd2.Parameters.AddWithValue("@pago_tarjeta", (double)txt_pago_tarjeta.Value);
                cmd2.Parameters.AddWithValue("@pago_vales", (double)txt_pago_vales.Value);
                int cantidad2 = cmd2.ExecuteNonQuery();

                Conexion con3 = new Conexion();
                SqlCommand cmd3 = new SqlCommand("SP_CREAR_TICKET", con3.conectar());
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@id_detalles_ticket", getUltimoIDDetallesTicket());
                cmd3.Parameters.AddWithValue("@id_pago_ticket", getUltimoIDPago());
                int cantidad3 = cmd3.ExecuteNonQuery();
                if (cantidad == 1 && cantidad2 == 1 && cantidad3 == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public int getUltimoIDDetallesTicket()
        {
            int id = 0;
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_ULTIMO_ID_TICKET", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }
        public int getUltimoIDPago()
        {
            int id = 0;
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_ULTIMO_ID_PAGO", con.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }
        public void crearCarrito()
        {
            try
            {
                for (int i = 0; i < carritoCompra.RowCount; i++)
                {
                    Conexion con = new Conexion();
                    SqlCommand cmd = new SqlCommand("SP_CREAR_TICKET_CARRITO", con.conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_detalles_ticket", getUltimoIDDetallesTicket());
                    cmd.Parameters.AddWithValue("@id_producto", (int)carritoCompra.Rows[i].Cells[1].Value);
                    cmd.Parameters.AddWithValue("@cantidad", (double)carritoCompra.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@precio", (double)carritoCompra.Rows[i].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@cantidad_descuento", (int)carritoCompra.Rows[i].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@subtotal", (double)carritoCompra.Rows[i].Cells[8].Value);
                    cmd.Parameters.AddWithValue("@total", (double)carritoCompra.Rows[i].Cells[9].Value);
                    cmd.ExecuteNonQuery();
                }
                Utilidades.CreaTicket ticket = new Utilidades.CreaTicket();
                ticket.TextoCentro("CORNERSTORE");
                ticket.TextoCentro("--------------------------------------------------");

                ticket.TextoIzquierda("");
                ticket.TextoCentro("Ticket de venta");
                ticket.TextoIzquierda("No. de ticket: " + getUltimoTicketID());
                ticket.TextoIzquierda("Fecha: " + DateTime.Now.ToString());
                ticket.TextoIzquierda("Caja: " + caja_activa);
                ticket.TextoIzquierda("Le atendió: " + Utilidades.getNombreUsuario(id_usuario_rol_pagina));
                ticket.TextoIzquierda("");
                Utilidades.CreaTicket.LineasGuion();
                Utilidades.CreaTicket.EncabezadoVenta();
                Utilidades.CreaTicket.LineasGuion();

                foreach(DataGridViewRow row in carritoCompra.Rows)
                {
                    ticket.AgregaArticulo((string)row.Cells[2].Value.ToString(),(double) row.Cells[5].Value, (double)row.Cells[3].Value, (double)row.Cells[8].Value, (int)row.Cells[6].Value);
                }
                Utilidades.CreaTicket.LineasGuion();
                ticket.AgregaTotales("Subtotal: ", (double)subtotalPago);
                ticket.AgregaTotales("Descuento: ", (double)descuentoPago);
                ticket.AgregaTotales("IVA: ", (subtotalPago - descuentoPago) * 0.16);
                ticket.AgregaTotales("Total: ", totalPago);

                ticket.TextoIzquierda("");

                ticket.AgregaTotales("Pago en efectivo: ", (double)txt_pago_efectivo.Value);
                ticket.AgregaTotales("Pago en tarjeta: ", (double)txt_pago_tarjeta.Value);
                ticket.AgregaTotales("Pago en vales: ", (double)txt_pago_vales.Value);
                ticket.AgregaTotales("Cambio de efectivo: ", Math.Round(cambio,2));

                ticket.TextoIzquierda("");
                ticket.TextoCentro("--------------------------------------------------");
                ticket.TextoCentro("---------  Gracias por su preferencia :)  --------");
                ticket.TextoCentro("--------------------------------------------------");
                ticket.TextoIzquierda("");

                ticket.ImprimirTiket(cb_impresoras.Text);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void descontarInventario()
        {
            for (int i = 0; i < carritoCompra.RowCount; i++)
            {
                try
                {
                    Conexion con = new Conexion();
                    SqlCommand cmd = new SqlCommand("SP_DESCONTAR_PRODUCTO_INVENTARIO", con.conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cantidad_compra", (double)carritoCompra.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@id_producto", (int)carritoCompra.Rows[i].Cells[1].Value);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No hay suficiente producto en el inventario para completar esta venta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public int getUltimoTicketID()
        {
            try
            {
                int cantidad = 0;
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_GET_ULTIMO_ID_TICKET", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                return cantidad;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
