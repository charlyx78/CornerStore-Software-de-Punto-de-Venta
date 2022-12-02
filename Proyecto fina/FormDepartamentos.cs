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
    public partial class FormDepartamentos : Form
    {
        private int id_usuario_rol_pagina = 0;
        public FormDepartamentos(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }
        DepartamentosCAD departamentos = new DepartamentosCAD();
        Departamentos d = new Departamentos();
        Utilidades u = new Utilidades();
        private void pagina_departamentos_Load(object sender, EventArgs e)
        {
            mostrarDepartamentos();
            dg_departamentos.ClearSelection();
            dg_departamentos.MultiSelect = false;
        }
        private void mostrarDepartamentos()
        {
            this.dg_departamentos.DefaultCellStyle.ForeColor = Color.Black;
            DataTable datos = departamentos.cargarDepartamentos();
            if(datos == null)
            {
                MessageBox.Show("No se logró acceder a la base de datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dg_departamentos.DataSource = datos.DefaultView;
            }
        }
        private void btn_nuevo_departamento_Click_1(object sender, EventArgs e)
        {
            FormNuevoDepartamento frm = new FormNuevoDepartamento(id_usuario_rol_pagina);
            frm.Text = "Nuevo departamento";
            frm.ShowDialog();
            mostrarDepartamentos();
        }
        private void btn_editar_departamento_Click(object sender, EventArgs e)
        {
            FormNuevoDepartamento frm = new FormNuevoDepartamento(id_usuario_rol_pagina);
            if (dg_departamentos.SelectedRows.Count > 0)
            {
                frm.label2.Visible = true;
                frm.lbl_id_departamento.Visible = true;
                frm.lbl_id_departamento.Text = dg_departamentos.CurrentRow.Cells[0].Value.ToString();
                frm.txt_nombre_departamento.Text = dg_departamentos.CurrentRow.Cells[1].Value.ToString();
                frm.Text = "Editar departamento";
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un producto a editar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            mostrarDepartamentos();
        }
        private void dg_departamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_departamentos.SelectedRows.Count > 0)
            {
                label1.Visible = true;
                lbl_usuario_cambio.Visible = true;
                lbl_fecha_cambio.Visible = true;

                d.Id_departamento = (int)dg_departamentos.CurrentRow.Cells[0].Value;

                SqlDataReader rd = u.getUsuarioCambio("tb_departamentos", "id_departamento", d.Id_departamento);
                SqlDataReader rd2 = u.getFechaCambio("tb_departamentos", "id_departamento", d.Id_departamento);

                if (rd.HasRows && rd2.HasRows)
                {
                    rd.Read();
                    rd2.Read();
                    lbl_usuario_cambio.Text = rd.GetString(0);
                    lbl_fecha_cambio.Text = rd2.GetDateTime(0).ToString();
                }
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
        private void btn_eliminar_departamento_Click(object sender, EventArgs e)
        {
            if (dg_departamentos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seleccione el departamento a eliminar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    d.Id_departamento = (int)dg_departamentos.CurrentRow.Cells[0].Value;
                    DialogResult eliminar = MessageBox.Show("¿Está seguro(a) que desea eliminar el departamento con ID:" + d.Id_departamento + "?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(eliminar == DialogResult.Yes)
                    {
                        d.Nuevo_id_usuario = id_usuario_rol_pagina;
                        if (DepartamentosCAD.eliminarDepartamento(d))
                        {
                            mostrarDepartamentos();
                            MessageBox.Show("Departamento eliminado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar el departamento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
