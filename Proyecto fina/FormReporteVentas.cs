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
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas(int id_usuario_rol)
        {
            InitializeComponent();
        }

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            cargarVentas();

            cb_departamento.DataSource = cargarDepartamentos();
            cb_departamento.DisplayMember = "Departamento";
            cb_departamento.ValueMember = "ID";

            cb_caja.DataSource = cargarCajas();
            cb_caja.DisplayMember = "Numero";
            cb_caja.ValueMember = "ID";

            try
            {
                double suma_subtotal = 0;
                double suma_descuento = 0;
                double suma_total = 0;
                double suma_utilidad = 0;

                foreach (DataGridViewRow row in dg_ventas.Rows)
                {
                    suma_subtotal += (double)row.Cells[8].Value;
                    suma_descuento += (double)row.Cells[9].Value;
                    suma_total += (double)row.Cells[10].Value;
                    suma_utilidad += (double)row.Cells[11].Value;
                }

                txt_suma_subtotal.Value = (decimal)suma_subtotal;
                txt_suma_total_descuento.Value = (decimal)suma_descuento;
                txt_suma_total.Value = (decimal)suma_total;
                txt_suma_utilidad.Value = (decimal)suma_utilidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarVentas()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_GET_VENTAS", cn.conectar());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                da.Fill(dt);
                int vendidos = 0;
                int merma = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int id = (int)dt.Rows[i][0];
                    int caja = (int)dt.Rows[i][1];
                    string fecha_venta = dt.Rows[i][2].ToString();
                    string departamento = dt.Rows[i][3].ToString();
                    string producto = (string)dt.Rows[i][4].ToString();
                    int id_producto = (int)dt.Rows[i][5];
                    double precio = (double)dt.Rows[i][6];
                    double cantidad = (double)dt.Rows[i][7];
                    double subtotal = (double)dt.Rows[i][8];
                    int total_descuento = (int)dt.Rows[i][9];
                    double total = (double)dt.Rows[i][10];
                    string um = dt.Rows[i][11].ToString();
                    double costo = (double)dt.Rows[i][12];
                    double utilidad = total - (costo * cantidad); 
                    dg_ventas.Rows.Add(id + "", caja, fecha_venta, departamento, producto, id_producto, precio, cantidad + " " + um, subtotal, + (subtotal * (total_descuento / 100)) , total, utilidad );
                }
            }
            catch (Exception ex)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
            }
        }

        private void btn_filtros_Click(object sender, EventArgs e)
        {
            try
            {
                dg_ventas.DataSource = null;
                dg_ventas.Rows.Clear();
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("SP_FILTRO_REPORTE_VENTAS", con.conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@departamento", cb_departamento.SelectedValue);
                cmd.Parameters.AddWithValue("@id_caja", cb_caja.SelectedValue);
                cmd.Parameters.AddWithValue("@fecha1", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@fecha2", dateTimePicker2.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int vendidos = 0;
                int merma = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int id = (int)dt.Rows[i][0];
                    string caja = dt.Rows[i][1].ToString();
                    string fecha_venta = dt.Rows[i][2].ToString();
                    string departamento = dt.Rows[i][3].ToString();
                    string producto = (string)dt.Rows[i][4].ToString();
                    int id_producto = (int)dt.Rows[i][5];
                    double precio = (double)dt.Rows[i][6];
                    double cantidad = (double)dt.Rows[i][7];
                    double subtotal = (double)dt.Rows[i][8];
                    int total_descuento = (int)dt.Rows[i][9];
                    double total = (double)dt.Rows[i][10];
                    string um = dt.Rows[i][11].ToString();
                    double costo = (double)dt.Rows[i][12];
                    double utilidad = total - (costo * cantidad);
                    dg_ventas.Rows.Add(id + "", caja, fecha_venta, departamento, producto, id_producto, precio, cantidad + " " + um, subtotal, +(subtotal * (total_descuento / 100)), total, utilidad);
                }

                double suma_subtotal = 0;
                double suma_descuento = 0;
                double suma_total = 0;
                double suma_utilidad = 0;

                foreach (DataGridViewRow row in dg_ventas.Rows)
                {
                    suma_subtotal += (double)row.Cells[8].Value;
                    suma_descuento += (double)row.Cells[9].Value;
                    suma_total += (double)row.Cells[10].Value;
                    suma_utilidad += (double)row.Cells[11].Value;
                }

                txt_suma_subtotal.Value = (decimal)suma_subtotal;
                txt_suma_total_descuento.Value = (decimal)suma_descuento;
                txt_suma_total.Value = (decimal)suma_total;
                txt_suma_utilidad.Value = (decimal)suma_utilidad;
            }
            catch (Exception ex)
            {
                lbl_tabla_vacia.Visible = true;
                img_tabla_vacia.Visible = true;
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

        public DataTable cargarCajas()
        {
            Conexion cn = new Conexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_CARGAR_CAJAS", cn.conectar());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Numero");
            DataRow dr = dt.NewRow();
            dr["Numero"] = "TODOS";
            dr["ID"] = 0;
            dt.Rows.InsertAt(dr, 0);

            da.Fill(dt);
            return dt;
        }
    }
}
