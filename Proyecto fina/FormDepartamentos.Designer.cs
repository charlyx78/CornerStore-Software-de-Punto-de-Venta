
namespace Proyecto_fina
{
    partial class FormDepartamentos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tiendaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_eliminar_departamento = new System.Windows.Forms.Button();
            this.dg_departamentos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_editar_departamento = new System.Windows.Forms.Button();
            this.btn_nuevo_departamento = new System.Windows.Forms.Button();
            this.btn_cerrar_productos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_usuario_cambio = new System.Windows.Forms.TextBox();
            this.txt_fecha_cambio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_departamentos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_eliminar_departamento
            // 
            this.btn_eliminar_departamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar_departamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_eliminar_departamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar_departamento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eliminar_departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_departamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_eliminar_departamento.Location = new System.Drawing.Point(932, 170);
            this.btn_eliminar_departamento.Name = "btn_eliminar_departamento";
            this.btn_eliminar_departamento.Size = new System.Drawing.Size(120, 30);
            this.btn_eliminar_departamento.TabIndex = 39;
            this.btn_eliminar_departamento.Text = "Eliminar";
            this.btn_eliminar_departamento.UseVisualStyleBackColor = false;
            this.btn_eliminar_departamento.Click += new System.EventHandler(this.btn_eliminar_departamento_Click);
            // 
            // dg_departamentos
            // 
            this.dg_departamentos.AllowUserToAddRows = false;
            this.dg_departamentos.AllowUserToDeleteRows = false;
            this.dg_departamentos.AllowUserToResizeColumns = false;
            this.dg_departamentos.AllowUserToResizeRows = false;
            this.dg_departamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_departamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_departamentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.dg_departamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_departamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_departamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_departamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_departamentos.EnableHeadersVisualStyles = false;
            this.dg_departamentos.GridColor = System.Drawing.SystemColors.Control;
            this.dg_departamentos.Location = new System.Drawing.Point(12, 78);
            this.dg_departamentos.Name = "dg_departamentos";
            this.dg_departamentos.ReadOnly = true;
            this.dg_departamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_departamentos.RowHeadersVisible = false;
            this.dg_departamentos.RowHeadersWidth = 80;
            this.dg_departamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_departamentos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_departamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_departamentos.Size = new System.Drawing.Size(897, 497);
            this.dg_departamentos.TabIndex = 51;
            this.dg_departamentos.SelectionChanged += new System.EventHandler(this.dg_departamentos_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Departamentos";
            // 
            // btn_editar_departamento
            // 
            this.btn_editar_departamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar_departamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_editar_departamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar_departamento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editar_departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar_departamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editar_departamento.Location = new System.Drawing.Point(932, 124);
            this.btn_editar_departamento.Name = "btn_editar_departamento";
            this.btn_editar_departamento.Size = new System.Drawing.Size(120, 30);
            this.btn_editar_departamento.TabIndex = 77;
            this.btn_editar_departamento.Text = "Editar";
            this.btn_editar_departamento.UseVisualStyleBackColor = false;
            this.btn_editar_departamento.Click += new System.EventHandler(this.btn_editar_departamento_Click);
            // 
            // btn_nuevo_departamento
            // 
            this.btn_nuevo_departamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo_departamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_nuevo_departamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_departamento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nuevo_departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo_departamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_nuevo_departamento.Location = new System.Drawing.Point(932, 78);
            this.btn_nuevo_departamento.Name = "btn_nuevo_departamento";
            this.btn_nuevo_departamento.Size = new System.Drawing.Size(120, 30);
            this.btn_nuevo_departamento.TabIndex = 76;
            this.btn_nuevo_departamento.Text = "Nuevo";
            this.btn_nuevo_departamento.UseVisualStyleBackColor = false;
            this.btn_nuevo_departamento.Click += new System.EventHandler(this.btn_nuevo_departamento_Click_1);
            // 
            // btn_cerrar_productos
            // 
            this.btn_cerrar_productos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            this.btn_cerrar_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_productos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cerrar_productos.Location = new System.Drawing.Point(1020, 47);
            this.btn_cerrar_productos.Name = "btn_cerrar_productos";
            this.btn_cerrar_productos.Size = new System.Drawing.Size(32, 25);
            this.btn_cerrar_productos.TabIndex = 79;
            this.btn_cerrar_productos.Text = "X";
            this.btn_cerrar_productos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cerrar_productos.UseVisualStyleBackColor = false;
            this.btn_cerrar_productos.Click += new System.EventHandler(this.btn_cerrar_productos_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "ULTIMO CAMBIO:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txt_usuario_cambio);
            this.flowLayoutPanel1.Controls.Add(this.txt_fecha_cambio);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(897, 25);
            this.flowLayoutPanel1.TabIndex = 83;
            // 
            // txt_usuario_cambio
            // 
            this.txt_usuario_cambio.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_usuario_cambio.Location = new System.Drawing.Point(124, 3);
            this.txt_usuario_cambio.Name = "txt_usuario_cambio";
            this.txt_usuario_cambio.ReadOnly = true;
            this.txt_usuario_cambio.Size = new System.Drawing.Size(404, 22);
            this.txt_usuario_cambio.TabIndex = 83;
            this.txt_usuario_cambio.TextChanged += new System.EventHandler(this.txt_usuario_cambio_TextChanged);
            // 
            // txt_fecha_cambio
            // 
            this.txt_fecha_cambio.Location = new System.Drawing.Point(534, 3);
            this.txt_fecha_cambio.Name = "txt_fecha_cambio";
            this.txt_fecha_cambio.ReadOnly = true;
            this.txt_fecha_cambio.Size = new System.Drawing.Size(203, 22);
            this.txt_fecha_cambio.TabIndex = 84;
            // 
            // FormDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_cerrar_productos);
            this.Controls.Add(this.btn_editar_departamento);
            this.Controls.Add(this.btn_nuevo_departamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg_departamentos);
            this.Controls.Add(this.btn_eliminar_departamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.pagina_departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_departamentos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource tiendaDataSetBindingSource;
        private System.Windows.Forms.Button btn_eliminar_departamento;
        private System.Windows.Forms.DataGridView dg_departamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_editar_departamento;
        private System.Windows.Forms.Button btn_nuevo_departamento;
        private System.Windows.Forms.Button btn_cerrar_productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt_usuario_cambio;
        private System.Windows.Forms.TextBox txt_fecha_cambio;
    }
}