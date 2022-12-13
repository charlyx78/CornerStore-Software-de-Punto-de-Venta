
namespace Proyecto_fina
{
    partial class FormPaginaPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.dg_reorden = new System.Windows.Forms.DataGridView();
            this.lbl_tabla_vacia = new System.Windows.Forms.Label();
            this.img_tabla_vacia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_reorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Productos en punto de reorden";
            // 
            // dg_reorden
            // 
            this.dg_reorden.AllowUserToAddRows = false;
            this.dg_reorden.AllowUserToDeleteRows = false;
            this.dg_reorden.AllowUserToResizeColumns = false;
            this.dg_reorden.AllowUserToResizeRows = false;
            this.dg_reorden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_reorden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_reorden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.dg_reorden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_reorden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(99)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_reorden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_reorden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_reorden.EnableHeadersVisualStyles = false;
            this.dg_reorden.GridColor = System.Drawing.SystemColors.Control;
            this.dg_reorden.Location = new System.Drawing.Point(12, 48);
            this.dg_reorden.Name = "dg_reorden";
            this.dg_reorden.ReadOnly = true;
            this.dg_reorden.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_reorden.RowHeadersVisible = false;
            this.dg_reorden.RowHeadersWidth = 80;
            this.dg_reorden.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(208)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dg_reorden.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_reorden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_reorden.Size = new System.Drawing.Size(1040, 581);
            this.dg_reorden.TabIndex = 77;
            // 
            // lbl_tabla_vacia
            // 
            this.lbl_tabla_vacia.AutoSize = true;
            this.lbl_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lbl_tabla_vacia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tabla_vacia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tabla_vacia.Location = new System.Drawing.Point(233, 363);
            this.lbl_tabla_vacia.Name = "lbl_tabla_vacia";
            this.lbl_tabla_vacia.Size = new System.Drawing.Size(637, 25);
            this.lbl_tabla_vacia.TabIndex = 95;
            this.lbl_tabla_vacia.Text = "NINGÚN PRODUCTO HA LLEGADO A SU PUNTO DE REORDEN";
            this.lbl_tabla_vacia.Visible = false;
            // 
            // img_tabla_vacia
            // 
            this.img_tabla_vacia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.img_tabla_vacia.Image = global::Proyecto_fina.Properties.Resources.icons8_feliz_100;
            this.img_tabla_vacia.Location = new System.Drawing.Point(485, 253);
            this.img_tabla_vacia.Name = "img_tabla_vacia";
            this.img_tabla_vacia.Size = new System.Drawing.Size(100, 97);
            this.img_tabla_vacia.TabIndex = 96;
            this.img_tabla_vacia.TabStop = false;
            this.img_tabla_vacia.Visible = false;
            // 
            // FormPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1064, 641);
            this.Controls.Add(this.img_tabla_vacia);
            this.Controls.Add(this.lbl_tabla_vacia);
            this.Controls.Add(this.dg_reorden);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPaginaPrincipal";
            this.Text = "FormPaginaPrincipal";
            this.Load += new System.EventHandler(this.FormPaginaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_reorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabla_vacia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_reorden;
        private System.Windows.Forms.PictureBox img_tabla_vacia;
        private System.Windows.Forms.Label lbl_tabla_vacia;
    }
}