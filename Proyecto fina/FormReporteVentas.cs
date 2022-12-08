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
    }
}
