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
    public partial class FormCajas : Form
    {
        int id_usuario_rol_pagina;
        public FormCajas(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
            mostrarCajas();
            dg_cajas.MultiSelect = false;
        }

        private void btn_nueva_caja_Click(object sender, EventArgs e)
        {
            FormNuevaCaja frm = new FormNuevaCaja(id_usuario_rol_pagina);
            frm.Text = "Nueva caja";
            frm.ShowDialog();
            mostrarCajas();
        }

        private void btn_editar_caja_Click(object sender, EventArgs e)
        {
            FormNuevaCaja frm = new FormNuevaCaja(id_usuario_rol_pagina);
            if (dg_cajas.SelectedRows.Count > 0)
            {
                frm.label2.Visible = true;
                frm.lbl_id_caja.Visible = true;
                frm.lbl_id_caja.Text = dg_cajas.CurrentRow.Cells[0].Value.ToString();
                frm.txt_numero_caja.Value = Convert.ToInt32(dg_cajas.CurrentRow.Cells[1].Value);
                frm.Text = "Editar caja";
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una caja a editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            mostrarCajas();
        }

        private void btn_eliminar_caja_Click(object sender, EventArgs e)
        {
            if (dg_cajas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione la caja a eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id_caja = (int)dg_cajas.CurrentRow.Cells[0].Value;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro(a) que desea eliminar la caja con ID:" + id_caja + "?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (eliminar == DialogResult.Yes)
                    {
                        if (eliminarCaja(id_caja,id_usuario_rol_pagina))
                        {
                            mostrarCajas();
                            MessageBox.Show("Caja eliminada exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la caja", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void mostrarCajas()
        {
            DataTable datos = cargarCajas();
            dg_cajas.DataSource = datos.DefaultView;

            if (datos.Rows.Count == 0)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
                label1.Visible = false;
                txt_usuario_cambio.Visible = false;
                txt_fecha_cambio.Visible = false;
                btn_editar_caja.Visible = false;
                btn_eliminar_caja.Visible = false;
                dg_cajas.Visible = false;
            }
            else
            {
                lbl_tabla_vacia.Visible = false;
                img_tabla_vacia.Visible = false;
                label1.Visible = true;
                txt_usuario_cambio.Visible = true;
                txt_fecha_cambio.Visible = true;
                btn_editar_caja.Visible = true;
                btn_eliminar_caja.Visible = true;
                dg_cajas.Visible = true;
                dg_cajas.DataSource = datos.DefaultView;
            }
        }

        public DataTable cargarCajas()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_CAJAS", cn.conectar());
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
        public static bool eliminarCaja(int id_caja, int id_cajero)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CAJA", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_caja", id_caja);
                cmd.Parameters.AddWithValue("@usuario_cambios", id_cajero);
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

        private void btn_cerrar_productos_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("¿Está seguro que quieres cerrar esta pestaña? Cualquier cambio no guardado se perderá", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cerrar == DialogResult.Yes)
            {
                this.Close();
            }
            else if (cerrar == DialogResult.No)
            {
                return;
            }
        }

        private void dg_cajas_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_cajas.SelectedRows.Count > 0)
            {
                label1.Visible = true;
                txt_usuario_cambio.Visible = true;
                txt_fecha_cambio.Visible = true;

                int id_caja = (int)dg_cajas.CurrentRow.Cells[0].Value;

                SqlDataReader rd = Utilidades.getUsuarioCambio("tb_cajas", "id_caja", id_caja);
                SqlDataReader rd2 = Utilidades.getFechaCambio("tb_cajas", "id_caja", id_caja);

                if (rd.HasRows && rd2.HasRows)
                {
                    rd.Read();
                    rd2.Read();
                    txt_usuario_cambio.Text = rd.GetString(0);
                    txt_fecha_cambio.Text = rd2.GetDateTime(0).ToString();
                }
            }
        }
    }
}
