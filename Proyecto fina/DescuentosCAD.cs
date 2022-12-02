using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fina
{
    class DescuentosCAD
    {
        public static bool insertarDescuento(Descuentos dsc)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_CREAR_DESCUENTO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre_descuento", dsc.Nombre_descuento);
                cmd.Parameters.AddWithValue("@cantidad_descuento", dsc.Cantidad_descuento);
                cmd.Parameters.AddWithValue("@fecha_inicio", dsc.Fecha_inicio);
                cmd.Parameters.AddWithValue("@fecha_fin", dsc.Fecha_fin);
                cmd.Parameters.AddWithValue("@usuario_cambios", dsc.Id_usuario);          

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
        public DataTable cargarDescuentos()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_DESCUENTOS", cn.conectar());
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
        public static bool actualizarDescuento(Descuentos dsc)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_DESCUENTO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_descuento", dsc.Id_descuento);
                cmd.Parameters.AddWithValue("@nombre_descuento", dsc.Nuevo_nombre_descuento);
                cmd.Parameters.AddWithValue("@cantidad_descuento", dsc.Nueva_cantidad_descuento);
                cmd.Parameters.AddWithValue("@fecha_inicio", dsc.Nueva_fecha_inicio);
                cmd.Parameters.AddWithValue("@fecha_fin", dsc.Nueva_fecha_fin);
                cmd.Parameters.AddWithValue("@usuario_cambios", dsc.Nuevo_id_usuario);

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
        public static bool eliminarDescuento(Descuentos dsc)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_DESCUENTO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_descuento", dsc.Id_descuento);
                cmd.Parameters.AddWithValue("@usuario_cambios", dsc.Nuevo_id_usuario);

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
    }
}
