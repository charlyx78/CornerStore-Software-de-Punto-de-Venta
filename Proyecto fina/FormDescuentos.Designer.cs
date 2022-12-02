
namespace Proyecto_fina
{
    partial class FormDescuentos
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
            this.dg_descuentos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.btn_eliminar_descuento = new System.Windows.Forms.Button();
            this.btn_editar_descuento = new System.Windows.Forms.Button();
            this.btn_nuevo_descuento = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_usuario_cambio = new System.Windows.Forms.Label();
            this.lbl_fecha_cambio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_descuentos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_descuentos
            // 
            this.dg_descuentos.AllowUserToAddRows = false;
            this.dg_descuentos.AllowUserToDeleteRows = false;
            this.dg_descuentos.AllowUserToResizeColumns = false;
            this.dg_descuentos.AllowUserToResizeRows = false;
            this.dg_descuentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_descuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_descuentos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_descuentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_descuentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_descuentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_descuentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_descuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_descuentos.EnableHeadersVisualStyles = false;
            this.dg_descuentos.GridColor = System.Drawing.SystemColors.Control;
            this.dg_descuentos.Location = new System.Drawing.Point(16, 42);
            this.dg_descuentos.Name = "dg_descuentos";
            this.dg_descuentos.ReadOnly = true;
            this.dg_descuentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_descuentos.RowHeadersVisible = false;
            this.dg_descuentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_descuentos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_descuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_descuentos.Size = new System.Drawing.Size(914, 497);
            this.dg_descuentos.TabIndex = 50;
            this.dg_descuentos.SelectionChanged += new System.EventHandler(this.dg_descuentos_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Descuentos";
            // 
            // btn_cerrar_productos
            // 
            this.btn_cerrar_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_productos.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar_productos.Location = new System.Drawing.Point(1024, 8);
            this.btn_cerrar_productos.Name = "btn_cerrar_productos";
            this.btn_cerrar_productos.Size = new System.Drawing.Size(28, 23);
            this.btn_cerrar_productos.TabIndex = 78;
            this.btn_cerrar_productos.Text = "X";
            this.btn_cerrar_productos.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar_descuento
            // 
            this.btn_eliminar_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_eliminar_descuento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_descuento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar_descuento.Location = new System.Drawing.Point(932, 134);
            this.btn_eliminar_descuento.Name = "btn_eliminar_descuento";
            this.btn_eliminar_descuento.Size = new System.Drawing.Size(120, 30);
            this.btn_eliminar_descuento.TabIndex = 77;
            this.btn_eliminar_descuento.Text = "Eliminar";
            this.btn_eliminar_descuento.UseVisualStyleBackColor = false;
            this.btn_eliminar_descuento.Click += new System.EventHandler(this.btn_eliminar_descuento_Click);
            // 
            // btn_editar_descuento
            // 
            this.btn_editar_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_editar_descuento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editar_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_descuento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editar_descuento.Location = new System.Drawing.Point(932, 88);
            this.btn_editar_descuento.Name = "btn_editar_descuento";
            this.btn_editar_descuento.Size = new System.Drawing.Size(120, 30);
            this.btn_editar_descuento.TabIndex = 76;
            this.btn_editar_descuento.Text = "Editar";
            this.btn_editar_descuento.UseVisualStyleBackColor = false;
            this.btn_editar_descuento.Click += new System.EventHandler(this.btn_editar_descuento_Click);
            // 
            // btn_nuevo_descuento
            // 
            this.btn_nuevo_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_nuevo_descuento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nuevo_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_descuento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevo_descuento.Location = new System.Drawing.Point(932, 42);
            this.btn_nuevo_descuento.Name = "btn_nuevo_descuento";
            this.btn_nuevo_descuento.Size = new System.Drawing.Size(120, 30);
            this.btn_nuevo_descuento.TabIndex = 75;
            this.btn_nuevo_descuento.Text = "Nuevo";
            this.btn_nuevo_descuento.UseVisualStyleBackColor = false;
            this.btn_nuevo_descuento.Click += new System.EventHandler(this.btn_nuevo_descuento_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lbl_usuario_cambio);
            this.flowLayoutPanel1.Controls.Add(this.lbl_fecha_cambio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(244, 545);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 25);
            this.flowLayoutPanel1.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "ULTIMO CAMBIO:";
            this.label1.Visible = false;
            // 
            // lbl_usuario_cambio
            // 
            this.lbl_usuario_cambio.AutoSize = true;
            this.lbl_usuario_cambio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_usuario_cambio.Location = new System.Drawing.Point(104, 0);
            this.lbl_usuario_cambio.Name = "lbl_usuario_cambio";
            this.lbl_usuario_cambio.Size = new System.Drawing.Size(41, 13);
            this.lbl_usuario_cambio.TabIndex = 80;
            this.lbl_usuario_cambio.Text = "usuario";
            this.lbl_usuario_cambio.Visible = false;
            // 
            // lbl_fecha_cambio
            // 
            this.lbl_fecha_cambio.AutoSize = true;
            this.lbl_fecha_cambio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_fecha_cambio.Location = new System.Drawing.Point(151, 0);
            this.lbl_fecha_cambio.Name = "lbl_fecha_cambio";
            this.lbl_fecha_cambio.Size = new System.Drawing.Size(34, 13);
            this.lbl_fecha_cambio.TabIndex = 81;
            this.lbl_fecha_cambio.Text = "fecha";
            this.lbl_fecha_cambio.Visible = false;
            // 
            // FormDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.btn_eliminar_descuento);
            this.Controls.Add(this.btn_editar_descuento);
            this.Controls.Add(this.btn_nuevo_descuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_descuentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDescuentos";
            this.Text = "FormDescuentos";
            this.Load += new System.EventHandler(this.FormDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_descuentos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_descuentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.Button btn_eliminar_descuento;
        private System.Windows.Forms.Button btn_editar_descuento;
        private System.Windows.Forms.Button btn_nuevo_descuento;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_usuario_cambio;
        private System.Windows.Forms.Label lbl_fecha_cambio;
    }
}