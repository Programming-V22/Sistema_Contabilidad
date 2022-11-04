namespace sistema_contable01
{
    partial class FrmzBuscar_plan
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbuscar1 = new System.Windows.Forms.TextBox();
            this.dgvplan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_contable01.Properties.Resources.seo_social_web_network_internet_340_icon_icons_com_61497;
            this.pictureBox1.Location = new System.Drawing.Point(47, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txtbuscar1
            // 
            this.txtbuscar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar1.Location = new System.Drawing.Point(102, 39);
            this.txtbuscar1.Name = "txtbuscar1";
            this.txtbuscar1.Size = new System.Drawing.Size(214, 23);
            this.txtbuscar1.TabIndex = 28;
            this.txtbuscar1.Visible = false;
            this.txtbuscar1.TextChanged += new System.EventHandler(this.txtbuscar1_TextChanged);
            // 
            // dgvplan
            // 
            this.dgvplan.AllowUserToAddRows = false;
            this.dgvplan.AllowUserToDeleteRows = false;
            this.dgvplan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplan.Location = new System.Drawing.Point(47, 65);
            this.dgvplan.Name = "dgvplan";
            this.dgvplan.ReadOnly = true;
            this.dgvplan.RowHeadersVisible = false;
            this.dgvplan.Size = new System.Drawing.Size(269, 417);
            this.dgvplan.TabIndex = 27;
            this.dgvplan.Visible = false;
            // 
            // FrmzBuscar_plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbuscar1);
            this.Controls.Add(this.dgvplan);
            this.Name = "FrmzBuscar_plan";
            this.Text = "PLAN DE CUENTA";
            this.Load += new System.EventHandler(this.FrmzBuscar_plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbuscar1;
        public System.Windows.Forms.DataGridView dgvplan;
    }
}