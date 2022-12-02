
namespace Proyecto_fina
{
    partial class FormBuscarProducto
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.lb_productos = new System.Windows.Forms.ListBox();
            this.btn_agregar_producto_carrito = new System.Windows.Forms.Button();
            this.txt_cantidad_nombre_producto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_nombre_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Búsqueda de producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 111;
            this.label1.Text = "Nombre de producto";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.Location = new System.Drawing.Point(151, 41);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(186, 22);
            this.txt_nombre_producto.TabIndex = 112;
            this.txt_nombre_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_producto_KeyPress);
            // 
            // lb_productos
            // 
            this.lb_productos.FormattingEnabled = true;
            this.lb_productos.Location = new System.Drawing.Point(16, 73);
            this.lb_productos.Name = "lb_productos";
            this.lb_productos.Size = new System.Drawing.Size(515, 316);
            this.lb_productos.TabIndex = 113;
            this.lb_productos.SelectedIndexChanged += new System.EventHandler(this.lb_productos_SelectedIndexChanged);
            // 
            // btn_agregar_producto_carrito
            // 
            this.btn_agregar_producto_carrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar_producto_carrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_agregar_producto_carrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_producto_carrito.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_agregar_producto_carrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_producto_carrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_producto_carrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_agregar_producto_carrito.Location = new System.Drawing.Point(415, 408);
            this.btn_agregar_producto_carrito.Name = "btn_agregar_producto_carrito";
            this.btn_agregar_producto_carrito.Size = new System.Drawing.Size(116, 30);
            this.btn_agregar_producto_carrito.TabIndex = 114;
            this.btn_agregar_producto_carrito.Text = "Agregar producto";
            this.btn_agregar_producto_carrito.UseVisualStyleBackColor = false;
            this.btn_agregar_producto_carrito.Click += new System.EventHandler(this.btn_agregar_producto_carrito_Click);
            // 
            // txt_cantidad_nombre_producto
            // 
            this.txt_cantidad_nombre_producto.DecimalPlaces = 2;
            this.txt_cantidad_nombre_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_nombre_producto.Location = new System.Drawing.Point(411, 41);
            this.txt_cantidad_nombre_producto.Name = "txt_cantidad_nombre_producto";
            this.txt_cantidad_nombre_producto.Size = new System.Drawing.Size(120, 22);
            this.txt_cantidad_nombre_producto.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(343, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "Cantidad";
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cantidad_nombre_producto);
            this.Controls.Add(this.btn_agregar_producto_carrito);
            this.Controls.Add(this.lb_productos);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FormBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_nombre_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.ListBox lb_productos;
        private System.Windows.Forms.Button btn_agregar_producto_carrito;
        private System.Windows.Forms.NumericUpDown txt_cantidad_nombre_producto;
        private System.Windows.Forms.Label label2;
    }
}