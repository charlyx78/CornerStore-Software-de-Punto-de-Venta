
namespace Proyecto_fina
{
    partial class FormNuevoProducto
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
            this.txt_cantidad_descuento_producto = new System.Windows.Forms.NumericUpDown();
            this.txt_existencia_producto = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_departamento_producto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_precio_unitario_producto = new System.Windows.Forms.NumericUpDown();
            this.txt_costo_producto = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.cb_descuento_producto = new System.Windows.Forms.ComboBox();
            this.txt_descripcion_producto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_codigo_producto = new System.Windows.Forms.Label();
            this.cb_unidad_medida_producto = new System.Windows.Forms.ComboBox();
            this.txt_punto_reorden_producto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nuevo_producto = new System.Windows.Forms.Button();
            this.rb_inhabilitado_producto = new System.Windows.Forms.RadioButton();
            this.rb_habilitado_producto = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_descuento_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_existencia_producto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_unitario_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_costo_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_punto_reorden_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cantidad_descuento_producto
            // 
            this.txt_cantidad_descuento_producto.Enabled = false;
            this.txt_cantidad_descuento_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_descuento_producto.InterceptArrowKeys = false;
            this.txt_cantidad_descuento_producto.Location = new System.Drawing.Point(205, 134);
            this.txt_cantidad_descuento_producto.Name = "txt_cantidad_descuento_producto";
            this.txt_cantidad_descuento_producto.ReadOnly = true;
            this.txt_cantidad_descuento_producto.Size = new System.Drawing.Size(170, 22);
            this.txt_cantidad_descuento_producto.TabIndex = 85;
            this.txt_cantidad_descuento_producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_existencia_producto
            // 
            this.txt_existencia_producto.DecimalPlaces = 2;
            this.txt_existencia_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia_producto.Location = new System.Drawing.Point(7, 190);
            this.txt_existencia_producto.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.txt_existencia_producto.Name = "txt_existencia_producto";
            this.txt_existencia_producto.Size = new System.Drawing.Size(170, 22);
            this.txt_existencia_producto.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(4, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 83;
            this.label7.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(4, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Precio unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(4, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(202, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Unidad de medida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Descuento";
            // 
            // cb_departamento_producto
            // 
            this.cb_departamento_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_departamento_producto.FormattingEnabled = true;
            this.cb_departamento_producto.Location = new System.Drawing.Point(7, 78);
            this.cb_departamento_producto.Name = "cb_departamento_producto";
            this.cb_departamento_producto.Size = new System.Drawing.Size(368, 24);
            this.cb_departamento_producto.TabIndex = 74;
            this.cb_departamento_producto.SelectedIndexChanged += new System.EventHandler(this.cb_departamento_producto_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nombre del producto";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.Location = new System.Drawing.Point(7, 25);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(368, 22);
            this.txt_nombre_producto.TabIndex = 71;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_precio_unitario_producto);
            this.panel1.Controls.Add(this.txt_costo_producto);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbl_id_producto);
            this.panel1.Controls.Add(this.cb_descuento_producto);
            this.panel1.Controls.Add(this.txt_descripcion_producto);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl_codigo_producto);
            this.panel1.Controls.Add(this.cb_unidad_medida_producto);
            this.panel1.Controls.Add(this.txt_punto_reorden_producto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_nuevo_producto);
            this.panel1.Controls.Add(this.rb_inhabilitado_producto);
            this.panel1.Controls.Add(this.rb_habilitado_producto);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_cantidad_descuento_producto);
            this.panel1.Controls.Add(this.txt_nombre_producto);
            this.panel1.Controls.Add(this.txt_existencia_producto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_departamento_producto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 617);
            this.panel1.TabIndex = 86;
            // 
            // txt_precio_unitario_producto
            // 
            this.txt_precio_unitario_producto.DecimalPlaces = 2;
            this.txt_precio_unitario_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_unitario_producto.Location = new System.Drawing.Point(7, 352);
            this.txt_precio_unitario_producto.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.txt_precio_unitario_producto.Name = "txt_precio_unitario_producto";
            this.txt_precio_unitario_producto.Size = new System.Drawing.Size(368, 22);
            this.txt_precio_unitario_producto.TabIndex = 105;
            // 
            // txt_costo_producto
            // 
            this.txt_costo_producto.DecimalPlaces = 2;
            this.txt_costo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo_producto.Location = new System.Drawing.Point(7, 298);
            this.txt_costo_producto.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.txt_costo_producto.Name = "txt_costo_producto";
            this.txt_costo_producto.Size = new System.Drawing.Size(368, 22);
            this.txt_costo_producto.TabIndex = 104;
            this.txt_costo_producto.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(258, 549);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "Actualizando ID #";
            this.label11.Visible = false;
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_id_producto.Location = new System.Drawing.Point(348, 549);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_producto.TabIndex = 102;
            this.lbl_id_producto.Visible = false;
            // 
            // cb_descuento_producto
            // 
            this.cb_descuento_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_descuento_producto.FormattingEnabled = true;
            this.cb_descuento_producto.Location = new System.Drawing.Point(7, 134);
            this.cb_descuento_producto.Name = "cb_descuento_producto";
            this.cb_descuento_producto.Size = new System.Drawing.Size(170, 24);
            this.cb_descuento_producto.TabIndex = 97;
            // 
            // txt_descripcion_producto
            // 
            this.txt_descripcion_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion_producto.Location = new System.Drawing.Point(7, 406);
            this.txt_descripcion_producto.Multiline = true;
            this.txt_descripcion_producto.Name = "txt_descripcion_producto";
            this.txt_descripcion_producto.Size = new System.Drawing.Size(368, 90);
            this.txt_descripcion_producto.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(4, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 95;
            this.label10.Text = "Descripción";
            // 
            // lbl_codigo_producto
            // 
            this.lbl_codigo_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_codigo_producto.AutoSize = true;
            this.lbl_codigo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo_producto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_codigo_producto.Location = new System.Drawing.Point(371, 6);
            this.lbl_codigo_producto.Name = "lbl_codigo_producto";
            this.lbl_codigo_producto.Size = new System.Drawing.Size(0, 16);
            this.lbl_codigo_producto.TabIndex = 94;
            // 
            // cb_unidad_medida_producto
            // 
            this.cb_unidad_medida_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_unidad_medida_producto.FormattingEnabled = true;
            this.cb_unidad_medida_producto.Items.AddRange(new object[] {
            "KG",
            "G",
            "MG",
            "L",
            "ML",
            "CM",
            "M",
            "KM",
            "PZAS"});
            this.cb_unidad_medida_producto.Location = new System.Drawing.Point(205, 190);
            this.cb_unidad_medida_producto.Name = "cb_unidad_medida_producto";
            this.cb_unidad_medida_producto.Size = new System.Drawing.Size(170, 24);
            this.cb_unidad_medida_producto.TabIndex = 93;
            // 
            // txt_punto_reorden_producto
            // 
            this.txt_punto_reorden_producto.DecimalPlaces = 2;
            this.txt_punto_reorden_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_punto_reorden_producto.Location = new System.Drawing.Point(7, 244);
            this.txt_punto_reorden_producto.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.txt_punto_reorden_producto.Name = "txt_punto_reorden_producto";
            this.txt_punto_reorden_producto.Size = new System.Drawing.Size(368, 22);
            this.txt_punto_reorden_producto.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(4, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 91;
            this.label9.Text = "Punto de reorden";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(159, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 90;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_nuevo_producto
            // 
            this.btn_nuevo_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_nuevo_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nuevo_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevo_producto.Location = new System.Drawing.Point(275, 575);
            this.btn_nuevo_producto.Name = "btn_nuevo_producto";
            this.btn_nuevo_producto.Size = new System.Drawing.Size(100, 30);
            this.btn_nuevo_producto.TabIndex = 89;
            this.btn_nuevo_producto.Text = "Guardar";
            this.btn_nuevo_producto.UseVisualStyleBackColor = false;
            this.btn_nuevo_producto.Click += new System.EventHandler(this.btn_nuevo_producto_Click);
            // 
            // rb_inhabilitado_producto
            // 
            this.rb_inhabilitado_producto.AutoSize = true;
            this.rb_inhabilitado_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inhabilitado_producto.Location = new System.Drawing.Point(59, 528);
            this.rb_inhabilitado_producto.Name = "rb_inhabilitado_producto";
            this.rb_inhabilitado_producto.Size = new System.Drawing.Size(44, 20);
            this.rb_inhabilitado_producto.TabIndex = 88;
            this.rb_inhabilitado_producto.TabStop = true;
            this.rb_inhabilitado_producto.Text = "No";
            this.rb_inhabilitado_producto.UseVisualStyleBackColor = true;
            // 
            // rb_habilitado_producto
            // 
            this.rb_habilitado_producto.AutoSize = true;
            this.rb_habilitado_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_habilitado_producto.Location = new System.Drawing.Point(7, 528);
            this.rb_habilitado_producto.Name = "rb_habilitado_producto";
            this.rb_habilitado_producto.Size = new System.Drawing.Size(38, 20);
            this.rb_habilitado_producto.TabIndex = 87;
            this.rb_habilitado_producto.TabStop = true;
            this.rb_habilitado_producto.Text = "Sí";
            this.rb_habilitado_producto.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(4, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 16);
            this.label8.TabIndex = 86;
            this.label8.Text = "Habilitado para venta";
            // 
            // FormNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 642);
            this.Controls.Add(this.panel1);
            this.Name = "FormNuevoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNuevoProducto_FormClosing);
            this.Load += new System.EventHandler(this.FormNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_descuento_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_existencia_producto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_precio_unitario_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_costo_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_punto_reorden_producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nuevo_producto;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown txt_cantidad_descuento_producto;
        public System.Windows.Forms.NumericUpDown txt_existencia_producto;
        public System.Windows.Forms.ComboBox cb_departamento_producto;
        public System.Windows.Forms.TextBox txt_nombre_producto;
        public System.Windows.Forms.RadioButton rb_inhabilitado_producto;
        public System.Windows.Forms.RadioButton rb_habilitado_producto;
        public System.Windows.Forms.NumericUpDown txt_punto_reorden_producto;
        public System.Windows.Forms.ComboBox cb_unidad_medida_producto;
        public System.Windows.Forms.Label lbl_codigo_producto;
        public System.Windows.Forms.TextBox txt_descripcion_producto;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cb_descuento_producto;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbl_id_producto;
        public System.Windows.Forms.NumericUpDown txt_precio_unitario_producto;
        public System.Windows.Forms.NumericUpDown txt_costo_producto;
    }
}