using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fina
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }
        Usuario u = new Usuario();
        Utilidades uti = new Utilidades();
        private bool CurpValida(string curp)
        {
            var re = @"^([A-Z][AEIOUX][A-Z]{2}\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])[HM](?:AS|B[CS]|C[CLMSH]|D[FG]|G[TR]|HG|JC|M[CNS]|N[ETL]|OC|PL|Q[TR]|S[PLR]|T[CSL]|VZ|YN|ZS)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d])(\d)$";
            Regex rx = new Regex(re, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var validado = rx.IsMatch(curp);

            if (!validado)  //Coincide con el formato general?
                return false;

            //Validar que coincida el dígito verificador
            if (!curp.EndsWith(DigitoVerificador(curp.ToUpper())))
                return false;

            return true; //Validado
        }
        private string DigitoVerificador(string curp17)
        {
            var diccionario = "0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            var suma = 0.0;
            var digito = 0.0;
            for (var i = 0; i < 17; i++)
                suma = suma + diccionario.IndexOf(curp17[i]) * (18 - i);
            digito = 10 - suma % 10;
            if (digito == 10) return "0";
            return digito.ToString();
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            bool esNumerico = Int32.TryParse(txt_registro_numero_nominal.Text, out resultado);
            if (txt_registro_nombre.Text.Trim() == "" ||
               txt_registro_apellido_paterno.Text.Trim() == "" ||
               txt_registro_apellido_materno.Text.Trim() == "" ||
               cb_registro_sexo.Text.Trim() == "" ||
               txt_registro_curp.Text.Trim() == "" ||
               txt_registro_numero_nominal.Text.Trim() == "" ||
               txt_registro_email.Text.Trim() == "" ||
               txt_registro_contraseña.Text.Trim() == "" ||
               txt_registro_confirmar_contraseña.Text.Trim() == "")
            {
                MessageBox.Show("Llene todos los campos para registrar un nuevo cajero", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!esNumerico)
            {
                MessageBox.Show("Inserte un valor número para número nominal", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CurpValida(txt_registro_curp.Text.Trim()))
            {
                MessageBox.Show("El formato de CURP introducido no es válido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_registro_confirmar_contraseña.Text.Trim() != txt_registro_contraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    u.Nombre = txt_registro_nombre.Text.Trim().ToUpper();
                    u.Apellido_paterno = txt_registro_apellido_paterno.Text.Trim().ToUpper();
                    u.Apellido_materno = txt_registro_apellido_materno.Text.Trim().ToUpper();
                    u.Sexo = cb_registro_sexo.Text.Trim().ToUpper();
                    u.Fecha_nacimiento = dte_registro_fecha_nacimiento.Value.Year + "-" + dte_registro_fecha_ingreso.Value.Month + "-" + dte_registro_fecha_ingreso.Value.Day;
                    u.Curp = txt_registro_curp.Text.Trim();
                    u.Numero_nomina = txt_registro_numero_nominal.Text.Trim();
                    u.Correo_electronico = txt_registro_email.Text.Trim();
                    u.Contraseña = txt_registro_contraseña.Text.Trim();
                    u.Id_usuario = uti.getUltimoIDUsuario("tb_usuario");
                    u.Id_tipo_rol = 2;

                    if (UsuariosCAD.insertarUsuario(u))
                    {
                        MessageBox.Show("Cajero registrado exitosamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FormLogin login = new FormLogin();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("El cajero que intenta registrar ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin inicioSesion = new FormLogin();
            inicioSesion.Show();
            this.Hide();
        }
    }
}
