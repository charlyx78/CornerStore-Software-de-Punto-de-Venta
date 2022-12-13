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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        UsuariosCAD u = new UsuariosCAD();
        Conexion con = new Conexion();
        private void FormLogin_Load(object sender, EventArgs e)
        {
            cb_cajas.DataSource = cargarCajas();
            cb_cajas.DisplayMember = "Numero";
            cb_cajas.ValueMember = "ID";
            cb_login_usuario.DataSource = u.cargarUsuarios();
            cb_login_usuario.DisplayMember = "CURP";
            cb_login_usuario.ValueMember = "id_usuario_rol";
        }
        public void login(string curp, string contraseña)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_VALIDAR_LOGIN", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CURP", curp);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if ((int)dt.Rows[0][4] == 1)
                    {
                        //los parametros que se pasan a la ventana home son las posiciones en la tabla de nombre y ambos apellidos, para que sean mostrados en la misma
                        new HomeAdministrador((int)dt.Rows[0][0]).Show();
                    }
                    else if ((int)dt.Rows[0][4] == 2) {
                        //los parametros que se pasan a la ventana home son las posiciones en la tabla de nombre y ambos apellidos, para que sean mostrados en la misma
                        new Home((int)dt.Rows[0][0], Convert.ToInt32(cb_cajas.SelectedValue), dtp_fecha_operaciones.Value).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }
        private void btnInciciarSesion_Click_1(object sender, EventArgs e)
        {
            if(cb_login_usuario.Text == "" || txt_login_password.Text == "")
            {
                MessageBox.Show("Llene todos los campos para iniciar sesión", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                login(this.cb_login_usuario.Text, this.txt_login_password.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro registro = new registro();
            registro.Show();
            this.Hide();
        }

        public DataTable cargarCajas()
        {
            Conexion cn = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_CAJAS", cn.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
