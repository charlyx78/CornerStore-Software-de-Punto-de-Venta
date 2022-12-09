
namespace Proyecto_fina
{
    partial class FormCajas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_usuario_cambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha_cambio = new System.Windows.Forms.TextBox();
            this.lbl_tabla_vacia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_cajas = new System.Windows.Forms.DataGridView();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.img_tabla_vacia = new System.Windows.Forms.PictureBox();
            this.btn_editar_caja = new System.Windows.Forms.Button();
            this.btn_nueva_caja = new System.Windows.Forms.Button();
            this.btn_eliminar_caja = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cajas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.txt_usuario_cambio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_fecha_cambio);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 36);
            this.panel1.TabIndex = 122;
            // 
            // txt_usuario_cambio
            // 
            this.txt_usuario_cambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_usuario_cambio.Location = new System.Drawing.Point(113, 8);
            this.txt_usuario_cambio.Name = "txt_usuario_cambio";
            this.txt_usuario_cambio.ReadOnly = true;
            this.txt_usuario_cambio.Size = new System.Drawing.Size(394, 20);
            this.txt_usuario_cambio.TabIndex = 83;
            this.txt_usuario_cambio.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "ULTIMO CAMBIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // txt_fecha_cambio
            // 
            this.txt_fecha_cambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fecha_cambio.Location = new System.Drawing.Point(513, 8);
            this.txt_fecha_cambio.Name = "txt_fecha_cambio";
            this.txt_fecha_cambio.ReadOnly = true;
            this.txt_fecha_cambio.Size = new System.Drawing.Size(371, 20);
            this.txt_fecha_cambio.TabIndex = 84;
            this.txt_fecha_cambio.Visible = false;
            // 
            // lbl_tabla_vacia
            // 
            this.lbl_tabla_vacia.AutoSize = true;
            this.lbl_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.lbl_tabla_vacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabla_vacia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tabla_vacia.Location = new System.Drawing.Point(222, 383);
            this.lbl_tabla_vacia.Name = "lbl_tabla_vacia";
            this.lbl_tabla_vacia.Size = new System.Drawing.Size(477, 25);
            this.lbl_tabla_vacia.TabIndex = 119;
            this.lbl_tabla_vacia.Text = "NO SE ENCONTRARON CAJAS REGISTRADOS";
            this.lbl_tabla_vacia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 116;
            this.label2.Text = "Cajas";
            // 
            // dg_cajas
            // 
            this.dg_cajas.AllowUserToAddRows = false;
            this.dg_cajas.AllowUserToDeleteRows = false;
            this.dg_cajas.AllowUserToResizeColumns = false;
            this.dg_cajas.AllowUserToResizeRows = false;
            this.dg_cajas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_cajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_cajas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_cajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_cajas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_cajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_cajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_cajas.EnableHeadersVisualStyles = false;
            this.dg_cajas.GridColor = System.Drawing.SystemColors.Control;
            this.dg_cajas.Location = new System.Drawing.Point(12, 98);
            this.dg_cajas.Name = "dg_cajas";
            this.dg_cajas.ReadOnly = true;
            this.dg_cajas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_cajas.RowHeadersVisible = false;
            this.dg_cajas.RowHeadersWidth = 80;
            this.dg_cajas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_cajas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_cajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_cajas.Size = new System.Drawing.Size(897, 523);
            this.dg_cajas.TabIndex = 115;
            this.dg_cajas.SelectionChanged += new System.EventHandler(this.dg_cajas_SelectionChanged);
            // 
            // btn_cerrar_productos
            // 
            this.btn_cerrar_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_cerrar_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_productos.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_productos.Image = global::Proyecto_fina.Properties.Resources.cerrar;
            this.btn_cerrar_productos.Location = new System.Drawing.Point(1016, 52);
            this.btn_cerrar_productos.Name = "btn_cerrar_productos";
            this.btn_cerrar_productos.Size = new System.Drawing.Size(36, 36);
            this.btn_cerrar_productos.TabIndex = 121;
            this.btn_cerrar_productos.UseVisualStyleBackColor = false;
            this.btn_cerrar_productos.Click += new System.EventHandler(this.btn_cerrar_productos_Click);
            // 
            // img_tabla_vacia
            // 
            this.img_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.img_tabla_vacia.Image = global::Proyecto_fina.Properties.Resources.nada_encontrado;
            this.img_tabla_vacia.Location = new System.Drawing.Point(413, 273);
            this.img_tabla_vacia.Name = "img_tabla_vacia";
            this.img_tabla_vacia.Size = new System.Drawing.Size(94, 97);
            this.img_tabla_vacia.TabIndex = 120;
            this.img_tabla_vacia.TabStop = false;
            this.img_tabla_vacia.Visible = false;
            // 
            // btn_editar_caja
            // 
            this.btn_editar_caja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_editar_caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_caja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editar_caja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_caja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editar_caja.Image = global::Proyecto_fina.Properties.Resources.icons8_editar_24;
            this.btn_editar_caja.Location = new System.Drawing.Point(932, 144);
            this.btn_editar_caja.Name = "btn_editar_caja";
            this.btn_editar_caja.Size = new System.Drawing.Size(120, 40);
            this.btn_editar_caja.TabIndex = 118;
            this.btn_editar_caja.Text = "Editar";
            this.btn_editar_caja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar_caja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_editar_caja.UseVisualStyleBackColor = false;
            this.btn_editar_caja.Click += new System.EventHandler(this.btn_editar_caja_Click);
            // 
            // btn_nueva_caja
            // 
            this.btn_nueva_caja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nueva_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_nueva_caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nueva_caja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nueva_caja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nueva_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_caja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nueva_caja.Image = global::Proyecto_fina.Properties.Resources.icons8_más_24;
            this.btn_nueva_caja.Location = new System.Drawing.Point(932, 98);
            this.btn_nueva_caja.Name = "btn_nueva_caja";
            this.btn_nueva_caja.Size = new System.Drawing.Size(120, 40);
            this.btn_nueva_caja.TabIndex = 117;
            this.btn_nueva_caja.Text = "Nuevo";
            this.btn_nueva_caja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nueva_caja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_nueva_caja.UseVisualStyleBackColor = false;
            this.btn_nueva_caja.Click += new System.EventHandler(this.btn_nueva_caja_Click);
            // 
            // btn_eliminar_caja
            // 
            this.btn_eliminar_caja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_eliminar_caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_caja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar_caja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_caja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar_caja.Image = global::Proyecto_fina.Properties.Resources.icons8_residuos_24;
            this.btn_eliminar_caja.Location = new System.Drawing.Point(932, 190);
            this.btn_eliminar_caja.Name = "btn_eliminar_caja";
            this.btn_eliminar_caja.Size = new System.Drawing.Size(120, 40);
            this.btn_eliminar_caja.TabIndex = 114;
            this.btn_eliminar_caja.Text = "Eliminar";
            this.btn_eliminar_caja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_caja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_eliminar_caja.UseVisualStyleBackColor = false;
            this.btn_eliminar_caja.Click += new System.EventHandler(this.btn_eliminar_caja_Click);
            // 
            // FormCajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.img_tabla_vacia);
            this.Controls.Add(this.lbl_tabla_vacia);
            this.Controls.Add(this.btn_editar_caja);
            this.Controls.Add(this.btn_nueva_caja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_cajas);
            this.Controls.Add(this.btn_eliminar_caja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCajas";
            this.Text = "FormCajas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cajas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_usuario_cambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fecha_cambio;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.PictureBox img_tabla_vacia;
        private System.Windows.Forms.Label lbl_tabla_vacia;
        private System.Windows.Forms.Button btn_editar_caja;
        private System.Windows.Forms.Button btn_nueva_caja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_cajas;
        private System.Windows.Forms.Button btn_eliminar_caja;
    }
}