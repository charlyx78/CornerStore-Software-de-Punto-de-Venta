
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
            this.btn_eliminar_descuento = new System.Windows.Forms.Button();
            this.btn_editar_descuento = new System.Windows.Forms.Button();
            this.btn_nuevo_descuento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_usuario_cambio = new System.Windows.Forms.TextBox();
            this.txt_fecha_cambio = new System.Windows.Forms.TextBox();
            this.dg_descuentos = new System.Windows.Forms.DataGridView();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_descuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar_descuento
            // 
            this.btn_eliminar_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_eliminar_descuento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar_descuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_descuento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar_descuento.Location = new System.Drawing.Point(932, 170);
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
            this.btn_editar_descuento.Location = new System.Drawing.Point(932, 124);
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
            this.btn_nuevo_descuento.Location = new System.Drawing.Point(932, 78);
            this.btn_nuevo_descuento.Name = "btn_nuevo_descuento";
            this.btn_nuevo_descuento.Size = new System.Drawing.Size(120, 30);
            this.btn_nuevo_descuento.TabIndex = 75;
            this.btn_nuevo_descuento.Text = "Nuevo";
            this.btn_nuevo_descuento.UseVisualStyleBackColor = false;
            this.btn_nuevo_descuento.Click += new System.EventHandler(this.btn_nuevo_descuento_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Descuentos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_usuario_cambio);
            this.panel1.Controls.Add(this.txt_fecha_cambio);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 21);
            this.panel1.TabIndex = 86;
            // 
            // txt_usuario_cambio
            // 
            this.txt_usuario_cambio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_usuario_cambio.Location = new System.Drawing.Point(104, 0);
            this.txt_usuario_cambio.Name = "txt_usuario_cambio";
            this.txt_usuario_cambio.ReadOnly = true;
            this.txt_usuario_cambio.Size = new System.Drawing.Size(404, 20);
            this.txt_usuario_cambio.TabIndex = 83;
            // 
            // txt_fecha_cambio
            // 
            this.txt_fecha_cambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fecha_cambio.Location = new System.Drawing.Point(514, 0);
            this.txt_fecha_cambio.Name = "txt_fecha_cambio";
            this.txt_fecha_cambio.ReadOnly = true;
            this.txt_fecha_cambio.Size = new System.Drawing.Size(383, 20);
            this.txt_fecha_cambio.TabIndex = 84;
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
            this.dg_descuentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.dg_descuentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_descuentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_descuentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_descuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_descuentos.EnableHeadersVisualStyles = false;
            this.dg_descuentos.GridColor = System.Drawing.SystemColors.Control;
            this.dg_descuentos.Location = new System.Drawing.Point(12, 78);
            this.dg_descuentos.Name = "dg_descuentos";
            this.dg_descuentos.ReadOnly = true;
            this.dg_descuentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_descuentos.RowHeadersVisible = false;
            this.dg_descuentos.RowHeadersWidth = 80;
            this.dg_descuentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_descuentos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_descuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_descuentos.Size = new System.Drawing.Size(897, 497);
            this.dg_descuentos.TabIndex = 85;
            this.dg_descuentos.SelectionChanged += new System.EventHandler(this.dg_descuentos_SelectionChanged_1);
            // 
            // btn_cerrar_productos
            // 
            this.btn_cerrar_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_cerrar_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_productos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cerrar_productos.Location = new System.Drawing.Point(1020, 47);
            this.btn_cerrar_productos.Name = "btn_cerrar_productos";
            this.btn_cerrar_productos.Size = new System.Drawing.Size(32, 25);
            this.btn_cerrar_productos.TabIndex = 85;
            this.btn_cerrar_productos.Text = "X";
            this.btn_cerrar_productos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar_productos.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "ULTIMO CAMBIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // FormDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_descuentos);
            this.Controls.Add(this.btn_eliminar_descuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_editar_descuento);
            this.Controls.Add(this.btn_nuevo_descuento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDescuentos";
            this.Text = "FormDescuentos";
            this.Load += new System.EventHandler(this.FormDescuentos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_descuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_eliminar_descuento;
        private System.Windows.Forms.Button btn_editar_descuento;
        private System.Windows.Forms.Button btn_nuevo_descuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_usuario_cambio;
        private System.Windows.Forms.TextBox txt_fecha_cambio;
        private System.Windows.Forms.DataGridView dg_descuentos;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.Label label1;
    }
}