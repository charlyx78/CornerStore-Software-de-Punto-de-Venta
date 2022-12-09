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
    public partial class FormNuevaCaja : Form
    {
        int id_usuario_rol_pagina;
        public int guardado = 0;
        public FormNuevaCaja(int id_usuario_rol)
        {
            id_usuario_rol_pagina = id_usuario_rol;
            InitializeComponent();
        }
        private void btn_nueva_caja_Click(object sender, EventArgs e)
        {
            if (txt_numero_caja.Text == "")
            {
                MessageBox.Show("Llene todos los campos para guardar un nuevo departamento", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (lbl_id_caja.Text == "")
            {
                try
                {
                    if(!existeCaja(txt_numero_caja.Value.ToString()))
                    {
                        if(insertarCaja(id_usuario_rol_pagina, txt_numero_caja.Value.ToString()))
                        {
                            MessageBox.Show("Caja guardado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            guardado = 1;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("La caja que intenta guardar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una caja con el número '" + txt_numero_caja.Value.ToString() + "' en la base de datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    int id_caja = Int32.Parse(lbl_id_caja.Text);
                    if(actualizarCaja(id_usuario_rol_pagina, Convert.ToInt32(lbl_id_caja.Text),txt_numero_caja.Value.ToString()))
                    {
                        MessageBox.Show("Caja actualizado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        guardado = 1;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La caja que intenta actualizar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static bool insertarCaja(int id_usuario, string no_caja)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_CREAR_CAJA", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_caja", no_caja);
                cmd.Parameters.AddWithValue("@usuario_cambios", id_usuario);
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool actualizarCaja(int id_usuario, int id_caja, string numero_caja)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_CAJA", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_caja", id_caja);
                cmd.Parameters.AddWithValue("@numero_caja", numero_caja);
                cmd.Parameters.AddWithValue("@usuario_cambios", id_usuario);
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool existeCaja(string no_caja)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_EXISTE_CAJA", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_caja", no_caja);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNuevaCaja_FormClosing(object sender, FormClosingEventArgs e)
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
