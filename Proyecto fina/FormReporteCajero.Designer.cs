
namespace Proyecto_fina
{
    partial class FormReporteCajero
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_suma_cantidades = new System.Windows.Forms.NumericUpDown();
            this.txt_suma_ventas = new System.Windows.Forms.NumericUpDown();
            this.txt_suma_utilidad = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_cajero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_filtros = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tabla_vacia = new System.Windows.Forms.Label();
            this.dg_reporte_cajeros = new System.Windows.Forms.DataGridView();
            this.fecha_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades_vendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suma_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suma_utilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.img_tabla_vacia = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_cantidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_utilidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte_cajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_suma_cantidades);
            this.panel2.Controls.Add(this.txt_suma_ventas);
            this.panel2.Controls.Add(this.txt_suma_utilidad);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(163, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 41);
            this.panel2.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(571, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 128;
            this.label9.Text = "Suma total de utilidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(2, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 16);
            this.label7.TabIndex = 111;
            this.label7.Text = "Suma de unidades vendidas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(310, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 127;
            this.label8.Text = "Suma total de ventas";
            // 
            // txt_suma_cantidades
            // 
            this.txt_suma_cantidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_suma_cantidades.DecimalPlaces = 2;
            this.txt_suma_cantidades.Enabled = false;
            this.txt_suma_cantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_cantidades.Location = new System.Drawing.Point(188, 9);
            this.txt_suma_cantidades.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_suma_cantidades.Name = "txt_suma_cantidades";
            this.txt_suma_cantidades.ReadOnly = true;
            this.txt_suma_cantidades.Size = new System.Drawing.Size(116, 22);
            this.txt_suma_cantidades.TabIndex = 120;
            this.txt_suma_cantidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_suma_ventas
            // 
            this.txt_suma_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_suma_ventas.DecimalPlaces = 2;
            this.txt_suma_ventas.Enabled = false;
            this.txt_suma_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_ventas.Location = new System.Drawing.Point(449, 9);
            this.txt_suma_ventas.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_suma_ventas.Name = "txt_suma_ventas";
            this.txt_suma_ventas.ReadOnly = true;
            this.txt_suma_ventas.Size = new System.Drawing.Size(116, 22);
            this.txt_suma_ventas.TabIndex = 121;
            this.txt_suma_ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_suma_utilidad
            // 
            this.txt_suma_utilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_suma_utilidad.DecimalPlaces = 2;
            this.txt_suma_utilidad.Enabled = false;
            this.txt_suma_utilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suma_utilidad.Location = new System.Drawing.Point(713, 9);
            this.txt_suma_utilidad.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_suma_utilidad.Name = "txt_suma_utilidad";
            this.txt_suma_utilidad.ReadOnly = true;
            this.txt_suma_utilidad.Size = new System.Drawing.Size(120, 22);
            this.txt_suma_utilidad.TabIndex = 122;
            this.txt_suma_utilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.panel1.Controls.Add(this.cb_cajero);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_departamento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_filtros);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(12, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 60);
            this.panel1.TabIndex = 124;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(658, 29);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(637, 34);
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
            this.label4.Location = new System.Drawing.Point(428, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 108;
            this.label4.Text = "Entre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(431, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 107;
            // 
            // cb_cajero
            // 
            this.cb_cajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cajero.FormattingEnabled = true;
            this.cb_cajero.Location = new System.Drawing.Point(215, 27);
            this.cb_cajero.Name = "cb_cajero";
            this.cb_cajero.Size = new System.Drawing.Size(203, 24);
            this.cb_cajero.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(212, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Cajero";
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
            this.label5.Location = new System.Drawing.Point(13, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "Búsqueda por filtros";
            // 
            // lbl_tabla_vacia
            // 
            this.lbl_tabla_vacia.AutoSize = true;
            this.lbl_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lbl_tabla_vacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabla_vacia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tabla_vacia.Location = new System.Drawing.Point(262, 377);
            this.lbl_tabla_vacia.Name = "lbl_tabla_vacia";
            this.lbl_tabla_vacia.Size = new System.Drawing.Size(508, 25);
            this.lbl_tabla_vacia.TabIndex = 121;
            this.lbl_tabla_vacia.Text = "NO SE ENCONTRARON CAJEROS REGISTRADOS";
            this.lbl_tabla_vacia.Visible = false;
            // 
            // dg_reporte_cajeros
            // 
            this.dg_reporte_cajeros.AllowUserToAddRows = false;
            this.dg_reporte_cajeros.AllowUserToDeleteRows = false;
            this.dg_reporte_cajeros.AllowUserToResizeColumns = false;
            this.dg_reporte_cajeros.AllowUserToResizeRows = false;
            this.dg_reporte_cajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_reporte_cajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_reporte_cajeros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_reporte_cajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_reporte_cajeros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_reporte_cajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_reporte_cajeros.ColumnHeadersHeight = 40;
            this.dg_reporte_cajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_reporte_cajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha_venta,
            this.producto,
            this.nombre_departamento,
            this.nombre_cajero,
            this.unidades_vendidas,
            this.suma_venta,
            this.suma_utilidad});
            this.dg_reporte_cajeros.EnableHeadersVisualStyles = false;
            this.dg_reporte_cajeros.GridColor = System.Drawing.SystemColors.Control;
            this.dg_reporte_cajeros.Location = new System.Drawing.Point(12, 128);
            this.dg_reporte_cajeros.Name = "dg_reporte_cajeros";
            this.dg_reporte_cajeros.ReadOnly = true;
            this.dg_reporte_cajeros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_reporte_cajeros.RowHeadersVisible = false;
            this.dg_reporte_cajeros.RowHeadersWidth = 80;
            this.dg_reporte_cajeros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_reporte_cajeros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_reporte_cajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_reporte_cajeros.Size = new System.Drawing.Size(991, 457);
            this.dg_reporte_cajeros.TabIndex = 120;
            // 
            // fecha_venta
            // 
            this.fecha_venta.HeaderText = "Fecha de venta";
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // nombre_departamento
            // 
            this.nombre_departamento.HeaderText = "Departamento";
            this.nombre_departamento.Name = "nombre_departamento";
            this.nombre_departamento.ReadOnly = true;
            // 
            // nombre_cajero
            // 
            this.nombre_cajero.HeaderText = "Cajero";
            this.nombre_cajero.Name = "nombre_cajero";
            this.nombre_cajero.ReadOnly = true;
            // 
            // unidades_vendidas
            // 
            this.unidades_vendidas.HeaderText = "Unidades vendidas";
            this.unidades_vendidas.Name = "unidades_vendidas";
            this.unidades_vendidas.ReadOnly = true;
            // 
            // suma_venta
            // 
            this.suma_venta.HeaderText = "Suma de ventas";
            this.suma_venta.Name = "suma_venta";
            this.suma_venta.ReadOnly = true;
            // 
            // suma_utilidad
            // 
            this.suma_utilidad.HeaderText = "Suma de utilidad";
            this.suma_utilidad.Name = "suma_utilidad";
            this.suma_utilidad.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 119;
            this.label1.Text = "Reporte de cajeros";
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
            this.button1.Location = new System.Drawing.Point(1016, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 126;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // img_tabla_vacia
            // 
            this.img_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.img_tabla_vacia.Image = global::Proyecto_fina.Properties.Resources.nada_encontrado;
            this.img_tabla_vacia.Location = new System.Drawing.Point(460, 267);
            this.img_tabla_vacia.Name = "img_tabla_vacia";
            this.img_tabla_vacia.Size = new System.Drawing.Size(94, 97);
            this.img_tabla_vacia.TabIndex = 122;
            this.img_tabla_vacia.TabStop = false;
            this.img_tabla_vacia.Visible = false;
            // 
            // FormReporteCajero
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
            this.Controls.Add(this.dg_reporte_cajeros);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteCajero";
            this.Text = "FormReporteCajero";
            this.Load += new System.EventHandler(this.FormReporteCajero_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_cantidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_suma_utilidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reporte_cajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.NumericUpDown txt_suma_cantidades;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_cajero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_filtros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img_tabla_vacia;
        private System.Windows.Forms.Label lbl_tabla_vacia;
        private System.Windows.Forms.DataGridView dg_reporte_cajeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades_vendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn suma_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn suma_utilidad;
        public System.Windows.Forms.NumericUpDown txt_suma_utilidad;
        public System.Windows.Forms.NumericUpDown txt_suma_ventas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}