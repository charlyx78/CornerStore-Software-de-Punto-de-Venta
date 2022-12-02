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
    public partial class FormDescuentos : Form
    {
        private int id_usuario_rol_pagina = 0;
        public FormDescuentos(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }

        DescuentosCAD descuentos = new DescuentosCAD();
        Descuentos dsc = new Descuentos();
        Utilidades u = new Utilidades();

        private void FormDescuentos_Load(object sender, EventArgs e)
        {
            mostrarDescuentos();
            dg_descuentos.ClearSelection();
            dg_descuentos.MultiSelect = false;
        }
        private void mostrarDescuentos()
        {
            this.dg_descuentos.DefaultCellStyle.ForeColor = Color.Black;
            DataTable datos = descuentos.cargarDescuentos();
            if (datos == null)
            {
                MessageBox.Show("No se logró acceder a la base de datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dg_descuentos.DataSource = datos.DefaultView;
            }
        }
        private void btn_nuevo_descuento_Click_1(object sender, EventArgs e)
        {
            FormNuevoDescuento frm = new FormNuevoDescuento(id_usuario_rol_pagina);
            frm.Text = "Nuevo descuento";
            frm.ShowDialog();
            mostrarDescuentos();
        }

        private void btn_editar_descuento_Click(object sender, EventArgs e)
        {
            FormNuevoDescuento frm = new FormNuevoDescuento(id_usuario_rol_pagina);
            if (dg_descuentos.SelectedRows.Count > 0)
            {
                frm.label4.Visible = true;
                frm.lbl_id_descuento.Visible = true;
                frm.lbl_id_descuento.Text = dg_descuentos.CurrentRow.Cells[0].Value.ToString();
                frm.txt_nombre_descuento.Text = dg_descuentos.CurrentRow.Cells[1].Value.ToString();
                frm.txt_cantidad_descuento.Text = dg_descuentos.CurrentRow.Cells[2].Value.ToString();
                frm.dtp_fecha_inicio_descuento.Text = dg_descuentos.CurrentRow.Cells[3].Value.ToString();
                frm.dtp_fecha_fin_descuento.Text = dg_descuentos.CurrentRow.Cells[4].Value.ToString();
                frm.Text = "Editar descuento";
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un producto a editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            mostrarDescuentos();
        }

        private void btn_eliminar_descuento_Click(object sender, EventArgs e)
        {
            if (dg_descuentos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione el descuento a eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try { 
                    dsc.Id_descuento = (int)dg_descuentos.CurrentRow.Cells[0].Value;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro(a) que desea eliminar el descuento con ID:" + dsc.Id_descuento + "?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (eliminar == DialogResult.Yes)
                    {
                        dsc.Nuevo_id_usuario = id_usuario_rol_pagina;
                        if (DescuentosCAD.eliminarDescuento(dsc))
                        {
                            mostrarDescuentos();
                            MessageBox.Show("Descuento eliminado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el descuento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void dg_descuentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_descuentos.SelectedRows.Count > 0)
            {
                label1.Visible = true;
                lbl_usuario_cambio.Visible = true;
                lbl_fecha_cambio.Visible = true;

                dsc.Id_descuento = (int)dg_descuentos.CurrentRow.Cells[0].Value;

                SqlDataReader rd = u.getUsuarioCambio("tb_descuentos", "id_descuento", dsc.Id_descuento);
                SqlDataReader rd2 = u.getFechaCambio("tb_descuentos", "id_descuento", dsc.Id_descuento);


                if (rd.HasRows && rd2.HasRows)
                {
                    rd.Read();
                    rd2.Read();
                    lbl_usuario_cambio.Text = rd.GetString(0);
                    lbl_fecha_cambio.Text = rd2.GetDateTime(0).ToString();
                }
            }
        }
    }
}
