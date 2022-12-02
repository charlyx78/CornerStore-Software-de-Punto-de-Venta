
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
            this.label2 = new System.Windows.Forms.Label();
            this.dg_reportes_ventas = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.merma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reportes_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Reporte de inventario";
            // 
            // dg_reportes_ventas
            // 
            this.dg_reportes_ventas.AllowUserToAddRows = false;
            this.dg_reportes_ventas.AllowUserToDeleteRows = false;
            this.dg_reportes_ventas.AllowUserToResizeColumns = false;
            this.dg_reportes_ventas.AllowUserToResizeRows = false;
            this.dg_reportes_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_reportes_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_reportes_ventas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dg_reportes_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_reportes_ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_reportes_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_reportes_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_reportes_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_reportes_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.nombre_departamento,
            this.nombre_producto,
            this.unidad_medida,
            this.costo,
            this.precio,
            this.existencia,
            this.vendidos,
            this.utilidad,
            this.merma});
            this.dg_reportes_ventas.EnableHeadersVisualStyles = false;
            this.dg_reportes_ventas.GridColor = System.Drawing.SystemColors.Control;
            this.dg_reportes_ventas.Location = new System.Drawing.Point(16, 39);
            this.dg_reportes_ventas.Name = "dg_reportes_ventas";
            this.dg_reportes_ventas.ReadOnly = true;
            this.dg_reportes_ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_reportes_ventas.RowHeadersVisible = false;
            this.dg_reportes_ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_reportes_ventas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_reportes_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_reportes_ventas.Size = new System.Drawing.Size(1036, 590);
            this.dg_reportes_ventas.TabIndex = 77;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Width = 44;
            // 
            // nombre_departamento
            // 
            this.nombre_departamento.HeaderText = "Departamento";
            this.nombre_departamento.Name = "nombre_departamento";
            this.nombre_departamento.ReadOnly = true;
            this.nombre_departamento.Width = 117;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            this.nombre_producto.Width = 85;
            // 
            // unidad_medida
            // 
            this.unidad_medida.HeaderText = "Unida de medida";
            this.unidad_medida.Name = "unidad_medida";
            this.unidad_medida.ReadOnly = true;
            this.unidad_medida.Width = 135;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 66;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 70;
            // 
            // existencia
            // 
            this.existencia.HeaderText = "Existencia";
            this.existencia.Name = "existencia";
            this.existencia.ReadOnly = true;
            this.existencia.Width = 92;
            // 
            // vendidos
            // 
            this.vendidos.HeaderText = "Unidades vendidas";
            this.vendidos.Name = "vendidos";
            this.vendidos.ReadOnly = true;
            this.vendidos.Width = 149;
            // 
            // utilidad
            // 
            this.utilidad.HeaderText = "Utilidad";
            this.utilidad.Name = "utilidad";
            this.utilidad.ReadOnly = true;
            this.utilidad.Width = 77;
            // 
            // btn_cerrar_productos
            // 
            this.btn_cerrar_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_productos.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar_productos.Location = new System.Drawing.Point(1024, 12);
            this.btn_cerrar_productos.Name = "btn_cerrar_productos";
            this.btn_cerrar_productos.Size = new System.Drawing.Size(28, 23);
            this.btn_cerrar_productos.TabIndex = 78;
            this.btn_cerrar_productos.Text = "X";
            this.btn_cerrar_productos.UseVisualStyleBackColor = true;
            this.btn_cerrar_productos.Click += new System.EventHandler(this.btn_cerrar_productos_Click);
            // 
            // merma
            // 
            this.merma.HeaderText = "Merma";
            this.merma.Name = "merma";
            this.merma.ReadOnly = true;
            this.merma.Width = 73;
            // 
            // FormReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.dg_reportes_ventas);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteInventario";
            this.Text = "FormReportesVentas";
            this.Load += new System.EventHandler(this.FormReportesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reportes_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_reportes_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad_medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidad;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn merma;
    }
}