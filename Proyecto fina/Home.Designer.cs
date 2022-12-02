
namespace Proyecto_fina
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HoraActual = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_nombre_cajero = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.panel_formularios = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.btn_pagina_vender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_pagina_devolucion = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // HoraActual
            // 
            this.HoraActual.Enabled = true;
            this.HoraActual.Tick += new System.EventHandler(this.HoraActual_Tick_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.lbl_nombre_cajero);
            this.flowLayoutPanel1.Controls.Add(this.lbl_fecha);
            this.flowLayoutPanel1.Controls.Add(this.lbl_hora);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(969, 28);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lbl_nombre_cajero
            // 
            this.lbl_nombre_cajero.AutoSize = true;
            this.lbl_nombre_cajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_cajero.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_cajero.Location = new System.Drawing.Point(3, 0);
            this.lbl_nombre_cajero.Name = "lbl_nombre_cajero";
            this.lbl_nombre_cajero.Size = new System.Drawing.Size(288, 16);
            this.lbl_nombre_cajero.TabIndex = 5;
            this.lbl_nombre_cajero.Text = "@@@@@@@@@@@@@@@@@@@@";
            this.lbl_nombre_cajero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(297, 0);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(72, 16);
            this.lbl_fecha.TabIndex = 6;
            this.lbl_fecha.Text = "30/12/2022";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.White;
            this.lbl_hora.Location = new System.Drawing.Point(375, 0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(45, 16);
            this.lbl_hora.TabIndex = 7;
            this.lbl_hora.Text = "label2";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.Image = global::Proyecto_fina.Properties.Resources.reajustar;
            this.btn_restaurar.Location = new System.Drawing.Point(1212, 7);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(26, 26);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_restaurar.TabIndex = 4;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click_1);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Proyecto_fina.Properties.Resources.icons8_minimize_window_24;
            this.btn_minimizar.Location = new System.Drawing.Point(1175, 7);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(26, 26);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_minimizar.TabIndex = 3;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click_1);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = global::Proyecto_fina.Properties.Resources.cerrar__2_;
            this.btn_cerrar.Location = new System.Drawing.Point(1248, 7);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(26, 26);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_cerrar.TabIndex = 1;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click_1);
            // 
            // panel_formularios
            // 
            this.panel_formularios.BackColor = System.Drawing.Color.White;
            this.panel_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_formularios.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel_formularios.Location = new System.Drawing.Point(200, 40);
            this.panel_formularios.Name = "panel_formularios";
            this.panel_formularios.Size = new System.Drawing.Size(1080, 680);
            this.panel_formularios.TabIndex = 5;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.panel_menu.Controls.Add(this.btn_pagina_devolucion);
            this.panel_menu.Controls.Add(this.btn_cerrar_sesion);
            this.panel_menu.Controls.Add(this.btn_pagina_vender);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 40);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 680);
            this.panel_menu.TabIndex = 4;
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.FlatAppearance.BorderSize = 0;
            this.btn_cerrar_sesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(5)))), ((int)(((byte)(242)))));
            this.btn_cerrar_sesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(140)))));
            this.btn_cerrar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(0, 569);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(200, 30);
            this.btn_cerrar_sesion.TabIndex = 1;
            this.btn_cerrar_sesion.Text = "Cerrar sesión";
            this.btn_cerrar_sesion.UseVisualStyleBackColor = true;
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            // 
            // btn_pagina_vender
            // 
            this.btn_pagina_vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagina_vender.FlatAppearance.BorderSize = 0;
            this.btn_pagina_vender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(208)))), ((int)(((byte)(217)))));
            this.btn_pagina_vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(157)))), ((int)(((byte)(166)))));
            this.btn_pagina_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagina_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagina_vender.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_pagina_vender.Location = new System.Drawing.Point(0, 30);
            this.btn_pagina_vender.Name = "btn_pagina_vender";
            this.btn_pagina_vender.Size = new System.Drawing.Size(200, 30);
            this.btn_pagina_vender.TabIndex = 0;
            this.btn_pagina_vender.Text = "Vender";
            this.btn_pagina_vender.UseVisualStyleBackColor = true;
            this.btn_pagina_vender.Click += new System.EventHandler(this.btn_pagina_vender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "cornerstore";
            // 
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.panel_titulo.Controls.Add(this.btn_restaurar);
            this.panel_titulo.Controls.Add(this.flowLayoutPanel1);
            this.panel_titulo.Controls.Add(this.label1);
            this.panel_titulo.Controls.Add(this.btn_minimizar);
            this.panel_titulo.Controls.Add(this.btn_maximizar);
            this.panel_titulo.Controls.Add(this.btn_cerrar);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(1280, 40);
            this.panel_titulo.TabIndex = 3;
            this.panel_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_titulo_MouseMove_1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximizar.Image = global::Proyecto_fina.Properties.Resources.icons8_maximize_window_24;
            this.btn_maximizar.Location = new System.Drawing.Point(1212, 7);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(26, 26);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_maximizar.TabIndex = 2;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click_1);
            // 
            // btn_pagina_devolucion
            // 
            this.btn_pagina_devolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagina_devolucion.FlatAppearance.BorderSize = 0;
            this.btn_pagina_devolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(208)))), ((int)(((byte)(217)))));
            this.btn_pagina_devolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(157)))), ((int)(((byte)(166)))));
            this.btn_pagina_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagina_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagina_devolucion.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_pagina_devolucion.Location = new System.Drawing.Point(0, 86);
            this.btn_pagina_devolucion.Name = "btn_pagina_devolucion";
            this.btn_pagina_devolucion.Size = new System.Drawing.Size(200, 30);
            this.btn_pagina_devolucion.TabIndex = 2;
            this.btn_pagina_devolucion.Text = "Devolución";
            this.btn_pagina_devolucion.UseVisualStyleBackColor = true;
            this.btn_pagina_devolucion.Click += new System.EventHandler(this.btn_pagina_devolucion_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel_formularios);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_titulo.ResumeLayout(false);
            this.panel_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer HoraActual;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_nombre_cajero;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.Panel panel_formularios;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Button btn_pagina_vender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.PictureBox btn_maximizar;
        private System.Windows.Forms.Button btn_pagina_devolucion;
    }
}