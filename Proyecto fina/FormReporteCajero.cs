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

                    dg_reporte_cajeros.Rows.Add(fecha_venta, producto, departamento, nombre, cantidad, total, utilidad);
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
    }
}
