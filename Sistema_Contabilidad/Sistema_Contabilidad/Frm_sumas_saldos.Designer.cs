namespace sistema_contable01
{
    partial class Frm_sumas_saldos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Suma_saldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datos_Reportes = new sistema_contable01.Datos_Reportes();
            this.Rp_suma_saldo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Suma_saldoTableAdapter = new sistema_contable01.Datos_ReportesTableAdapters.Suma_saldoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Suma_saldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Suma_saldoBindingSource
            // 
            this.Suma_saldoBindingSource.DataMember = "Suma_saldo";
            this.Suma_saldoBindingSource.DataSource = this.Datos_Reportes;
            // 
            // Datos_Reportes
            // 
            this.Datos_Reportes.DataSetName = "Datos_Reportes";
            this.Datos_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rp_suma_saldo
            // 
            this.Rp_suma_saldo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Suma_saldoBindingSource;
            this.Rp_suma_saldo.LocalReport.DataSources.Add(reportDataSource3);
            this.Rp_suma_saldo.LocalReport.ReportEmbeddedResource = "sistema_contable01.Report_Suma_saldo.rdlc";
            this.Rp_suma_saldo.Location = new System.Drawing.Point(106, 73);
            this.Rp_suma_saldo.Name = "Rp_suma_saldo";
            this.Rp_suma_saldo.ServerReport.BearerToken = null;
            this.Rp_suma_saldo.Size = new System.Drawing.Size(838, 406);
            this.Rp_suma_saldo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_mostrar);
            this.panel1.Controls.Add(this.dtp_fecha2);
            this.panel1.Controls.Add(this.dtp_fecha1);
            this.panel1.Location = new System.Drawing.Point(106, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 73);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(137, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(379, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Fin:";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_mostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.ForeColor = System.Drawing.Color.White;
            this.btn_mostrar.Location = new System.Drawing.Point(618, 28);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(113, 29);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha2.Location = new System.Drawing.Point(472, 32);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(107, 24);
            this.dtp_fecha2.TabIndex = 1;
            this.dtp_fecha2.ValueChanged += new System.EventHandler(this.dtp_fecha2_ValueChanged);
            // 
            // dtp_fecha1
            // 
            this.dtp_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha1.Location = new System.Drawing.Point(242, 32);
            this.dtp_fecha1.Name = "dtp_fecha1";
            this.dtp_fecha1.Size = new System.Drawing.Size(107, 24);
            this.dtp_fecha1.TabIndex = 0;
            this.dtp_fecha1.Value = new System.DateTime(2022, 7, 26, 1, 11, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Rp_suma_saldo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 715);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 705);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1040, 10);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1040, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 715);
            this.panel3.TabIndex = 2;
            // 
            // Suma_saldoTableAdapter
            // 
            this.Suma_saldoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_sumas_saldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 715);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_sumas_saldos";
            this.Text = "Sumas y Saldos";
            this.Load += new System.EventHandler(this.Frm_sumas_saldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Suma_saldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rp_suma_saldo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.DateTimePicker dtp_fecha1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource Suma_saldoBindingSource;
        private Datos_Reportes Datos_Reportes;
        private Datos_ReportesTableAdapters.Suma_saldoTableAdapter Suma_saldoTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}