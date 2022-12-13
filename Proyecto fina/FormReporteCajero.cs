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
    public partial class FormReporteCajero : Form
    {
        public FormReporteCajero(int id_usuario_rol)
        {
            InitializeComponent();
        }

        public void cargarReporteCajeros()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_GET_REPORTE_CAJERO", cn.conectar());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                int vendidos = 0;
                int merma = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string fecha_venta = dt.Rows[i][0].ToString();
                    string nombre = dt.Rows[i][1].ToString();
                    string producto = (string)dt.Rows[i][2].ToString();
                    string departamento = dt.Rows[i][3].ToString();
                    double cantidad = (double)dt.Rows[i][4];
                    double total = (double)dt.Rows[i][5];
                    double costo = (double)dt.Rows[i][6];
                    double subtotal = (double)dt.Rows[i][7];

                    double utilidad = subtotal - (costo*cantidad);

                    dg_reporte_cajeros.Rows.Add(fecha_venta, producto, departamento, nombre, cantidad, total, Math.Round(utilidad,2));
                }
            }
            catch (Exception ex)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
            }
        }

        private void FormReporteCajero_Load(object sender, EventArgs e)
        {
            cargarReporteCajeros();

            cb_departamento.DataSource = cargarDepartamentos();
            cb_departamento.DisplayMember = "Departamento";
            cb_departamento.ValueMember = "ID";

            cb_cajero.DataSource = cargarUsuarios();
            cb_cajero.DisplayMember = "nombre";
            cb_cajero.ValueMember = "id";

            try
            {
                double suma_cantidad = 0;
                double suma_ventas = 0;
                double suma_utilidad = 0;

                foreach (DataGridViewRow row in dg_reporte_cajeros.Rows)
                {
                    suma_cantidad += (double)row.Cells[4].Value;
                    suma_ventas += (double)row.Cells[5].Value;
                    suma_utilidad += (double)row.Cells[6].Value;
                }

                txt_suma_cantidades.Value = (decimal)suma_cantidad;
                txt_suma_ventas.Value = (decimal)suma_ventas;
                txt_suma_utilidad.Value = (decimal)suma_utilidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_filtros_Click(object sender, EventArgs e)
        {
            try
            {
                dg_reporte_cajeros.DataSource = null;
                dg_reporte_cajeros.Rows.Clear();
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_FILTRO_REPORTE_POR_CAJERO", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@departamento", cb_departamento.SelectedValue);
                cmd.Parameters.AddWithValue("@cajero", cb_cajero.SelectedValue);
                cmd.Parameters.AddWithValue("@fecha1", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@fecha2", dateTimePicker2.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string fecha_venta = dt.Rows[i][0].ToString();
                    string nombre = dt.Rows[i][1].ToString();
                    string producto = (string)dt.Rows[i][2].ToString();
                    string departamento = dt.Rows[i][3].ToString();
                    double cantidad = (double)dt.Rows[i][4];
                    double total = (double)dt.Rows[i][5];
                    double costo = (double)dt.Rows[i][6];
                    double subtotal = (double)dt.Rows[i][7];

                    double utilidad = subtotal - (costo * cantidad);

                    dg_reporte_cajeros.Rows.Add(fecha_venta, producto, departamento, nombre, cantidad, total, Math.Round(utilidad,2));
                }
                try
                {
                    double suma_cantidad = 0;
                    double suma_ventas = 0;
                    double suma_utilidad = 0;

                    foreach (DataGridViewRow row in dg_reporte_cajeros.Rows)
                    {
                        suma_cantidad += (double)row.Cells[4].Value;
                        suma_ventas += (double)row.Cells[5].Value;
                        suma_utilidad += (double)row.Cells[6].Value;
                    }

                    txt_suma_cantidades.Value = (decimal)suma_cantidad;
                    txt_suma_ventas.Value = (decimal)suma_ventas;
                    txt_suma_utilidad.Value = (decimal)suma_utilidad;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        public DataTable cargarUsuarios()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_GET_CAJEROS", cn.conectar());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();

                dt.Columns.Add("id", typeof(int));
                dt.Columns.Add("nombre");
                DataRow dr = dt.NewRow();
                dr["nombre"] = "TODOS";
                dr["id"] = 0;
                dt.Rows.InsertAt(dr, 0);

                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
