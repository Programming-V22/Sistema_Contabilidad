namespace sistema_contable01
{
    partial class frm_gestion
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
            this.txtfecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.txtfecha_fin = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre_empresa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtid_empresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtfecha_inicio
            // 
            this.txtfecha_inicio.CalendarForeColor = System.Drawing.Color.Black;
            this.txtfecha_inicio.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.txtfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha_inicio.Location = new System.Drawing.Point(32, 63);
            this.txtfecha_inicio.Name = "txtfecha_inicio";
            this.txtfecha_inicio.Size = new System.Drawing.Size(111, 20);
            this.txtfecha_inicio.TabIndex = 0;
            // 
            // txtfecha_fin
            // 
            this.txtfecha_fin.CalendarForeColor = System.Drawing.Color.Black;
            this.txtfecha_fin.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.txtfecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha_fin.Location = new System.Drawing.Point(167, 63);
            this.txtfecha_fin.Name = "txtfecha_fin";
            this.txtfecha_fin.Size = new System.Drawing.Size(120, 20);
            this.txtfecha_fin.TabIndex = 1;
            this.txtfecha_fin.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(252)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(214, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar Gestion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 209);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 10);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(579, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 199);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 10);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(162, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "REGISTRAR GESTION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnombre_empresa
            // 
            this.txtnombre_empresa.Location = new System.Drawing.Point(293, 63);
            this.txtnombre_empresa.Name = "txtnombre_empresa";
            this.txtnombre_empresa.Size = new System.Drawing.Size(169, 20);
            this.txtnombre_empresa.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(252)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(468, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "Empresa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtid_empresa
            // 
            this.txtid_empresa.Location = new System.Drawing.Point(293, 63);
            this.txtid_empresa.Name = "txtid_empresa";
            this.txtid_empresa.Size = new System.Drawing.Size(38, 20);
            this.txtid_empresa.TabIndex = 22;
            this.txtid_empresa.Visible = false;
            // 
            // frm_gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(589, 209);
            this.Controls.Add(this.txtid_empresa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtnombre_empresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfecha_fin);
            this.Controls.Add(this.txtfecha_inicio);
            this.Name = "frm_gestion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Gestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker txtfecha_inicio;
        public System.Windows.Forms.DateTimePicker txtfecha_fin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre_empresa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtid_empresa;
    }
}