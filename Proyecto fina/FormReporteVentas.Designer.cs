
namespace Proyecto_fina
{
    partial class FormReporteVentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_caja = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filtros = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tabla_vacia = new System.Windows.Forms.Label();
            this.dg_ventas = new System.Windows.Forms.DataGridView();
            this.id_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades_vendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_suma_subtotal = new System.Windows.Forms.NumericUpDown();
            this.txt_suma_total_descuento = new System.Windows.Forms.NumericUpDown();
            this.txt_suma_total = new System.Windows.Forms.NumericUpDown();
            this.txt_suma_utilidad = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.img_tabla_vacia = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_subtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_total_descuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_utilidad)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Reporte de ventas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cb_caja);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_departamento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_filtros);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 60);
            this.panel1.TabIndex = 117;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(508, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(487, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(278, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 108;
            this.label4.Text = "Entre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 107;
            // 
            // cb_caja
            // 
            this.cb_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_caja.FormattingEnabled = true;
            this.cb_caja.Location = new System.Drawing.Point(215, 27);
            this.cb_caja.Name = "cb_caja";
            this.cb_caja.Size = new System.Drawing.Size(55, 24);
            this.cb_caja.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(212, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Caja";
            // 
            // cb_departamento
            // 
            this.cb_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(9, 27);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(195, 24);
            this.cb_departamento.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Departamento";
            // 
            // btn_filtros
            // 
            this.btn_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_filtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filtros.Location = new System.Drawing.Point(879, 26);
            this.btn_filtros.Name = "btn_filtros";
            this.btn_filtros.Size = new System.Drawing.Size(104, 25);
            this.btn_filtros.TabIndex = 104;
            this.btn_filtros.Text = "Buscar";
            this.btn_filtros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_filtros.UseVisualStyleBackColor = false;
            this.btn_filtros.Click += new System.EventHandler(this.btn_filtros_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 116;
            this.label5.Text = "Búsqueda por filtros";
            // 
            // lbl_tabla_vacia
            // 
            this.lbl_tabla_vacia.AutoSize = true;
            this.lbl_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lbl_tabla_vacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabla_vacia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tabla_vacia.Location = new System.Drawing.Point(262, 381);
            this.lbl_tabla_vacia.Name = "lbl_tabla_vacia";
            this.lbl_tabla_vacia.Size = new System.Drawing.Size(491, 25);
            this.lbl_tabla_vacia.TabIndex = 114;
            this.lbl_tabla_vacia.Text = "NO SE ENCONTRARON VENTAS REGISTRADAS";
            this.lbl_tabla_vacia.Visible = false;
            // 
            // dg_ventas
            // 
            this.dg_ventas.AllowUserToAddRows = false;
            this.dg_ventas.AllowUserToDeleteRows = false;
            this.dg_ventas.AllowUserToResizeColumns = false;
            this.dg_ventas.AllowUserToResizeRows = false;
            this.dg_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_ventas.ColumnHeadersHeight = 40;
            this.dg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ticket,
            this.caja,
            this.fecha_venta,
            this.nombre_departamento,
            this.nombre_producto,
            this.id_producto,
            this.precio_producto,
            this.unidades_vendidas,
            this.subtotal,
            this.descuento_venta,
            this.total,
            this.utilidad});
            this.dg_ventas.EnableHeadersVisualStyles = false;
            this.dg_ventas.GridColor = System.Drawing.SystemColors.Control;
            this.dg_ventas.Location = new System.Drawing.Point(12, 132);
            this.dg_ventas.Name = "dg_ventas";
            this.dg_ventas.ReadOnly = true;
            this.dg_ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_ventas.RowHeadersVisible = false;
            this.dg_ventas.RowHeadersWidth = 80;
            this.dg_ventas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_ventas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_ventas.Size = new System.Drawing.Size(991, 457);
            this.dg_ventas.TabIndex = 113;
            // 
            // id_ticket
            // 
            this.id_ticket.HeaderText = "Código de ticket";
            this.id_ticket.Name = "id_ticket";
            this.id_ticket.ReadOnly = true;
            // 
            // caja
            // 
            this.caja.HeaderText = "Caja";
            this.caja.Name = "caja";
            this.caja.ReadOnly = true;
            // 
            // fecha_venta
            // 
            this.fecha_venta.HeaderText = "Fecha de venta";
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.ReadOnly = true;
            // 
            // nombre_departamento
            // 
            this.nombre_departamento.HeaderText = "Departamento";
            this.nombre_departamento.Name = "nombre_departamento";
            this.nombre_departamento.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Nombre del producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Código del producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // precio_producto
            // 
            this.precio_producto.HeaderText = "Precio";
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.ReadOnly = true;
            // 
            // unidades_vendidas
            // 
            this.unidades_vendidas.HeaderText = "Unidades vendidas";
            this.unidades_vendidas.Name = "unidades_vendidas";
            this.unidades_vendidas.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // descuento_venta
            // 
            this.descuento_venta.HeaderText = "Descuento";
            this.descuento_venta.Name = "descuento_venta";
            this.descuento_venta.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // utilidad
            // 
            this.utilidad.HeaderText = "Utilidad";
            this.utilidad.Name = "utilidad";
            this.utilidad.ReadOnly = true;
            // 
            // txt_suma_subtotal
            // 
            this.txt_suma_subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_suma_subtotal.DecimalPlaces = 2;
            this.txt_suma_subtotal.Enabled = false;
            this.txt_suma_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_subtotal.Location = new System.Drawing.Point(130, 9);
            this.txt_suma_subtotal.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_suma_subtotal.Name = "txt_suma_subtotal";
            this.txt_suma_subtotal.ReadOnly = true;
            this.txt_suma_subtotal.Size = new System.Drawing.Size(67, 22);
            this.txt_suma_subtotal.TabIndex = 119;
            this.txt_suma_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_suma_total_descuento
            // 
            this.txt_suma_total_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_suma_total_descuento.DecimalPlaces = 2;
            this.txt_suma_total_descuento.Enabled = false;
            this.txt_suma_total_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_total_descuento.Location = new System.Drawing.Point(337, 9);
            this.txt_suma_total_descuento.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_suma_total_descuento.Name = "txt_suma_total_descuento";
            this.txt_suma_total_descuento.ReadOnly = true;
            this.txt_suma_total_descuento.Size = new System.Drawing.Size(67, 22);
            this.txt_suma_total_descuento.TabIndex = 120;
            this.txt_suma_total_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_suma_total
            // 
            this.txt_suma_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_suma_total.DecimalPlaces = 2;
            this.txt_suma_total.Enabled = false;
            this.txt_suma_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_total.Location = new System.Drawing.Point(506, 9);
            this.txt_suma_total.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_suma_total.Name = "txt_suma_total";
            this.txt_suma_total.ReadOnly = true;
            this.txt_suma_total.Size = new System.Drawing.Size(67, 22);
            this.txt_suma_total.TabIndex = 121;
            this.txt_suma_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_suma_utilidad
            // 
            this.txt_suma_utilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_suma_utilidad.DecimalPlaces = 2;
            this.txt_suma_utilidad.Enabled = false;
            this.txt_suma_utilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_utilidad.Location = new System.Drawing.Point(688, 9);
            this.txt_suma_utilidad.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_suma_utilidad.Minimum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            -2147483648});
            this.txt_suma_utilidad.Name = "txt_suma_utilidad";
            this.txt_suma_utilidad.ReadOnly = true;
            this.txt_suma_utilidad.Size = new System.Drawing.Size(67, 22);
            this.txt_suma_utilidad.TabIndex = 122;
            this.txt_suma_utilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.txt_suma_utilidad);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_suma_subtotal);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_suma_total_descuento);
            this.panel2.Controls.Add(this.txt_suma_total);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(240, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 41);
            this.panel2.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(203, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 120;
            this.label8.Text = "Suma de descuento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 119;
            this.label7.Text = "Suma de subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(410, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 121;
            this.label9.Text = "Suma de total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(579, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 16);
            this.label10.TabIndex = 122;
            this.label10.Text = "Suma de utilidad";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Proyecto_fina.Properties.Resources.cerrar;
            this.button1.Location = new System.Drawing.Point(1016, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 118;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // img_tabla_vacia
            // 
            this.img_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.img_tabla_vacia.Image = global::Proyecto_fina.Properties.Resources.nada_encontrado;
            this.img_tabla_vacia.Location = new System.Drawing.Point(460, 271);
            this.img_tabla_vacia.Name = "img_tabla_vacia";
            this.img_tabla_vacia.Size = new System.Drawing.Size(94, 97);
            this.img_tabla_vacia.TabIndex = 115;
            this.img_tabla_vacia.TabStop = false;
            this.img_tabla_vacia.Visible = false;
            // 
            // FormReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img_tabla_vacia);
            this.Controls.Add(this.lbl_tabla_vacia);
            this.Controls.Add(this.dg_ventas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteVentas";
            this.Text = "FormReporteVentas";
            this.Load += new System.EventHandler(this.FormReporteVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_subtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_total_descuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_utilidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_filtros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img_tabla_vacia;
        private System.Windows.Forms.Label lbl_tabla_vacia;
        private System.Windows.Forms.DataGridView dg_ventas;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_caja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades_vendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidad;
        public System.Windows.Forms.NumericUpDown txt_suma_subtotal;
        public System.Windows.Forms.NumericUpDown txt_suma_total_descuento;
        public System.Windows.Forms.NumericUpDown txt_suma_total;
        public System.Windows.Forms.NumericUpDown txt_suma_utilidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}