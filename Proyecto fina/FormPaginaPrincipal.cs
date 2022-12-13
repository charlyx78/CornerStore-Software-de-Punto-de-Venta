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
    public partial class FormPaginaPrincipal : Form
    {
        public FormPaginaPrincipal()
        {
            InitializeComponent();
        }
        private void FormPaginaPrincipal_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        public void mostrarProductos()
        {
            DataTable datos = cargarProductos();
            dg_reorden.Visible = true;
            dg_reorden.DataSource = datos.DefaultView;
            if(datos.Rows.Count==0)
            {
                img_tabla_vacia.Visible = true;
                lbl_tabla_vacia.Visible = true;
            }
            else
            {
                img_tabla_vacia.Visible = false;
                lbl_tabla_vacia.Visible = false;
            }
        }

        public DataTable cargarProductos()
        {
            try
            {
                Conexion cn = new Conexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_GET_PRODUCTOS_REORDEN", cn.conectar());
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
    }
}
