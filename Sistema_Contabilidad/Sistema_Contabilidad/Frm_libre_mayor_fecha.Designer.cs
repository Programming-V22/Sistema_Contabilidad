namespace sistema_contable01
{
    partial class Frm_libro_mayor_fecha
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.libro_mayor_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datos_Reportes = new sistema_contable01.Datos_Reportes();
            this.Panel_arriba = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar_lb_mayor = new System.Windows.Forms.Button();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.Panel_centro = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rport_libro_may_fecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.libro_mayor_fechaTableAdapter = new sistema_contable01.Datos_ReportesTableAdapters.libro_mayor_fechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libro_mayor_fechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).BeginInit();
            this.Panel_arriba.SuspendLayout();
            this.Panel_centro.SuspendLayout();
            this.SuspendLayout();
            // 
            // libro_mayor_fechaBindingSource
            // 
            this.libro_mayor_fechaBindingSource.DataMember = "libro_mayor_fecha";
            this.libro_mayor_fechaBindingSource.DataSource = this.Datos_Reportes;
            // 
            // Datos_Reportes
            // 
            this.Datos_Reportes.DataSetName = "Datos_Reportes";
            this.Datos_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Panel_arriba
            // 
            this.Panel_arriba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel_arriba.BackColor = System.Drawing.Color.SkyBlue;
            this.Panel_arriba.Controls.Add(this.label3);
            this.Panel_arriba.Controls.Add(this.label4);
            this.Panel_arriba.Controls.Add(this.btn_buscar_lb_mayor);
            this.Panel_arriba.Controls.Add(this.dtp_fecha2);
            this.Panel_arriba.Controls.Add(this.dtp_fecha1);
            this.Panel_arriba.Location = new System.Drawing.Point(106, 1);
            this.Panel_arriba.Name = "Panel_arriba";
            this.Panel_arriba.Size = new System.Drawing.Size(838, 73);
            this.Panel_arriba.TabIndex = 2;
            this.Panel_arriba.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_arriba_Paint);
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
            this.label3.TabIndex = 10;
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
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Fin:";
            // 
            // btn_buscar_lb_mayor
            // 
            this.btn_buscar_lb_mayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_buscar_lb_mayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_lb_mayor.ForeColor = System.Drawing.Color.White;
            this.btn_buscar_lb_mayor.Location = new System.Drawing.Point(619, 28);
            this.btn_buscar_lb_mayor.Name = "btn_buscar_lb_mayor";
            this.btn_buscar_lb_mayor.Size = new System.Drawing.Size(113, 29);
            this.btn_buscar_lb_mayor.TabIndex = 7;
            this.btn_buscar_lb_mayor.Text = "MOSTRAR";
            this.btn_buscar_lb_mayor.UseVisualStyleBackColor = false;
            this.btn_buscar_lb_mayor.Click += new System.EventHandler(this.btn_buscar_lb_mayor_Click);
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha2.Location = new System.Drawing.Point(472, 32);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(107, 24);
            this.dtp_fecha2.TabIndex = 1;
            // 
            // dtp_fecha1
            // 
            this.dtp_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha1.Location = new System.Drawing.Point(242, 32);
            this.dtp_fecha1.Name = "dtp_fecha1";
            this.dtp_fecha1.Size = new System.Drawing.Size(107, 24);
            this.dtp_fecha1.TabIndex = 0;
            // 
            // Panel_centro
            // 
            this.Panel_centro.Controls.Add(this.panel3);
            this.Panel_centro.Controls.Add(this.panel2);
            this.Panel_centro.Controls.Add(this.Panel_arriba);
            this.Panel_centro.Controls.Add(this.Rport_libro_may_fecha);
            this.Panel_centro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_centro.Location = new System.Drawing.Point(0, 0);
            this.Panel_centro.Name = "Panel_centro";
            this.Panel_centro.Size = new System.Drawing.Size(1050, 715);
            this.Panel_centro.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 705);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 10);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1040, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 715);
            this.panel2.TabIndex = 3;
            // 
            // Rport_libro_may_fecha
            // 
            this.Rport_libro_may_fecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.libro_mayor_fechaBindingSource;
            this.Rport_libro_may_fecha.LocalReport.DataSources.Add(reportDataSource1);
            this.Rport_libro_may_fecha.LocalReport.ReportEmbeddedResource = "sistema_contable01.RP_lib_mayor_fecha.rdlc";
            this.Rport_libro_may_fecha.Location = new System.Drawing.Point(106, 73);
            this.Rport_libro_may_fecha.Name = "Rport_libro_may_fecha";
            this.Rport_libro_may_fecha.ServerReport.BearerToken = null;
            this.Rport_libro_may_fecha.Size = new System.Drawing.Size(838, 406);
            this.Rport_libro_may_fecha.TabIndex = 0;
            // 
            // libro_mayor_fechaTableAdapter
            // 
            this.libro_mayor_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_libro_mayor_fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 715);
            this.Controls.Add(this.Panel_centro);
            this.Name = "Frm_libro_mayor_fecha";
            this.Text = "LIBRO MAYOR";
            this.Load += new System.EventHandler(this.Frm_libro_mayor_fecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libro_mayor_fechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).EndInit();
            this.Panel_arriba.ResumeLayout(false);
            this.Panel_arriba.PerformLayout();
            this.Panel_centro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_arriba;
        private System.Windows.Forms.Button btn_buscar_lb_mayor;
        private System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.DateTimePicker dtp_fecha1;
        private System.Windows.Forms.Panel Panel_centro;
        private Microsoft.Reporting.WinForms.ReportViewer Rport_libro_may_fecha;
        private System.Windows.Forms.BindingSource libro_mayor_fechaBindingSource;
        private Datos_Reportes Datos_Reportes;
        private Datos_ReportesTableAdapters.libro_mayor_fechaTableAdapter libro_mayor_fechaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}