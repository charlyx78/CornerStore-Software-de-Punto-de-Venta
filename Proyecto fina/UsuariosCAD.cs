using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fina
{
    class UsuariosCAD
    {
        public DataTable cargarUsuarios()
        {
            Conexion cn = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_USUARIOS", cn.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool insertarUsuario(Usuario u)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_CREAR_USUARIO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@apellido_paterno", u.Apellido_paterno);
                cmd.Parameters.AddWithValue("@apellido_materno", u.Apellido_materno);
                cmd.Parameters.AddWithValue("@sexo", u.Sexo);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", u.Fecha_nacimiento);
                cmd.Parameters.AddWithValue("@CURP", u.Curp);
                cmd.Parameters.AddWithValue("@numero_nomina", u.Numero_nomina);
                cmd.Parameters.AddWithValue("@correo_electronico", u.Correo_electronico);
                cmd.Parameters.AddWithValue("@contraseña", u.Contraseña);
                Conexion con2 = new Conexion();
                SqlCommand cmd2 = new SqlCommand("SP_CREAR_USUARIO_ROL", con2.conectar());
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@id_usuario", u.Id_usuario);
                cmd2.Parameters.AddWithValue("@id_tipo_rol", u.Id_tipo_rol);
                int cantidad = cmd.ExecuteNonQuery();
                int cantidad2 = cmd2.ExecuteNonQuery();
                if (cantidad == 1 && cantidad2 == 1)
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
