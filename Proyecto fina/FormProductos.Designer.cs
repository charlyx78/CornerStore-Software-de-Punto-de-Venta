
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_eliminar_producto = new System.Windows.Forms.Button();
            this.btn_editar_producto = new System.Windows.Forms.Button();
            this.btn_nuevo_producto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_usuario_cambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fecha_cambio = new System.Windows.Forms.TextBox();
            this.dg_productos = new System.Windows.Forms.DataGridView();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.img_tabla_vacia = new System.Windows.Forms.PictureBox();
            this.lbl_tabla_vacia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).BeginInit();
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
            this.btn_eliminar_producto.Location = new System.Drawing.Point(932, 170);
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
            this.btn_editar_producto.Location = new System.Drawing.Point(932, 124);
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
            this.btn_nuevo_producto.Location = new System.Drawing.Point(932, 78);
            this.btn_nuevo_producto.Name = "btn_nuevo_producto";
            this.btn_nuevo_producto.Size = new System.Drawing.Size(120, 30);
            this.btn_nuevo_producto.TabIndex = 52;
            this.btn_nuevo_producto.Text = "Nuevo";
            this.btn_nuevo_producto.UseVisualStyleBackColor = false;
            this.btn_nuevo_producto.Click += new System.EventHandler(this.btn_nuevo_producto_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Productos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txt_usuario_cambio);
            this.panel1.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 3);
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
            this.txt_fecha_cambio.Location = new System.Drawing.Point(514, 0);
            this.txt_fecha_cambio.Name = "txt_fecha_cambio";
            this.txt_fecha_cambio.ReadOnly = true;
            this.txt_fecha_cambio.Size = new System.Drawing.Size(383, 20);
            this.txt_fecha_cambio.TabIndex = 84;
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
            this.dg_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_productos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.dg_productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_productos.EnableHeadersVisualStyles = false;
            this.dg_productos.GridColor = System.Drawing.SystemColors.Control;
            this.dg_productos.Location = new System.Drawing.Point(12, 78);
            this.dg_productos.Name = "dg_productos";
            this.dg_productos.ReadOnly = true;
            this.dg_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_productos.RowHeadersVisible = false;
            this.dg_productos.RowHeadersWidth = 80;
            this.dg_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_productos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_productos.Size = new System.Drawing.Size(897, 497);
            this.dg_productos.TabIndex = 85;
            this.dg_productos.SelectionChanged += new System.EventHandler(this.dg_productos_SelectionChanged_1);
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
            // img_tabla_vacia
            // 
            this.img_tabla_vacia.Image = global::Proyecto_fina.Properties.Resources.nada_encontrado;
            this.img_tabla_vacia.Location = new System.Drawing.Point(457, 253);
            this.img_tabla_vacia.Name = "img_tabla_vacia";
            this.img_tabla_vacia.Size = new System.Drawing.Size(94, 97);
            this.img_tabla_vacia.TabIndex = 96;
            this.img_tabla_vacia.TabStop = false;
            this.img_tabla_vacia.Visible = false;
            // 
            // lbl_tabla_vacia
            // 
            this.lbl_tabla_vacia.AutoSize = true;
            this.lbl_tabla_vacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabla_vacia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tabla_vacia.Location = new System.Drawing.Point(233, 363);
            this.lbl_tabla_vacia.Name = "lbl_tabla_vacia";
            this.lbl_tabla_vacia.Size = new System.Drawing.Size(542, 25);
            this.lbl_tabla_vacia.TabIndex = 95;
            this.lbl_tabla_vacia.Text = "NO SE ENCONTRARON PRODUCTOS REGISTRADOS";
            this.lbl_tabla_vacia.Visible = false;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.img_tabla_vacia);
            this.Controls.Add(this.lbl_tabla_vacia);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_productos);
            this.Controls.Add(this.btn_eliminar_producto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_editar_producto);
            this.Controls.Add(this.btn_nuevo_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_eliminar_producto;
        private System.Windows.Forms.Button btn_editar_producto;
        private System.Windows.Forms.Button btn_nuevo_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_usuario_cambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fecha_cambio;
        private System.Windows.Forms.DataGridView dg_productos;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.PictureBox img_tabla_vacia;
        private System.Windows.Forms.Label lbl_tabla_vacia;
    }
}