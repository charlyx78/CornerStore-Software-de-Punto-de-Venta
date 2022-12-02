
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo_ticket = new System.Windows.Forms.NumericUpDown();
            this.btn_buscar_producto = new System.Windows.Forms.Button();
            this.dg_devolucion = new System.Windows.Forms.DataGridView();
            this.txt_cantidad_devolucion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_motivo_devolucion = new System.Windows.Forms.ComboBox();
            this.btn_devolucion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo_ticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_devolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_devolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Devoluciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 111;
            this.label1.Text = "ID de ticket";
            // 
            // txt_codigo_ticket
            // 
            this.txt_codigo_ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_ticket.Location = new System.Drawing.Point(92, 37);
            this.txt_codigo_ticket.Name = "txt_codigo_ticket";
            this.txt_codigo_ticket.Size = new System.Drawing.Size(826, 22);
            this.txt_codigo_ticket.TabIndex = 112;
            // 
            // btn_buscar_producto
            // 
            this.btn_buscar_producto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_buscar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_buscar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_buscar_producto.Location = new System.Drawing.Point(936, 32);
            this.btn_buscar_producto.Name = "btn_buscar_producto";
            this.btn_buscar_producto.Size = new System.Drawing.Size(116, 30);
            this.btn_buscar_producto.TabIndex = 115;
            this.btn_buscar_producto.Text = "Buscar";
            this.btn_buscar_producto.UseVisualStyleBackColor = false;
            this.btn_buscar_producto.Click += new System.EventHandler(this.btn_buscar_producto_Click);
            // 
            // dg_devolucion
            // 
            this.dg_devolucion.AllowUserToAddRows = false;
            this.dg_devolucion.AllowUserToDeleteRows = false;
            this.dg_devolucion.AllowUserToResizeColumns = false;
            this.dg_devolucion.AllowUserToResizeRows = false;
            this.dg_devolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_devolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_devolucion.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.dg_devolucion.Location = new System.Drawing.Point(16, 78);
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
            this.dg_devolucion.Size = new System.Drawing.Size(1036, 461);
            this.dg_devolucion.TabIndex = 116;
            // 
            // txt_cantidad_devolucion
            // 
            this.txt_cantidad_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_devolucion.Location = new System.Drawing.Point(148, 566);
            this.txt_cantidad_devolucion.Name = "txt_cantidad_devolucion";
            this.txt_cantidad_devolucion.Size = new System.Drawing.Size(140, 22);
            this.txt_cantidad_devolucion.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(13, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 117;
            this.label2.Text = "Cantidad a devolver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(294, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 119;
            this.label3.Text = "Motivo de devolución";
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
            this.cb_motivo_devolucion.Location = new System.Drawing.Point(436, 564);
            this.cb_motivo_devolucion.Name = "cb_motivo_devolucion";
            this.cb_motivo_devolucion.Size = new System.Drawing.Size(377, 24);
            this.cb_motivo_devolucion.TabIndex = 120;
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_devolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_devolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devolucion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devolucion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_devolucion.Location = new System.Drawing.Point(834, 561);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(218, 30);
            this.btn_devolucion.TabIndex = 121;
            this.btn_devolucion.Text = "Generar nota de crédito";
            this.btn_devolucion.UseVisualStyleBackColor = false;
            this.btn_devolucion.Click += new System.EventHandler(this.btn_devolucion_Click);
            // 
            // FormDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.btn_devolucion);
            this.Controls.Add(this.cb_motivo_devolucion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cantidad_devolucion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_devolucion);
            this.Controls.Add(this.btn_buscar_producto);
            this.Controls.Add(this.txt_codigo_ticket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDevolucion";
            this.Text = "FormDevolucion";
            this.Load += new System.EventHandler(this.FormDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo_ticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_devolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_devolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown txt_codigo_ticket;
        private System.Windows.Forms.Button btn_buscar_producto;
        private System.Windows.Forms.DataGridView dg_devolucion;
        public System.Windows.Forms.NumericUpDown txt_cantidad_devolucion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_motivo_devolucion;
        private System.Windows.Forms.Button btn_devolucion;
    }
}