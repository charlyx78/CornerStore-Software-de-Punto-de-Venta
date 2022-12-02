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
    public partial class FormNuevoDescuento : Form
    {
        private int id_usuario_rol_pagina = 0;
        public int guardado = 0;
        public FormNuevoDescuento(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }

        DescuentosCAD descuentos = new DescuentosCAD();
        Descuentos dsc = new Descuentos();
        Conexion con = new Conexion();
        private void btn_nuevo_descuento_Click(object sender, EventArgs e)
        {
            if (txt_nombre_descuento.Text.Trim() == "" || txt_cantidad_descuento.Value == 0)
            {
                MessageBox.Show("Llene los campos para registrar un nuevo descuento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dtp_fecha_inicio_descuento.Value > dtp_fecha_fin_descuento.Value)
            {
                MessageBox.Show("La fecha de inicio de descuento debe ser previa a la fecha de fin de descuento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (lbl_id_descuento.Text == "")
            {
                try
                {
                    dsc.Nombre_descuento = txt_nombre_descuento.Text.Trim().ToUpper();
                    dsc.Cantidad_descuento = ((int)txt_cantidad_descuento.Value);
                    dsc.Fecha_inicio = dtp_fecha_inicio_descuento.Value.Year + "-" + dtp_fecha_inicio_descuento.Value.Month + "-" + dtp_fecha_inicio_descuento.Value.Day;
                    dsc.Fecha_fin = dtp_fecha_fin_descuento.Value.Year + "-" + dtp_fecha_fin_descuento.Value.Month + "-" + dtp_fecha_fin_descuento.Value.Day;
                    dsc.Id_usuario = id_usuario_rol_pagina;
                    if (DescuentosCAD.insertarDescuento(dsc))
                    {
                        MessageBox.Show("Descuento registrado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardado = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El descuento que intenta registrar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    dsc.Id_descuento = Int32.Parse(lbl_id_descuento.Text);
                    dsc.Nuevo_nombre_descuento = txt_nombre_descuento.Text.Trim().ToUpper();
                    dsc.Nueva_cantidad_descuento = ((int)txt_cantidad_descuento.Value);
                    dsc.Nueva_fecha_inicio = dtp_fecha_inicio_descuento.Value.Year + "-" + dtp_fecha_inicio_descuento.Value.Month + "-" + dtp_fecha_inicio_descuento.Value.Day;
                    dsc.Nueva_fecha_fin = dtp_fecha_fin_descuento.Value.Year + "-" + dtp_fecha_fin_descuento.Value.Month + "-" + dtp_fecha_fin_descuento.Value.Day;
                    if (DescuentosCAD.actualizarDescuento(dsc))
                    {
                        MessageBox.Show("Descuento actualizado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardado = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El descuento que intenta actualizar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void FormNuevoDescuento_FormClosing(object sender, FormClosingEventArgs e)
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
