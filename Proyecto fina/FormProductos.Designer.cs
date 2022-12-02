
namespace Proyecto_fina
{
    partial class FormProductos
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
            this.btn_eliminar_producto = new System.Windows.Forms.Button();
            this.btn_editar_producto = new System.Windows.Forms.Button();
            this.btn_nuevo_producto = new System.Windows.Forms.Button();
            this.dg_productos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_usuario_cambio = new System.Windows.Forms.Label();
            this.lbl_fecha_cambio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_eliminar_producto
            // 
            this.btn_eliminar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_eliminar_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar_producto.Location = new System.Drawing.Point(932, 132);
            this.btn_eliminar_producto.Name = "btn_eliminar_producto";
            this.btn_eliminar_producto.Size = new System.Drawing.Size(120, 30);
            this.btn_eliminar_producto.TabIndex = 54;
            this.btn_eliminar_producto.Text = "Eliminar";
            this.btn_eliminar_producto.UseVisualStyleBackColor = false;
            this.btn_eliminar_producto.Click += new System.EventHandler(this.btn_eliminar_producto_Click);
            // 
            // btn_editar_producto
            // 
            this.btn_editar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_editar_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editar_producto.Location = new System.Drawing.Point(932, 86);
            this.btn_editar_producto.Name = "btn_editar_producto";
            this.btn_editar_producto.Size = new System.Drawing.Size(120, 30);
            this.btn_editar_producto.TabIndex = 53;
            this.btn_editar_producto.Text = "Editar";
            this.btn_editar_producto.UseVisualStyleBackColor = false;
            this.btn_editar_producto.Click += new System.EventHandler(this.btn_editar_producto_Click);
            // 
            // btn_nuevo_producto
            // 
            this.btn_nuevo_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_nuevo_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nuevo_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevo_producto.Location = new System.Drawing.Point(932, 40);
            this.btn_nuevo_producto.Name = "btn_nuevo_producto";
            this.btn_nuevo_producto.Size = new System.Drawing.Size(120, 30);
            this.btn_nuevo_producto.TabIndex = 52;
            this.btn_nuevo_producto.Text = "Nuevo";
            this.btn_nuevo_producto.UseVisualStyleBackColor = false;
            this.btn_nuevo_producto.Click += new System.EventHandler(this.btn_nuevo_producto_Click_1);
            // 
            // dg_productos
            // 
            this.dg_productos.AllowUserToAddRows = false;
            this.dg_productos.AllowUserToDeleteRows = false;
            this.dg_productos.AllowUserToResizeColumns = false;
            this.dg_productos.AllowUserToResizeRows = false;
            this.dg_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_productos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_productos.EnableHeadersVisualStyles = false;
            this.dg_productos.GridColor = System.Drawing.SystemColors.Control;
            this.dg_productos.Location = new System.Drawing.Point(12, 40);
            this.dg_productos.Name = "dg_productos";
            this.dg_productos.ReadOnly = true;
            this.dg_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_productos.RowHeadersVisible = false;
            this.dg_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_productos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_productos.Size = new System.Drawing.Size(914, 499);
            this.dg_productos.TabIndex = 49;
            this.dg_productos.SelectionChanged += new System.EventHandler(this.dg_productos_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Productos";
            // 
            // btn_cerrar_productos
            // 
            this.btn_cerrar_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_productos.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar_productos.Location = new System.Drawing.Point(1024, 8);
            this.btn_cerrar_productos.Name = "btn_cerrar_productos";
            this.btn_cerrar_productos.Size = new System.Drawing.Size(28, 23);
            this.btn_cerrar_productos.TabIndex = 74;
            this.btn_cerrar_productos.Text = "X";
            this.btn_cerrar_productos.UseVisualStyleBackColor = true;
            this.btn_cerrar_productos.Click += new System.EventHandler(this.btn_cerrar_productos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.lbl_usuario_cambio);
            this.flowLayoutPanel1.Controls.Add(this.lbl_fecha_cambio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(244, 545);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 25);
            this.flowLayoutPanel1.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "ULTIMO CAMBIO:";
            this.label6.Visible = false;
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
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_eliminar_producto);
            this.Controls.Add(this.btn_editar_producto);
            this.Controls.Add(this.btn_nuevo_producto);
            this.Controls.Add(this.dg_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_eliminar_producto;
        private System.Windows.Forms.Button btn_editar_producto;
        private System.Windows.Forms.Button btn_nuevo_producto;
        private System.Windows.Forms.DataGridView dg_productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_usuario_cambio;
        private System.Windows.Forms.Label lbl_fecha_cambio;
    }
}