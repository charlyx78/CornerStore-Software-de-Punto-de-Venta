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
    public partial class FormBuscarProducto : Form
    {
        int id;
        int id_usuario_rol_pagina;
        public FormBuscarProducto(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }

        private void txt_nombre_producto_TextChanged(object sender, EventArgs e)
        {
            if(txt_nombre_producto.Text=="")
            {
                lb_productos.Items.Clear();
            }
            else
            {
                lb_productos.Items.Clear();
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_BUSCAR_PRODUCTO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@busqueda", txt_nombre_producto.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lb_productos.Items.Add(dr.GetString(3));
                    }
                }
            }
        }
        private void lb_productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_productos.SelectedIndex >= 0)
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_CONVERTIR_NOMBRE", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@busqueda", lb_productos.SelectedItem.ToString());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32(0);
                }
            }
        }
        private void btn_agregar_producto_carrito_Click(object sender, EventArgs e)
        {
            int id_producto = id;
            FormVenta frm = Owner as FormVenta;
            float stock_temp = (float)frm.getCantidadInventario(id_producto);
            if (txt_cantidad_nombre_producto.Value > 0)
            {
                if ((float)frm.getCantidadInventario(id_producto) >= (float)txt_cantidad_nombre_producto.Value)
                {
                    try
                    {
                        if (frm.existeProducto(id_producto))
                        {
                            if (frm.existeEnLista(id_producto))
                            {
                                for (int i = 0; i < frm.dg_carrito.RowCount; i++)
                                {
                                    if (id_producto == Convert.ToInt32(frm.dg_carrito.Rows[i].Cells[1].Value))
                                    {
                                        stock_temp -= (float)frm.dg_carrito.Rows[i].Cells[3].Value;
                                        if ((float)txt_cantidad_nombre_producto.Value > stock_temp)
                                        {
                                            MessageBox.Show("No hay suficientes productos en el inventario", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            float cantidad = (float)frm.dg_carrito.Rows[i].Cells[3].Value + (float)txt_cantidad_nombre_producto.Value;
                                            int descuento = (int)frm.dg_carrito.Rows[i].Cells[6].Value;
                                            double precio = (double)frm.dg_carrito.Rows[i].Cells[5].Value;
                                            double subtotal = cantidad * precio;
                                            double total_descuento = Math.Round(((double)subtotal * ((double)((int)descuento) / 100)), 2);
                                            double total = (subtotal - (total_descuento)) * frm.iva;
                                            frm.dg_carrito.Rows[i].Cells[3].Value = cantidad;
                                            frm.dg_carrito.Rows[i].Cells[7].Value = total_descuento;
                                            frm.dg_carrito.Rows[i].Cells[8].Value = Math.Round(subtotal, 2);
                                            frm.dg_carrito.Rows[i].Cells[9].Value = Math.Round(total, 2);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                string nombre = "";
                                float cantidad = 0;
                                double precio = 0;
                                string um = "";
                                int descuento = 0;
                                double descuentoTotal = 0;
                                double subtotal = 0;
                                double total = 0;

                                Conexion con = new Conexion();
                                SqlCommand cmd = new SqlCommand("SP_EXISTE_PRODUCTO", con.conectar());
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                                SqlDataAdapter da = new SqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                if (dt.Rows.Count > 0)
                                {
                                    id_producto = (int)dt.Rows[0][0];
                                    nombre = (string)dt.Rows[0][1];
                                    cantidad = (float)txt_cantidad_nombre_producto.Value;
                                    um = (string)dt.Rows[0][2];
                                    precio = (double)dt.Rows[0][4];
                                    descuento = frm.validarDescuento(id_producto);
                                    subtotal = Math.Round((cantidad * precio), 2);
                                    descuentoTotal = Math.Round(((double)subtotal * ((double)((int)descuento) / 100)), 2);
                                    total = Math.Round(((subtotal - (descuentoTotal)) * frm.iva), 2);
                                    frm.dg_carrito.Rows.Add(frm.lista + "", id_producto, nombre, cantidad, um, precio, descuento, descuentoTotal, subtotal, total);
                                    frm.lista++;
                                }
                            }
                            double descuentoTotalCarrito = 0;
                            double subtotalCarrito = 0;
                            double totalCarrito = 0;
                            foreach (DataGridViewRow row in frm.dg_carrito.Rows)
                            {
                                descuentoTotalCarrito += (double)row.Cells[7].Value;
                                subtotalCarrito += (double)row.Cells[8].Value;
                                totalCarrito += (double)row.Cells[9].Value;
                            }
                            frm.descuento = descuentoTotalCarrito;
                            frm.txt_subtotal_carrito.Value = (decimal)(double)subtotalCarrito;
                            frm.txt_total_carrito.Value = (decimal)(double)totalCarrito;
                        }
                        else
                        {
                            MessageBox.Show("No existen productos con el ID: " + id_producto + "", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No hay suficientes productos en el inventario", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Seleccione la cantidad de productos a agregar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
