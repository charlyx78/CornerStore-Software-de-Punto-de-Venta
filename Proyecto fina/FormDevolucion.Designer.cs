
namespace Proyecto_fina
{
    partial class FormDevolucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_devolucion = new System.Windows.Forms.DataGridView();
            this.txt_cantidad_devolucion = new System.Windows.Forms.NumericUpDown();
            this.cb_motivo_devolucion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar_ticket = new System.Windows.Forms.Button();
            this.txt_codigo_ticket = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_producto_devolucion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_devolucion = new System.Windows.Forms.Button();
            this.dg_carrito_devolucion = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo_devolucion_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_subtotal_devolucion = new System.Windows.Forms.NumericUpDown();
            this.txt_total_devolucion = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_devolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_devolucion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo_ticket)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_carrito_devolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subtotal_devolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_devolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_devolucion
            // 
            this.dg_devolucion.AllowUserToAddRows = false;
            this.dg_devolucion.AllowUserToDeleteRows = false;
            this.dg_devolucion.AllowUserToResizeColumns = false;
            this.dg_devolucion.AllowUserToResizeRows = false;
            this.dg_devolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dg_devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_devolucion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_devolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_devolucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_devolucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_devolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_devolucion.EnableHeadersVisualStyles = false;
            this.dg_devolucion.GridColor = System.Drawing.SystemColors.Control;
            this.dg_devolucion.Location = new System.Drawing.Point(16, 176);
            this.dg_devolucion.Name = "dg_devolucion";
            this.dg_devolucion.ReadOnly = true;
            this.dg_devolucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_devolucion.RowHeadersVisible = false;
            this.dg_devolucion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_devolucion.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_devolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_devolucion.Size = new System.Drawing.Size(251, 221);
            this.dg_devolucion.TabIndex = 116;
            this.dg_devolucion.SelectionChanged += new System.EventHandler(this.dg_devolucion_SelectionChanged);
            // 
            // txt_cantidad_devolucion
            // 
            this.txt_cantidad_devolucion.DecimalPlaces = 2;
            this.txt_cantidad_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_devolucion.Location = new System.Drawing.Point(8, 80);
            this.txt_cantidad_devolucion.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.txt_cantidad_devolucion.Name = "txt_cantidad_devolucion";
            this.txt_cantidad_devolucion.Size = new System.Drawing.Size(236, 22);
            this.txt_cantidad_devolucion.TabIndex = 118;
            // 
            // cb_motivo_devolucion
            // 
            this.cb_motivo_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_motivo_devolucion.FormattingEnabled = true;
            this.cb_motivo_devolucion.Items.AddRange(new object[] {
            "Deficiencia de producto",
            "Cambio de opinión del cliente",
            "Expectativas insatisfechas",
            "Modelo incorrecto"});
            this.cb_motivo_devolucion.Location = new System.Drawing.Point(8, 129);
            this.cb_motivo_devolucion.Name = "cb_motivo_devolucion";
            this.cb_motivo_devolucion.Size = new System.Drawing.Size(236, 24);
            this.cb_motivo_devolucion.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 20);
            this.label8.TabIndex = 122;
            this.label8.Text = "Devolución de productos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_buscar_ticket);
            this.panel1.Controls.Add(this.txt_codigo_ticket);
            this.panel1.Location = new System.Drawing.Point(16, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 113);
            this.panel1.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Código de ticket";
            // 
            // btn_buscar_ticket
            // 
            this.btn_buscar_ticket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar_ticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_buscar_ticket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_ticket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_buscar_ticket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_ticket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_buscar_ticket.Image = global::Proyecto_fina.Properties.Resources.icons8_ver_archivo_30_1_;
            this.btn_buscar_ticket.Location = new System.Drawing.Point(8, 60);
            this.btn_buscar_ticket.Name = "btn_buscar_ticket";
            this.btn_buscar_ticket.Size = new System.Drawing.Size(236, 42);
            this.btn_buscar_ticket.TabIndex = 102;
            this.btn_buscar_ticket.Text = "Buscar ticket";
            this.btn_buscar_ticket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar_ticket.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_buscar_ticket.UseVisualStyleBackColor = false;
            this.btn_buscar_ticket.Click += new System.EventHandler(this.btn_buscar_ticket_Click);
            // 
            // txt_codigo_ticket
            // 
            this.txt_codigo_ticket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_codigo_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_ticket.Location = new System.Drawing.Point(8, 27);
            this.txt_codigo_ticket.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.txt_codigo_ticket.Name = "txt_codigo_ticket";
            this.txt_codigo_ticket.Size = new System.Drawing.Size(236, 22);
            this.txt_codigo_ticket.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.btn_agregar_producto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_producto_devolucion);
            this.panel2.Controls.Add(this.cb_motivo_devolucion);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_cantidad_devolucion);
            this.panel2.Location = new System.Drawing.Point(16, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 221);
            this.panel2.TabIndex = 124;
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_agregar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_agregar_producto.Image = global::Proyecto_fina.Properties.Resources.icons8_más_24;
            this.btn_agregar_producto.Location = new System.Drawing.Point(8, 164);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(236, 42);
            this.btn_agregar_producto.TabIndex = 126;
            this.btn_agregar_producto.Text = "Agregar producto";
            this.btn_agregar_producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar_producto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_agregar_producto.UseVisualStyleBackColor = false;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(8, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 16);
            this.label9.TabIndex = 126;
            this.label9.Text = "Motivo de devolución";
            // 
            // txt_producto_devolucion
            // 
            this.txt_producto_devolucion.Enabled = false;
            this.txt_producto_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto_devolucion.Location = new System.Drawing.Point(8, 31);
            this.txt_producto_devolucion.Name = "txt_producto_devolucion";
            this.txt_producto_devolucion.ReadOnly = true;
            this.txt_producto_devolucion.Size = new System.Drawing.Size(236, 22);
            this.txt_producto_devolucion.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 105;
            this.label7.Text = "Producto a devolver";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 73;
            this.label6.Text = "Cantidad a devolver";
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_devolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_devolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devolucion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_devolucion.Image = global::Proyecto_fina.Properties.Resources.icons8_devolución_de_compra_30;
            this.btn_devolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_devolucion.Location = new System.Drawing.Point(653, 587);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(399, 42);
            this.btn_devolucion.TabIndex = 102;
            this.btn_devolucion.Text = "Devolver productos";
            this.btn_devolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_devolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_devolucion.UseVisualStyleBackColor = false;
            this.btn_devolucion.Click += new System.EventHandler(this.btn_devolucion_Click_1);
            // 
            // dg_carrito_devolucion
            // 
            this.dg_carrito_devolucion.AllowUserToAddRows = false;
            this.dg_carrito_devolucion.AllowUserToDeleteRows = false;
            this.dg_carrito_devolucion.AllowUserToResizeColumns = false;
            this.dg_carrito_devolucion.AllowUserToResizeRows = false;
            this.dg_carrito_devolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_carrito_devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_carrito_devolucion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_carrito_devolucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_carrito_devolucion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_carrito_devolucion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_carrito_devolucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_carrito_devolucion.ColumnHeadersHeight = 40;
            this.dg_carrito_devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_carrito_devolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.cantidad_producto,
            this.precio_producto,
            this.descuento_producto,
            this.subtotal_producto,
            this.total_producto,
            this.motivo_devolucion_producto});
            this.dg_carrito_devolucion.EnableHeadersVisualStyles = false;
            this.dg_carrito_devolucion.GridColor = System.Drawing.SystemColors.Control;
            this.dg_carrito_devolucion.Location = new System.Drawing.Point(283, 52);
            this.dg_carrito_devolucion.Name = "dg_carrito_devolucion";
            this.dg_carrito_devolucion.ReadOnly = true;
            this.dg_carrito_devolucion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_carrito_devolucion.RowHeadersVisible = false;
            this.dg_carrito_devolucion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_carrito_devolucion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_carrito_devolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_carrito_devolucion.Size = new System.Drawing.Size(769, 529);
            this.dg_carrito_devolucion.TabIndex = 125;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "ID";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // cantidad_producto
            // 
            this.cantidad_producto.HeaderText = "Cantidad";
            this.cantidad_producto.Name = "cantidad_producto";
            this.cantidad_producto.ReadOnly = true;
            // 
            // precio_producto
            // 
            this.precio_producto.HeaderText = "Precio";
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.ReadOnly = true;
            // 
            // descuento_producto
            // 
            this.descuento_producto.HeaderText = "Descuento";
            this.descuento_producto.Name = "descuento_producto";
            this.descuento_producto.ReadOnly = true;
            // 
            // subtotal_producto
            // 
            this.subtotal_producto.HeaderText = "Subtotal";
            this.subtotal_producto.Name = "subtotal_producto";
            this.subtotal_producto.ReadOnly = true;
            // 
            // total_producto
            // 
            this.total_producto.HeaderText = "Total";
            this.total_producto.Name = "total_producto";
            this.total_producto.ReadOnly = true;
            // 
            // motivo_devolucion_producto
            // 
            this.motivo_devolucion_producto.HeaderText = "Motivo de devolución";
            this.motivo_devolucion_producto.Name = "motivo_devolucion_producto";
            this.motivo_devolucion_producto.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(280, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(473, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 128;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(346, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "$";
            // 
            // txt_subtotal_devolucion
            // 
            this.txt_subtotal_devolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_subtotal_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal_devolucion.Location = new System.Drawing.Point(343, 595);
            this.txt_subtotal_devolucion.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.txt_subtotal_devolucion.Name = "txt_subtotal_devolucion";
            this.txt_subtotal_devolucion.ReadOnly = true;
            this.txt_subtotal_devolucion.Size = new System.Drawing.Size(124, 22);
            this.txt_subtotal_devolucion.TabIndex = 105;
            this.txt_subtotal_devolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_total_devolucion
            // 
            this.txt_total_devolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_total_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_devolucion.Location = new System.Drawing.Point(518, 595);
            this.txt_total_devolucion.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.txt_total_devolucion.Name = "txt_total_devolucion";
            this.txt_total_devolucion.ReadOnly = true;
            this.txt_total_devolucion.Size = new System.Drawing.Size(124, 22);
            this.txt_total_devolucion.TabIndex = 131;
            this.txt_total_devolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(521, 598);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 132;
            this.label10.Text = "$";
            // 
            // FormDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_total_devolucion);
            this.Controls.Add(this.txt_subtotal_devolucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_carrito_devolucion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_devolucion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dg_devolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDevolucion";
            this.Text = "FormDevolucion";
            this.Load += new System.EventHandler(this.FormDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_devolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_devolucion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo_ticket)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_carrito_devolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subtotal_devolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_devolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_devolucion;
        public System.Windows.Forms.NumericUpDown txt_cantidad_devolucion;
        private System.Windows.Forms.ComboBox cb_motivo_devolucion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscar_ticket;
        public System.Windows.Forms.NumericUpDown txt_codigo_ticket;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_devolucion;
        private System.Windows.Forms.TextBox txt_producto_devolucion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.DataGridView dg_carrito_devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo_devolucion_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown txt_subtotal_devolucion;
        public System.Windows.Forms.NumericUpDown txt_total_devolucion;
        private System.Windows.Forms.Label label10;
    }
}