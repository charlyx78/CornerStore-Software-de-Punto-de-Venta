
namespace Proyecto_fina
{
    partial class FormNuevoDepartamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_id_departamento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_nuevo_producto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre_departamento = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_id_departamento);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_nuevo_producto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_nombre_departamento);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 489);
            this.panel1.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(268, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Actualizando ID #";
            this.label2.Visible = false;
            // 
            // lbl_id_departamento
            // 
            this.lbl_id_departamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_id_departamento.AutoSize = true;
            this.lbl_id_departamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_id_departamento.Location = new System.Drawing.Point(358, 430);
            this.lbl_id_departamento.Name = "lbl_id_departamento";
            this.lbl_id_departamento.Size = new System.Drawing.Size(0, 13);
            this.lbl_id_departamento.TabIndex = 95;
            this.lbl_id_departamento.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(154, 451);
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
            this.btn_nuevo_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_producto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nuevo_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_producto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevo_producto.Location = new System.Drawing.Point(275, 451);
            this.btn_nuevo_producto.Name = "btn_nuevo_producto";
            this.btn_nuevo_producto.Size = new System.Drawing.Size(100, 30);
            this.btn_nuevo_producto.TabIndex = 89;
            this.btn_nuevo_producto.Text = "Guardar";
            this.btn_nuevo_producto.UseVisualStyleBackColor = false;
            this.btn_nuevo_producto.Click += new System.EventHandler(this.btn_nuevo_producto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nombre del departamento";
            // 
            // txt_nombre_departamento
            // 
            this.txt_nombre_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_departamento.Location = new System.Drawing.Point(7, 25);
            this.txt_nombre_departamento.Name = "txt_nombre_departamento";
            this.txt_nombre_departamento.Size = new System.Drawing.Size(368, 22);
            this.txt_nombre_departamento.TabIndex = 71;
            // 
            // FormNuevoDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 514);
            this.Controls.Add(this.panel1);
            this.Name = "FormNuevoDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo departamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNuevoDepartamento_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_nuevo_producto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_nombre_departamento;
        public System.Windows.Forms.Label lbl_id_departamento;
        public System.Windows.Forms.Label label2;
    }
}