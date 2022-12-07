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
    public partial class FormNuevoProducto : Form
    {
        private int id_usuario_rol_pagina = 0;
        public int guardado = 0;
        public FormNuevoProducto(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }
        DepartamentosCAD departamento = new DepartamentosCAD();
        DescuentosCAD descuento = new DescuentosCAD();
        Productos p = new Productos();
        Utilidades u = new Utilidades();
        private void FormNuevoProducto_Load(object sender, EventArgs e)
        {
            cb_departamento_producto.DataSource = departamento.cargarDepartamentos();
            cb_departamento_producto.DisplayMember = "Departamento";
            cb_departamento_producto.ValueMember = "ID";
            cb_descuento_producto.DataSource = descuento.cargarDescuentos();
            cb_descuento_producto.DisplayMember = "Concepto";
            cb_descuento_producto.ValueMember = "Concepto";
        }
        private void cb_departamento_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre_descuento = cb_descuento_producto.Text.Trim();
            Conexion con = new Conexion();
            string sql = "SELECT cantidad_descuento FROM tb_descuentos WHERE nombre_descuento= '" + nombre_descuento + "';";
            SqlCommand comando = new SqlCommand(sql, con.conectar());
            SqlDataReader rd = comando.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txt_cantidad_descuento_producto.Value = rd.GetInt32(0);
            }
        }  
        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            if (txt_nombre_producto.Text.Trim() == "" ||
               cb_departamento_producto.SelectedValue == null ||
               cb_descuento_producto.SelectedValue == null ||
               cb_unidad_medida_producto.SelectedItem == null ||
               txt_existencia_producto.Value == 0 ||
               txt_costo_producto.Text == "" ||
               txt_precio_unitario_producto.Text == "" ||
               txt_descripcion_producto.Text == "" ||
               (rb_habilitado_producto.Checked == false && rb_inhabilitado_producto.Checked == false))
            {
                MessageBox.Show("Llene todos los campos para registrar un nuevo producto", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txt_punto_reorden_producto.Value>txt_existencia_producto.Value)
            {
                MessageBox.Show("El punto de reorden ingresado es mayor al número de existencias ingresado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txt_costo_producto.Value>txt_precio_unitario_producto.Value)
            {
                MessageBox.Show("El costo ingresdo es mayor al precio ingresado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (lbl_id_producto.Text=="")
            {
                try
                {
                    p.Nombre_producto = txt_nombre_producto.Text.Trim().ToUpper();
                    SqlDataReader rd = Utilidades.convertirID("id_departamento", "tb_departamentos", "nombre_departamento", cb_departamento_producto.Text);
                    SqlDataReader rd2 = Utilidades.convertirID("id_descuento", "tb_descuentos", "nombre_descuento", cb_descuento_producto.Text);
                    if (rd.HasRows && rd2.HasRows)
                    {
                        rd.Read();
                        rd2.Read();
                        p.Id_departamento = rd.GetInt32(0);
                        p.Id_descuento = rd2.GetInt32(0);
                    }
                    p.Cantidad_existencia = (float)txt_existencia_producto.Value;
                    p.Punto_reorden = (float)txt_punto_reorden_producto.Value;
                    p.Unidad_medida = cb_unidad_medida_producto.Text.Trim().ToUpper();
                    p.Costo = (float)txt_costo_producto.Value;
                    p.Precio_unitario = (float)txt_precio_unitario_producto.Value;
                    p.Descripcion = txt_descripcion_producto.Text;
                    if(rb_habilitado_producto.Checked)
                    {
                        p.Habilitado_para_venta = 1;
                    }
                    else if(rb_inhabilitado_producto.Checked)
                    {
                        p.Habilitado_para_venta = 0;
                    }
                    p.Id_usuario = id_usuario_rol_pagina;
                    if (ProductosCAD.insertarProducto(p))
                    {
                        MessageBox.Show("Producto registrado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardado = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El producto que intenta registrar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    string text = lbl_codigo_producto.Text;
                    p.Codigo_producto = Int32.Parse(lbl_id_producto.Text);
                    p.Nuevo_nombre_producto = txt_nombre_producto.Text.Trim().ToUpper();
                    SqlDataReader rd = Utilidades.convertirID("id_departamento", "tb_departamentos", "nombre_departamento", cb_departamento_producto.Text);
                    SqlDataReader rd2 = Utilidades.convertirID("id_descuento", "tb_descuentos", "nombre_descuento", cb_descuento_producto.Text);
                    if (rd.HasRows && rd2.HasRows)
                    {
                        rd.Read();
                        rd2.Read();
                        p.Nuevo_id_departamento = rd.GetInt32(0);
                        p.Nuevo_id_descuento = rd2.GetInt32(0);
                    }
                    p.Nuevo_cantidad_existencia = (float)txt_existencia_producto.Value;
                    p.Nuevo_punto_reorden = (float)txt_punto_reorden_producto.Value;
                    p.Nuevo_unidad_medida = cb_unidad_medida_producto.Text.Trim().ToUpper();
                    p.Nuevo_costo = (float)txt_costo_producto.Value;
                    p.Nuevo_precio_unitario = (float)txt_precio_unitario_producto.Value;
                    p.Nueva_descripcion = txt_descripcion_producto.Text.Trim();
                    if (rb_habilitado_producto.Checked)
                    {
                        p.Nuevo_habilitado_para_venta = 1;
                    }
                    else if (rb_inhabilitado_producto.Checked)
                    {
                        p.Nuevo_habilitado_para_venta = 0;
                    }

                    p.Nuevo_id_usuario = id_usuario_rol_pagina;
                    if (ProductosCAD.actualizarProductos(p))
                    {
                        MessageBox.Show("Producto actualizado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardado = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El producto que intenta registrar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNuevoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guardado == 0)
            {
                DialogResult cerrar = MessageBox.Show("¿Está seguro que quiere cerrar esta pestaña?" + Environment.NewLine + "Cualquier cambio no guardado se perderá", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (cerrar != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
