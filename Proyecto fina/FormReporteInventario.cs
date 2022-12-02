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
            dg_reportes_ventas.ClearSelection();
            dg_reportes_ventas.MultiSelect = false;
        }
        public void cargarVentas()
        {
            Conexion cn = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_INVENTARIO", cn.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            int vendidos = 0;
            int merma = 0;
            for (int i=0; i<dt.Rows.Count; i++)
            {
                int id = (int)dt.Rows[i][0];
                string departamento = dt.Rows[i][1].ToString();
                string producto = (string)dt.Rows[i][2].ToString();
                string um = (string)dt.Rows[i][3].ToString();
                double costo = (double)dt.Rows[i][4];
                double precio = (double)dt.Rows[i][5];
                double existencia = (double)dt.Rows[i][6];
                vendidos = agregarVendidos(id)-devueltos(id);
                double utilidad = (precio-costo) * vendidos;
                merma = agregarMermas(id);
                dg_reportes_ventas.Rows.Add(id + "", departamento, producto, um, costo, precio, existencia, vendidos, utilidad, merma);
                //SqlCommand cmd = new SqlCommand("SP_GET_CANTIDADES_VENDIDAS_PRODUCTO", cn.conectar());
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_producto", i);
                //vendidos = Convert.ToInt32(cmd.ExecuteScalar());
                //double utilidad;

            }
        }
        //private void mostrarVentas()
        //{
        //    this.dg_reportes_ventas.DefaultCellStyle.ForeColor = Color.Black;
        //    DataTable datos = cargarVentas();
        //    if (datos == null)
        //    {
        //        MessageBox.Show("No se logró acceder a la base de datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //    else
        //    {
        //        dg_reportes_ventas.DataSource = datos.DefaultView;
        //        agregarVendidos();
        //    }
        //}
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
    }
}
