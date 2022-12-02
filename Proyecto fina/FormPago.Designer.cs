
namespace Proyecto_fina
{
    partial class FormPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pago_efectivo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pago_tarjeta = new System.Windows.Forms.NumericUpDown();
            this.txt_pago_vales = new System.Windows.Forms.NumericUpDown();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_sutotal = new System.Windows.Forms.Label();
            this.cb_impresoras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pago_efectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pago_tarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pago_vales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 74;
            this.label1.Text = "Total a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(5, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 73);
            this.label2.TabIndex = 75;
            this.label2.Text = "$";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_total.Location = new System.Drawing.Point(57, 40);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(106, 73);
            this.lbl_total.TabIndex = 76;
            this.lbl_total.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(476, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 78;
            this.label4.Text = "Pago con efectivo";
            // 
            // txt_pago_efectivo
            // 
            this.txt_pago_efectivo.DecimalPlaces = 2;
            this.txt_pago_efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pago_efectivo.Location = new System.Drawing.Point(598, 40);
            this.txt_pago_efectivo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt_pago_efectivo.Name = "txt_pago_efectivo";
            this.txt_pago_efectivo.Size = new System.Drawing.Size(190, 22);
            this.txt_pago_efectivo.TabIndex = 105;
            this.txt_pago_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(486, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Pago con tarjeta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(487, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 107;
            this.label6.Text = "Pago con vales ";
            // 
            // txt_pago_tarjeta
            // 
            this.txt_pago_tarjeta.DecimalPlaces = 2;
            this.txt_pago_tarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pago_tarjeta.Location = new System.Drawing.Point(598, 68);
            this.txt_pago_tarjeta.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt_pago_tarjeta.Name = "txt_pago_tarjeta";
            this.txt_pago_tarjeta.Size = new System.Drawing.Size(190, 22);
            this.txt_pago_tarjeta.TabIndex = 108;
            this.txt_pago_tarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_pago_vales
            // 
            this.txt_pago_vales.DecimalPlaces = 2;
            this.txt_pago_vales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pago_vales.Location = new System.Drawing.Point(598, 96);
            this.txt_pago_vales.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txt_pago_vales.Name = "txt_pago_vales";
            this.txt_pago_vales.Size = new System.Drawing.Size(190, 22);
            this.txt_pago_vales.TabIndex = 109;
            this.txt_pago_vales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_pagar
            // 
            this.btn_pagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pagar.Location = new System.Drawing.Point(479, 133);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(309, 30);
            this.btn_pagar.TabIndex = 110;
            this.btn_pagar.Text = "Imprimir ticket";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(602, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 111;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(602, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 112;
            this.label8.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(602, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 113;
            this.label9.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 114;
            this.label3.Text = "Subtotal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(69, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 115;
            this.label10.Text = "$";
            // 
            // lbl_sutotal
            // 
            this.lbl_sutotal.AutoSize = true;
            this.lbl_sutotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sutotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_sutotal.Location = new System.Drawing.Point(81, 123);
            this.lbl_sutotal.Name = "lbl_sutotal";
            this.lbl_sutotal.Size = new System.Drawing.Size(15, 16);
            this.lbl_sutotal.TabIndex = 116;
            this.lbl_sutotal.Text = "$";
            // 
            // cb_impresoras
            // 
            this.cb_impresoras.FormattingEnabled = true;
            this.cb_impresoras.Location = new System.Drawing.Point(12, 142);
            this.cb_impresoras.Name = "cb_impresoras";
            this.cb_impresoras.Size = new System.Drawing.Size(461, 21);
            this.cb_impresoras.TabIndex = 118;
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 172);
            this.Controls.Add(this.cb_impresoras);
            this.Controls.Add(this.lbl_sutotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.txt_pago_vales);
            this.Controls.Add(this.txt_pago_tarjeta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pago_efectivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_pago_efectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pago_tarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pago_vales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txt_pago_efectivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txt_pago_tarjeta;
        private System.Windows.Forms.NumericUpDown txt_pago_vales;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_sutotal;
        private System.Windows.Forms.ComboBox cb_impresoras;
    }
}