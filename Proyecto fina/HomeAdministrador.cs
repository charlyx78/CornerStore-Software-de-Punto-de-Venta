using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fina
{
    public partial class HomeAdministrador : Form
    {
        Utilidades uti = new Utilidades();
        private int id_usuario_rol_pagina = 0;
        public HomeAdministrador(int id_usuario_rol)
        {
            InitializeComponent();
            lbl_nombre_administrador.Text = Utilidades.getNombreUsuario(id_usuario_rol);
            id_usuario_rol_pagina = id_usuario_rol;
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        private void AbrirFormularioHijo(object formahija)
        {
            if (this.panel_formularios.Controls.Count > 0)
                this.panel_formularios.Controls.RemoveAt(0);
            Form fh = formahija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_formularios.Controls.Add(fh);
            this.panel_formularios.Tag = fh;
            fh.Show();
        }
        private void btn_pagina_cajas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormCajas(this.getUsuarioID()));
        }
        private void btn_pagina_cajeros_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormCajeros(this.getUsuarioID()));
        }
        private void btn_pagina_departamentos_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormDepartamentos(this.getUsuarioID()));
        }
        private void btn_pagina_descuentos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormDescuentos(this.getUsuarioID()));
        }
        private void btn_pagina_productos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormProductos(this.getUsuarioID()));
        }
        private void btn_pagina_reportes_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormReporteInventario(this.getUsuarioID()));
        }
        private void btn_pagina_reporte_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormReporteVentas(this.getUsuarioID()));
        }
        private void btn_consulta_Click(object sender, EventArgs e)
        {
        }
        private void btn_consultar_recibos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormConsultarRecibos(this.getUsuarioID()));
        }
        private void btn_reporte_cajeros_Click(object sender, EventArgs e)
        {
        }
        private void btn_pagina_inicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormPaginaPrincipal());
        }
        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin pagina_inicio_sesion = new FormLogin();
            pagina_inicio_sesion.Show();
        }
        public int getUsuarioID()
        {
            return this.id_usuario_rol_pagina;
        }

        #region funcionalidades del formulario
        //RESIZE METODO PARA REDIMENSIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panel_contenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int lx, ly;
        int sw, sh;

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            btn_maximizar.Visible = true;
            btn_restaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void panel_titulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_fecha_Click_1(object sender, EventArgs e)
        {

        }

        private void HoraActual_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_reporte_cajeros_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormReporteCajero(this.getUsuarioID()));

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
    }
}
