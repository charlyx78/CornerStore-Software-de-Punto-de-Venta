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
    public partial class FormReporteInventario : Form
    {
        public FormReporteInventario(int id_usuario_rol)
        {
            InitializeComponent();
        }
        private void FormReportesVentas_Load(object sender, EventArgs e)
        {
            cargarVentas();
            //agregarVendidos();
            dg_productos.ClearSelection();
            dg_productos.MultiSelect = false;
            cb_departamento.DataSource = cargarDepartamentos();
            cb_departamento.DisplayMember = "Departamento";
            cb_departamento.ValueMember = "ID";
        }
        public void cargarVentas()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_INVENTARIO", cn.conectar());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                int vendidos = 0;
                int merma = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int id = (int)dt.Rows[i][0];
                    string departamento = dt.Rows[i][1].ToString();
                    string producto = (string)dt.Rows[i][2].ToString();
                    string um = (string)dt.Rows[i][3].ToString();
                    double costo = (double)dt.Rows[i][4];
                    double precio = (double)dt.Rows[i][5];
                    double existencia = (double)dt.Rows[i][6];
                    vendidos = agregarVendidos(id) - devueltos(id);
                    double utilidad = (precio - costo) * vendidos;
                    merma = agregarMermas(id);
                    dg_productos.Rows.Add(id + "", departamento, producto, "$" + costo, "$" + precio, existencia + " " + um.ToLower(), vendidos + " " + um.ToLower(), "$" + utilidad, merma + " " + um.ToLower());
                }
            }
            catch (Exception ex)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
            }
        }
        public int agregarVendidos(int id)
        {
            int vendidos = 0;
            Conexion cn = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_CANTIDADES_VENDIDAS_PRODUCTO", cn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id);
            vendidos = (int)Convert.ToDouble(cmd.ExecuteScalar());
            return vendidos;
        }
        public int agregarMermas(int id)
        {
            int mermas = 0;
            Conexion cn = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_CANTIDADES_DEVUELTAS_PRODUCTO", cn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id);
            mermas = (int)Convert.ToDouble(cmd.ExecuteScalar());
            return mermas;
        }
        public int devueltos(int id)
        {
            int devuelto = 0;
            Conexion cn = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_CANTIDADES_DEVUELTAS_PRODUCTO", cn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id);
            devuelto = (int)Convert.ToDouble(cmd.ExecuteScalar());
            return devuelto;
        }

        private void btn_cerrar_productos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable cargarDepartamentos()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_DEPARTAMENTOS", cn.conectar());
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dpto = 0;
                SqlDataReader rd = Utilidades.convertirID("id_departamento", "tb_departamentos", "nombre_departamento", cb_departamento.Text);
                if (rd.HasRows)
                {
                    rd.Read();
                    dpto = rd.GetInt32(0);
                }
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_FILTRO_INVENTARIO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@departamento", dpto);
                cmd.Parameters.AddWithValue("@existencia_minima", txt_existencia_minima.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg_productos.DataSource = dt;
            }
            catch (Exception ex)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
            }
        }
    }
}
