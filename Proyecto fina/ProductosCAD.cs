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
    class ProductosCAD
    {
        public static bool insertarProducto(Productos p)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_CREAR_PRODUCTOS", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_departamento", p.Id_departamento);
                cmd.Parameters.AddWithValue("@id_descuento", p.Id_descuento);
                cmd.Parameters.AddWithValue("@nombre_producto", p.Nombre_producto);
                cmd.Parameters.AddWithValue("@unidad_medida", p.Unidad_medida);
                cmd.Parameters.AddWithValue("@costo", p.Costo);
                cmd.Parameters.AddWithValue("@precio_unitario", p.Precio_unitario);
                cmd.Parameters.AddWithValue("@cantidad_existencia", p.Cantidad_existencia);
                cmd.Parameters.AddWithValue("@punto_reorden", p.Punto_reorden);
                cmd.Parameters.AddWithValue("@descripcion", p.Descripcion);
                cmd.Parameters.AddWithValue("@habilitado_para_venta", p.Habilitado_para_venta);
                cmd.Parameters.AddWithValue("@usuario_cambios", p.Id_usuario);

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
        public DataTable cargarProductos()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_PRODUCTOS", cn.conectar());
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
        public static bool actualizarProductos(Productos p)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_PRODUCTOS", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", p.Codigo_producto);
                cmd.Parameters.AddWithValue("@id_departamento", p.Nuevo_id_departamento);
                cmd.Parameters.AddWithValue("@id_descuento", p.Nuevo_id_descuento);
                cmd.Parameters.AddWithValue("@nombre_producto", p.Nuevo_nombre_producto);
                cmd.Parameters.AddWithValue("@unidad_medida", p.Nuevo_unidad_medida);
                cmd.Parameters.AddWithValue("@costo", p.Nuevo_costo);
                cmd.Parameters.AddWithValue("@precio_unitario", p.Nuevo_precio_unitario);
                cmd.Parameters.AddWithValue("@cantidad_existencia", p.Nuevo_cantidad_existencia);
                cmd.Parameters.AddWithValue("@punto_reorden", p.Nuevo_punto_reorden);
                cmd.Parameters.AddWithValue("@descripcion", p.Nueva_descripcion);
                cmd.Parameters.AddWithValue("@habilitado_para_venta", p.Nuevo_habilitado_para_venta);
                cmd.Parameters.AddWithValue("@usuario_cambios", p.Nuevo_id_usuario);

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
        public static bool eliminarProducto(Productos p)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PRODUCTOS", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", p.Codigo_producto);
                cmd.Parameters.AddWithValue("@usuario_cambios", p.Nuevo_id_usuario);

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
