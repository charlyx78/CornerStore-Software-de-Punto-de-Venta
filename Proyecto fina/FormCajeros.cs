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
    public partial class FormCajeros : Form
    {
        int id_usuario_rol_pagina;
        public FormCajeros(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
            mostrarCajeros();
            dg_cajeros.MultiSelect = false;
        }
        private void FormCajeros_Load(object sender, EventArgs e)
        {

        }

        private void btn_nuevo_cajero_Click(object sender, EventArgs e)
        {
            FormNuevoCajero frm = new FormNuevoCajero(id_usuario_rol_pagina);
            frm.Text = "Nueva caja";
            frm.ShowDialog();
            mostrarCajeros();
        }

        private void btn_editar_cajero_Click(object sender, EventArgs e)
        {
            FormNuevoCajero frm = new FormNuevoCajero(id_usuario_rol_pagina);
            if (dg_cajeros.SelectedRows.Count > 0)
            {
                frm.label8.Visible = true;
                frm.lbl_id_cajero.Visible = true;
                frm.lbl_id_cajero.Text = dg_cajeros.CurrentRow.Cells[12].Value.ToString();
                frm.txt_registro_nombre.Text = dg_cajeros.CurrentRow.Cells[1].Value.ToString();
                frm.txt_registro_apellido_paterno.Text = dg_cajeros.CurrentRow.Cells[2].Value.ToString();
                frm.txt_registro_apellido_materno.Text = dg_cajeros.CurrentRow.Cells[3].Value.ToString();
                frm.cb_registro_sexo.Text = dg_cajeros.CurrentRow.Cells[4].Value.ToString();
                frm.dte_registro_fecha_nacimiento.Text = dg_cajeros.CurrentRow.Cells[5].Value.ToString();
                frm.txt_registro_curp.Text = dg_cajeros.CurrentRow.Cells[6].Value.ToString();
                frm.txt_registro_numero_nominal.Text = dg_cajeros.CurrentRow.Cells[7].Value.ToString();
                frm.txt_registro_email.Text = dg_cajeros.CurrentRow.Cells[8].Value.ToString();
                frm.dte_registro_fecha_ingreso.Text = dg_cajeros.CurrentRow.Cells[9].Value.ToString();
                frm.txt_registro_contraseña.Text = dg_cajeros.CurrentRow.Cells[10].Value.ToString();                
                frm.Text = "Editar caja";
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un cajero a editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            mostrarCajeros();
        }

        private void btn_eliminar_cajero_Click(object sender, EventArgs e)
        {
            if (dg_cajeros.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione el cajero a eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id_cajero = (int)dg_cajeros.CurrentRow.Cells[0].Value;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro(a) que desea eliminar al cajero con ID:" + id_cajero + "?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (eliminar == DialogResult.Yes)
                    {
                        if (eliminarCajero(id_cajero))
                        {
                            mostrarCajeros();
                            MessageBox.Show("Cajero eliminado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el cajero", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mostrarCajeros()
        {
            DataTable datos = cargarCajeros();
            dg_cajeros.DataSource = datos.DefaultView;

            if (datos.Rows.Count == 0)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
                label1.Visible = false;
                txt_usuario_cambio.Visible = false;
                txt_fecha_cambio.Visible = false;
                btn_eliminar_cajero.Visible = false;
                btn_editar_cajero.Visible = false;
                dg_cajeros.Visible = false;
            }
            else
            {
                lbl_tabla_vacia.Visible = false;
                img_tabla_vacia.Visible = false;
                label1.Visible = true;
                txt_usuario_cambio.Visible = true;
                txt_fecha_cambio.Visible = true;
                btn_eliminar_cajero.Visible = true;
                btn_editar_cajero.Visible = true;
                dg_cajeros.Visible = true;
                dg_cajeros.DataSource = datos.DefaultView;
            }
        }

        public DataTable cargarCajeros()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_GET_CAJEROS", cn.conectar());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.desconectar();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public static bool eliminarCajero(int id_caja/*, int id_cajero*/)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CAJERO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cajero", id_caja);
                //cmd.Parameters.AddWithValue("@usuario_cambios", id_cajero);
                int cantidad = cmd.ExecuteNonQuery();
                if (cantidad == 1)
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
                return false;
            }
        }




    }
}
