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
    public partial class FormNuevoDepartamento : Form
    {
        private int id_usuario_rol_pagina = 0;
        public int guardado = 0;
        public FormNuevoDepartamento(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }
        Departamentos dptos = new Departamentos();
        Utilidades u = new Utilidades();
        private void btn_nuevo_producto_Click(object sender, EventArgs e)
        {
            if (txt_nombre_departamento.Text == "")
            {
                MessageBox.Show("Llene todos los campos para guardar un nuevo departamento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (lbl_id_departamento.Text == "")
            {

                try
                {
                    dptos.Nombre_departamento = txt_nombre_departamento.Text.Trim().ToUpper();
                    dptos.Id_usuario = id_usuario_rol_pagina;
                    if (DepartamentosCAD.insertarDepartamento(dptos))
                    {
                        MessageBox.Show("Departamento guardado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardado = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El departamento que intenta guardar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dptos.Id_departamento = Int32.Parse(lbl_id_departamento.Text);
                    dptos.Nuevo_nombre_departamento = txt_nombre_departamento.Text.Trim().ToUpper();
                    dptos.Nuevo_id_usuario = id_usuario_rol_pagina;
                    if (DepartamentosCAD.actualizarDepartamento(dptos))
                    {
                        MessageBox.Show("Departamento actualizado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardado = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El departamento que intenta actualizar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormNuevoDepartamento_FormClosing(object sender, FormClosingEventArgs e)
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

