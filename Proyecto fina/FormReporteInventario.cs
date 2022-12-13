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
            rb_productos_agotados_no.Checked = true;
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
                double vendidos = 0;
                double merma = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int id = (int)dt.Rows[i][0];
                    string departamento = dt.Rows[i][1].ToString();
                    string producto = (string)dt.Rows[i][2].ToString();
                    string um = (string)dt.Rows[i][3].ToString();
                    double costo = (double)dt.Rows[i][4];
                    double precio = (double)dt.Rows[i][5];
                    double existencia = (double)dt.Rows[i][6];
                    vendidos = getVentas(id) - devueltos(id);
                    double utilidad = getUtilidad(id);
                    merma = agregarMermas(id);
                    dg_productos.Rows.Add(id + "", departamento, producto, "$" + costo, "$" + precio, existencia + " " + um, vendidos + " " + um.ToLower(), "$" + utilidad, merma + " " + um);
                }
            }
            catch (Exception ex)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
            }
        }
        public double agregarVendidos(int id)
        {
            double vendidos = 0;
            Conexion cn = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_CANTIDADES_VENDIDAS_PRODUCTO", cn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id);
            vendidos = (double)Convert.ToDouble(cmd.ExecuteScalar());
            return vendidos;
        }
        public double agregarMermas(int id)
        {
            double mermas = 0;
            Conexion cn = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_MERMAS", cn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@productO", id);
            mermas = (double)Convert.ToDouble(cmd.ExecuteScalar());
            return mermas;
        }
        public double devueltos(int id)
        {
            double devuelto = 0;
            Conexion cn = new Conexion();
            SqlCommand cmd = new SqlCommand("SP_GET_CANTIDADES_DEVUELTAS_PRODUCTO", cn.conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id);
            devuelto = (double)Convert.ToDouble(cmd.ExecuteScalar());
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

                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Departamento");
                DataRow dr = dt.NewRow();
                dr["Departamento"] = "TODOS";
                dr["ID"] = 0;
                dt.Rows.InsertAt(dr, 0);

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
                #region GET_DPTO_ID
                int dpto = 0;
                SqlDataReader rd = Utilidades.convertirID("id_departamento", "tb_departamentos", "nombre_departamento", cb_departamento.Text);
                if (rd.HasRows)
                {
                    rd.Read();
                    dpto = rd.GetInt32(0);
                }
                #endregion GET_DPTO_ID
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_FILTRO_INVENTARIO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@departamento", dpto);
                cmd.Parameters.AddWithValue("@existencia_minima", txt_existencia_minima.Value);
                if (rb_productos_agotados_no.Checked)
                {
                    cmd.Parameters.AddWithValue("@productos_agotados", 0);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@productos_agotados", 1);
                }
                if (chb_productos_mermados.Checked)
                {
                    cmd.Parameters.AddWithValue("@productos_mermados", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@productos_mermados", 0);
                }
                dg_productos.DataSource = null;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dg_productos.Rows.Clear();
                double vendidos = 0;
                double merma = 0;
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
                    dg_productos.Rows.Add(id + "", departamento, producto, "$" + costo, "$" + precio, existencia + " " + um, vendidos + " " + um.ToLower(), "$" + utilidad, merma + " " + um);
                }
            }
            catch (Exception ex)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
            }
        }

        public double getUtilidad(int id_producto)
        {
            try
            {
                double utilidad = 0;
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_GET_UTILIDAD", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("producto", id_producto);
                utilidad = Convert.ToDouble(cmd.ExecuteScalar());
                return utilidad;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public double getVentas(int id_producto)
        {
            try
            {
                double utilidad = 0;
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_GET_CANTIDADES_VENDIDAS", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("producto", id_producto);
                utilidad = Convert.ToDouble(cmd.ExecuteScalar());
                return utilidad;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
