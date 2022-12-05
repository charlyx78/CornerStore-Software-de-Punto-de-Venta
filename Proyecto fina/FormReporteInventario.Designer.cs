
namespace Proyecto_fina
{
    partial class FormReporteInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.dg_productos = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendidos_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.merma_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_tabla_vacia = new System.Windows.Forms.Label();
            this.img_tabla_vacia = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_existencia_minima = new System.Windows.Forms.NumericUpDown();
            this.chb_productos_mermados = new System.Windows.Forms.CheckBox();
            this.rb_productos_agotados_si = new System.Windows.Forms.RadioButton();
            this.rb_productos_agotados_no = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_filtros = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_existencia_minima)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Inventario de productos";
            // 
            // btn_cerrar_productos
            // 
            this.btn_cerrar_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_cerrar_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_productos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cerrar_productos.Location = new System.Drawing.Point(1020, 47);
            this.btn_cerrar_productos.Name = "btn_cerrar_productos";
            this.btn_cerrar_productos.Size = new System.Drawing.Size(32, 25);
            this.btn_cerrar_productos.TabIndex = 89;
            this.btn_cerrar_productos.Text = "X";
            this.btn_cerrar_productos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar_productos.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_departamento,
            this.nombre_producto,
            this.costo_producto,
            this.precio_producto,
            this.existencia_producto,
            this.vendidos_producto,
            this.utilidad_producto,
            this.merma_producto});
            this.dg_productos.EnableHeadersVisualStyles = false;
            this.dg_productos.GridColor = System.Drawing.SystemColors.Control;
            this.dg_productos.Location = new System.Drawing.Point(12, 119);
            this.dg_productos.Name = "dg_productos";
            this.dg_productos.ReadOnly = true;
            this.dg_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_productos.RowHeadersVisible = false;
            this.dg_productos.RowHeadersWidth = 80;
            this.dg_productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_productos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_productos.Size = new System.Drawing.Size(991, 510);
            this.dg_productos.TabIndex = 90;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // nombre_departamento
            // 
            this.nombre_departamento.HeaderText = "Departamento";
            this.nombre_departamento.Name = "nombre_departamento";
            this.nombre_departamento.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // costo_producto
            // 
            this.costo_producto.HeaderText = "Costo";
            this.costo_producto.Name = "costo_producto";
            this.costo_producto.ReadOnly = true;
            // 
            // precio_producto
            // 
            this.precio_producto.HeaderText = "Precio";
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.ReadOnly = true;
            // 
            // existencia_producto
            // 
            this.existencia_producto.HeaderText = "Existencia";
            this.existencia_producto.Name = "existencia_producto";
            this.existencia_producto.ReadOnly = true;
            // 
            // vendidos_producto
            // 
            this.vendidos_producto.HeaderText = "Ventas";
            this.vendidos_producto.Name = "vendidos_producto";
            this.vendidos_producto.ReadOnly = true;
            // 
            // utilidad_producto
            // 
            this.utilidad_producto.HeaderText = "Utilidad";
            this.utilidad_producto.Name = "utilidad_producto";
            this.utilidad_producto.ReadOnly = true;
            // 
            // merma_producto
            // 
            this.merma_producto.HeaderText = "Mermas";
            this.merma_producto.Name = "merma_producto";
            this.merma_producto.ReadOnly = true;
            // 
            // lbl_tabla_vacia
            // 
            this.lbl_tabla_vacia.AutoSize = true;
            this.lbl_tabla_vacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabla_vacia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tabla_vacia.Location = new System.Drawing.Point(236, 381);
            this.lbl_tabla_vacia.Name = "lbl_tabla_vacia";
            this.lbl_tabla_vacia.Size = new System.Drawing.Size(542, 25);
            this.lbl_tabla_vacia.TabIndex = 91;
            this.lbl_tabla_vacia.Text = "NO SE ENCONTRARON PRODUCTOS REGISTRADOS";
            this.lbl_tabla_vacia.Visible = false;
            // 
            // img_tabla_vacia
            // 
            this.img_tabla_vacia.Image = global::Proyecto_fina.Properties.Resources.nada_encontrado;
            this.img_tabla_vacia.Location = new System.Drawing.Point(460, 271);
            this.img_tabla_vacia.Name = "img_tabla_vacia";
            this.img_tabla_vacia.Size = new System.Drawing.Size(94, 97);
            this.img_tabla_vacia.TabIndex = 92;
            this.img_tabla_vacia.TabStop = false;
            this.img_tabla_vacia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Departamento";
            // 
            // cb_departamento
            // 
            this.cb_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(16, 89);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(195, 24);
            this.cb_departamento.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(231, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 96;
            this.label3.Text = "Existencia mínima";
            // 
            // txt_existencia_minima
            // 
            this.txt_existencia_minima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia_minima.Location = new System.Drawing.Point(234, 89);
            this.txt_existencia_minima.Name = "txt_existencia_minima";
            this.txt_existencia_minima.Size = new System.Drawing.Size(120, 24);
            this.txt_existencia_minima.TabIndex = 97;
            // 
            // chb_productos_mermados
            // 
            this.chb_productos_mermados.AutoSize = true;
            this.chb_productos_mermados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_productos_mermados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chb_productos_mermados.Location = new System.Drawing.Point(533, 91);
            this.chb_productos_mermados.Name = "chb_productos_mermados";
            this.chb_productos_mermados.Size = new System.Drawing.Size(156, 20);
            this.chb_productos_mermados.TabIndex = 100;
            this.chb_productos_mermados.Text = "Productos mermados";
            this.chb_productos_mermados.UseVisualStyleBackColor = true;
            // 
            // rb_productos_agotados_si
            // 
            this.rb_productos_agotados_si.AutoSize = true;
            this.rb_productos_agotados_si.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_productos_agotados_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_productos_agotados_si.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_productos_agotados_si.Location = new System.Drawing.Point(380, 91);
            this.rb_productos_agotados_si.Name = "rb_productos_agotados_si";
            this.rb_productos_agotados_si.Size = new System.Drawing.Size(38, 20);
            this.rb_productos_agotados_si.TabIndex = 101;
            this.rb_productos_agotados_si.TabStop = true;
            this.rb_productos_agotados_si.Text = "Si";
            this.rb_productos_agotados_si.UseVisualStyleBackColor = true;
            // 
            // rb_productos_agotados_no
            // 
            this.rb_productos_agotados_no.AutoSize = true;
            this.rb_productos_agotados_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_productos_agotados_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_productos_agotados_no.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rb_productos_agotados_no.Location = new System.Drawing.Point(444, 90);
            this.rb_productos_agotados_no.Name = "rb_productos_agotados_no";
            this.rb_productos_agotados_no.Size = new System.Drawing.Size(44, 20);
            this.rb_productos_agotados_no.TabIndex = 102;
            this.rb_productos_agotados_no.TabStop = true;
            this.rb_productos_agotados_no.Text = "No";
            this.rb_productos_agotados_no.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(377, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 103;
            this.label4.Text = "Productos agotados";
            // 
            // btn_filtros
            // 
            this.btn_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_filtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filtros.Location = new System.Drawing.Point(715, 88);
            this.btn_filtros.Name = "btn_filtros";
            this.btn_filtros.Size = new System.Drawing.Size(104, 25);
            this.btn_filtros.TabIndex = 104;
            this.btn_filtros.Text = "Buscar";
            this.btn_filtros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_filtros.UseVisualStyleBackColor = false;
            this.btn_filtros.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 105;
            this.label5.Text = "Búsqueda por filtros";
            // 
            // FormReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_filtros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_productos_agotados_no);
            this.Controls.Add(this.rb_productos_agotados_si);
            this.Controls.Add(this.chb_productos_mermados);
            this.Controls.Add(this.txt_existencia_minima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_departamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img_tabla_vacia);
            this.Controls.Add(this.lbl_tabla_vacia);
            this.Controls.Add(this.dg_productos);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteInventario";
            this.Text = "FormReportesVentas";
            this.Load += new System.EventHandler(this.FormReportesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_existencia_minima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.DataGridView dg_productos;
        private System.Windows.Forms.Label lbl_tabla_vacia;
        private System.Windows.Forms.PictureBox img_tabla_vacia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendidos_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidad_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn merma_producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txt_existencia_minima;
        private System.Windows.Forms.CheckBox chb_productos_mermados;
        private System.Windows.Forms.RadioButton rb_productos_agotados_si;
        private System.Windows.Forms.RadioButton rb_productos_agotados_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_filtros;
        private System.Windows.Forms.Label label5;
    }
}