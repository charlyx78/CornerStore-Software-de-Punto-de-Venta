
namespace Proyecto_fina
{
    partial class FormCajeros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_usuario_cambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha_cambio = new System.Windows.Forms.TextBox();
            this.lbl_tabla_vacia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_cajeros = new System.Windows.Forms.DataGridView();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.img_tabla_vacia = new System.Windows.Forms.PictureBox();
            this.btn_editar_cajero = new System.Windows.Forms.Button();
            this.btn_nuevo_cajero = new System.Windows.Forms.Button();
            this.btn_eliminar_cajero = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cajeros)).BeginInit();
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
            // 
            // lbl_tabla_vacia
            // 
            this.lbl_tabla_vacia.AutoSize = true;
            this.lbl_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.lbl_tabla_vacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabla_vacia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tabla_vacia.Location = new System.Drawing.Point(206, 383);
            this.lbl_tabla_vacia.Name = "lbl_tabla_vacia";
            this.lbl_tabla_vacia.Size = new System.Drawing.Size(508, 25);
            this.lbl_tabla_vacia.TabIndex = 119;
            this.lbl_tabla_vacia.Text = "NO SE ENCONTRARON CAJEROS REGISTRADOS";
            this.lbl_tabla_vacia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 116;
            this.label2.Text = "Cajeros";
            // 
            // dg_cajeros
            // 
            this.dg_cajeros.AllowUserToAddRows = false;
            this.dg_cajeros.AllowUserToDeleteRows = false;
            this.dg_cajeros.AllowUserToResizeColumns = false;
            this.dg_cajeros.AllowUserToResizeRows = false;
            this.dg_cajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_cajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_cajeros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_cajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_cajeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_cajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_cajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_cajeros.EnableHeadersVisualStyles = false;
            this.dg_cajeros.GridColor = System.Drawing.SystemColors.Control;
            this.dg_cajeros.Location = new System.Drawing.Point(12, 98);
            this.dg_cajeros.Name = "dg_cajeros";
            this.dg_cajeros.ReadOnly = true;
            this.dg_cajeros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_cajeros.RowHeadersVisible = false;
            this.dg_cajeros.RowHeadersWidth = 80;
            this.dg_cajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_cajeros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_cajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_cajeros.Size = new System.Drawing.Size(897, 523);
            this.dg_cajeros.TabIndex = 115;            // 
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
            // btn_editar_cajero
            // 
            this.btn_editar_cajero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar_cajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_editar_cajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_cajero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editar_cajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar_cajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_cajero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editar_cajero.Image = global::Proyecto_fina.Properties.Resources.icons8_editar_24;
            this.btn_editar_cajero.Location = new System.Drawing.Point(932, 144);
            this.btn_editar_cajero.Name = "btn_editar_cajero";
            this.btn_editar_cajero.Size = new System.Drawing.Size(120, 40);
            this.btn_editar_cajero.TabIndex = 118;
            this.btn_editar_cajero.Text = "Editar";
            this.btn_editar_cajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar_cajero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_editar_cajero.UseVisualStyleBackColor = false;
            this.btn_editar_cajero.Click += new System.EventHandler(this.btn_editar_cajero_Click);
            // 
            // btn_nuevo_cajero
            // 
            this.btn_nuevo_cajero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo_cajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_nuevo_cajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_cajero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nuevo_cajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nuevo_cajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_cajero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevo_cajero.Image = global::Proyecto_fina.Properties.Resources.icons8_más_24;
            this.btn_nuevo_cajero.Location = new System.Drawing.Point(932, 98);
            this.btn_nuevo_cajero.Name = "btn_nuevo_cajero";
            this.btn_nuevo_cajero.Size = new System.Drawing.Size(120, 40);
            this.btn_nuevo_cajero.TabIndex = 117;
            this.btn_nuevo_cajero.Text = "Nuevo";
            this.btn_nuevo_cajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nuevo_cajero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_nuevo_cajero.UseVisualStyleBackColor = false;
            this.btn_nuevo_cajero.Click += new System.EventHandler(this.btn_nuevo_cajero_Click);
            // 
            // btn_eliminar_cajero
            // 
            this.btn_eliminar_cajero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_cajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_eliminar_cajero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_cajero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar_cajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar_cajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_cajero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar_cajero.Image = global::Proyecto_fina.Properties.Resources.icons8_residuos_24;
            this.btn_eliminar_cajero.Location = new System.Drawing.Point(932, 190);
            this.btn_eliminar_cajero.Name = "btn_eliminar_cajero";
            this.btn_eliminar_cajero.Size = new System.Drawing.Size(120, 40);
            this.btn_eliminar_cajero.TabIndex = 114;
            this.btn_eliminar_cajero.Text = "Eliminar";
            this.btn_eliminar_cajero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_cajero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_eliminar_cajero.UseVisualStyleBackColor = false;
            this.btn_eliminar_cajero.Click += new System.EventHandler(this.btn_eliminar_cajero_Click);
            // 
            // FormCajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.img_tabla_vacia);
            this.Controls.Add(this.lbl_tabla_vacia);
            this.Controls.Add(this.btn_editar_cajero);
            this.Controls.Add(this.btn_nuevo_cajero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_cajeros);
            this.Controls.Add(this.btn_eliminar_cajero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCajeros";
            this.Text = "FormCajeros";
            this.Load += new System.EventHandler(this.FormCajeros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cajeros)).EndInit();
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
        private System.Windows.Forms.Button btn_editar_cajero;
        private System.Windows.Forms.Button btn_nuevo_cajero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_cajeros;
        private System.Windows.Forms.Button btn_eliminar_cajero;
    }
}