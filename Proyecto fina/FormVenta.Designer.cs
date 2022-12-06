
namespace Proyecto_fina
{
    partial class FormVenta
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
            this.txt_cantidad_producto_carrito = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo_producto_carrito = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_carrito = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.txt_subtotal_carrito = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buscar_producto = new System.Windows.Forms.Button();
            this.dg_carrito = new System.Windows.Forms.DataGridView();
            this.lista_carrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_carrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento_carrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal_carrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_carrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar_producto_carrito = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_agregar_producto_carrito = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_producto_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo_producto_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subtotal_carrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_carrito)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Código de producto";
            // 
            // txt_cantidad_producto_carrito
            // 
            this.txt_cantidad_producto_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad_producto_carrito.DecimalPlaces = 2;
            this.txt_cantidad_producto_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_producto_carrito.Location = new System.Drawing.Point(8, 82);
            this.txt_cantidad_producto_carrito.Name = "txt_cantidad_producto_carrito";
            this.txt_cantidad_producto_carrito.Size = new System.Drawing.Size(224, 22);
            this.txt_cantidad_producto_carrito.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 101;
            this.label2.Text = "Cantidad";
            // 
            // txt_codigo_producto_carrito
            // 
            this.txt_codigo_producto_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_codigo_producto_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_producto_carrito.Location = new System.Drawing.Point(8, 28);
            this.txt_codigo_producto_carrito.Name = "txt_codigo_producto_carrito";
            this.txt_codigo_producto_carrito.Size = new System.Drawing.Size(224, 22);
            this.txt_codigo_producto_carrito.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Total";
            // 
            // txt_total_carrito
            // 
            this.txt_total_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total_carrito.DecimalPlaces = 2;
            this.txt_total_carrito.Enabled = false;
            this.txt_total_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_carrito.Location = new System.Drawing.Point(66, 44);
            this.txt_total_carrito.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_total_carrito.Name = "txt_total_carrito";
            this.txt_total_carrito.ReadOnly = true;
            this.txt_total_carrito.Size = new System.Drawing.Size(166, 22);
            this.txt_total_carrito.TabIndex = 107;
            this.txt_total_carrito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(70, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 108;
            this.label4.Text = "$";
            // 
            // btn_cerrar_productos
            // 
            this.btn_cerrar_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_cerrar_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_productos.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_productos.Image = global::Proyecto_fina.Properties.Resources.cerrar;
            this.btn_cerrar_productos.Location = new System.Drawing.Point(1016, 7);
            this.btn_cerrar_productos.Name = "btn_cerrar_productos";
            this.btn_cerrar_productos.Size = new System.Drawing.Size(36, 36);
            this.btn_cerrar_productos.TabIndex = 110;
            this.btn_cerrar_productos.UseVisualStyleBackColor = false;
            this.btn_cerrar_productos.Click += new System.EventHandler(this.btn_cerrar_productos_Click);
            // 
            // txt_subtotal_carrito
            // 
            this.txt_subtotal_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_subtotal_carrito.DecimalPlaces = 2;
            this.txt_subtotal_carrito.Enabled = false;
            this.txt_subtotal_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal_carrito.Location = new System.Drawing.Point(66, 11);
            this.txt_subtotal_carrito.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txt_subtotal_carrito.Name = "txt_subtotal_carrito";
            this.txt_subtotal_carrito.ReadOnly = true;
            this.txt_subtotal_carrito.Size = new System.Drawing.Size(166, 22);
            this.txt_subtotal_carrito.TabIndex = 111;
            this.txt_subtotal_carrito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 112;
            this.label6.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(84, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 113;
            this.label7.Text = "$";
            // 
            // btn_buscar_producto
            // 
            this.btn_buscar_producto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_buscar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_buscar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_buscar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_buscar_producto.Location = new System.Drawing.Point(8, 225);
            this.btn_buscar_producto.Name = "btn_buscar_producto";
            this.btn_buscar_producto.Size = new System.Drawing.Size(105, 49);
            this.btn_buscar_producto.TabIndex = 114;
            this.btn_buscar_producto.Text = "Buscar producto por nombre";
            this.btn_buscar_producto.UseVisualStyleBackColor = false;
            this.btn_buscar_producto.Click += new System.EventHandler(this.btn_buscar_producto_Click);
            // 
            // dg_carrito
            // 
            this.dg_carrito.AllowUserToAddRows = false;
            this.dg_carrito.AllowUserToDeleteRows = false;
            this.dg_carrito.AllowUserToResizeColumns = false;
            this.dg_carrito.AllowUserToResizeRows = false;
            this.dg_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_carrito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_carrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_carrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_carrito.ColumnHeadersHeight = 50;
            this.dg_carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lista_carrito,
            this.id_producto,
            this.nombre_producto,
            this.cantidad_carrito,
            this.UM,
            this.precio_producto,
            this.descuento_producto,
            this.descuento_carrito,
            this.subtotal_carrito,
            this.total_carrito});
            this.dg_carrito.EnableHeadersVisualStyles = false;
            this.dg_carrito.GridColor = System.Drawing.SystemColors.Control;
            this.dg_carrito.Location = new System.Drawing.Point(271, 52);
            this.dg_carrito.Name = "dg_carrito";
            this.dg_carrito.ReadOnly = true;
            this.dg_carrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_carrito.RowHeadersVisible = false;
            this.dg_carrito.RowHeadersWidth = 80;
            this.dg_carrito.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_carrito.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_carrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_carrito.Size = new System.Drawing.Size(781, 577);
            this.dg_carrito.TabIndex = 115;
            // 
            // lista_carrito
            // 
            this.lista_carrito.HeaderText = "Lista";
            this.lista_carrito.Name = "lista_carrito";
            this.lista_carrito.ReadOnly = true;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Código de producto";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.HeaderText = "Producto";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // cantidad_carrito
            // 
            this.cantidad_carrito.HeaderText = "Cantidad";
            this.cantidad_carrito.Name = "cantidad_carrito";
            this.cantidad_carrito.ReadOnly = true;
            // 
            // UM
            // 
            this.UM.HeaderText = "UM";
            this.UM.Name = "UM";
            this.UM.ReadOnly = true;
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
            // descuento_carrito
            // 
            this.descuento_carrito.HeaderText = "Descuento sobre el total";
            this.descuento_carrito.Name = "descuento_carrito";
            this.descuento_carrito.ReadOnly = true;
            // 
            // subtotal_carrito
            // 
            this.subtotal_carrito.HeaderText = "Subtotal";
            this.subtotal_carrito.Name = "subtotal_carrito";
            this.subtotal_carrito.ReadOnly = true;
            // 
            // total_carrito
            // 
            this.total_carrito.HeaderText = "Total";
            this.total_carrito.Name = "total_carrito";
            this.total_carrito.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 116;
            this.label8.Text = "Venta de productos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.btn_eliminar_producto_carrito);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_agregar_producto_carrito);
            this.panel1.Controls.Add(this.txt_codigo_producto_carrito);
            this.panel1.Controls.Add(this.btn_buscar_producto);
            this.panel1.Controls.Add(this.txt_cantidad_producto_carrito);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 285);
            this.panel1.TabIndex = 117;
            // 
            // btn_eliminar_producto_carrito
            // 
            this.btn_eliminar_producto_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_producto_carrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_eliminar_producto_carrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_producto_carrito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar_producto_carrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar_producto_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_producto_carrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar_producto_carrito.Image = global::Proyecto_fina.Properties.Resources.icons8_residuos_24;
            this.btn_eliminar_producto_carrito.Location = new System.Drawing.Point(8, 173);
            this.btn_eliminar_producto_carrito.Name = "btn_eliminar_producto_carrito";
            this.btn_eliminar_producto_carrito.Size = new System.Drawing.Size(224, 42);
            this.btn_eliminar_producto_carrito.TabIndex = 116;
            this.btn_eliminar_producto_carrito.Text = "Eliminar producto";
            this.btn_eliminar_producto_carrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_eliminar_producto_carrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_eliminar_producto_carrito.UseVisualStyleBackColor = false;
            this.btn_eliminar_producto_carrito.Click += new System.EventHandler(this.btn_eliminar_producto_carrito_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(127, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 115;
            this.button1.Text = "Ver precio de producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_agregar_producto_carrito
            // 
            this.btn_agregar_producto_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar_producto_carrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_agregar_producto_carrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_producto_carrito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar_producto_carrito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar_producto_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto_carrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_agregar_producto_carrito.Image = global::Proyecto_fina.Properties.Resources.icons8_más_24;
            this.btn_agregar_producto_carrito.Location = new System.Drawing.Point(8, 120);
            this.btn_agregar_producto_carrito.Name = "btn_agregar_producto_carrito";
            this.btn_agregar_producto_carrito.Size = new System.Drawing.Size(224, 42);
            this.btn_agregar_producto_carrito.TabIndex = 102;
            this.btn_agregar_producto_carrito.Text = "Agregar producto";
            this.btn_agregar_producto_carrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar_producto_carrito.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_agregar_producto_carrito.UseVisualStyleBackColor = false;
            this.btn_agregar_producto_carrito.Click += new System.EventHandler(this.btn_nuevo_producto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_subtotal_carrito);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_total_carrito);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_pagar);
            this.panel2.Location = new System.Drawing.Point(16, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 129);
            this.panel2.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(70, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 118;
            this.label9.Text = "$";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(70, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 117;
            this.label5.Text = "$";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pagar.Image = global::Proyecto_fina.Properties.Resources.icons8_dinero_30;
            this.btn_pagar.Location = new System.Drawing.Point(8, 77);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(224, 42);
            this.btn_pagar.TabIndex = 105;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dg_carrito);
            this.Controls.Add(this.btn_cerrar_productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_producto_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo_producto_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_total_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_subtotal_carrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_carrito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar_producto_carrito;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_buscar_producto;
        public System.Windows.Forms.NumericUpDown txt_total_carrito;
        public System.Windows.Forms.NumericUpDown txt_subtotal_carrito;
        public System.Windows.Forms.NumericUpDown txt_codigo_producto_carrito;
        public System.Windows.Forms.NumericUpDown txt_cantidad_producto_carrito;
        public System.Windows.Forms.DataGridView dg_carrito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn lista_carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn UM;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento_carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal_carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_carrito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_eliminar_producto_carrito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
    }
}