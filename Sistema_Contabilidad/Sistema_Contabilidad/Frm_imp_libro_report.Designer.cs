namespace sistema_contable01
{
    partial class Frm_imp_libro_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_imp_libro_report));
            this.Imprimir_asientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Datos_Reportes = new sistema_contable01.Datos_Reportes();
            this.Report_asiento_conta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Imprimir_asientoTableAdapter = new sistema_contable01.Datos_ReportesTableAdapters.Imprimir_asientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Imprimir_asientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // Imprimir_asientoBindingSource
            // 
            this.Imprimir_asientoBindingSource.DataMember = "Imprimir_asiento";
            this.Imprimir_asientoBindingSource.DataSource = this.Datos_Reportes;
            // 
            // Datos_Reportes
            // 
            this.Datos_Reportes.DataSetName = "Datos_Reportes";
            this.Datos_Reportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report_asiento_conta
            // 
            this.Report_asiento_conta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Imprimir_asientoBindingSource;
            this.Report_asiento_conta.LocalReport.DataSources.Add(reportDataSource1);
            this.Report_asiento_conta.LocalReport.ReportEmbeddedResource = "sistema_contable01.Imprimir_libro.rdlc";
            this.Report_asiento_conta.Location = new System.Drawing.Point(0, 0);
            this.Report_asiento_conta.Name = "Report_asiento_conta";
            this.Report_asiento_conta.ServerReport.BearerToken = null;
            this.Report_asiento_conta.Size = new System.Drawing.Size(715, 423);
            this.Report_asiento_conta.TabIndex = 0;
            this.Report_asiento_conta.Load += new System.EventHandler(this.Report_asiento_conta_Load);
            // 
            // Imprimir_asientoTableAdapter
            // 
            this.Imprimir_asientoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_imp_libro_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 423);
            this.Controls.Add(this.Report_asiento_conta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_imp_libro_report";
            this.Text = "ASIENTO CONTABLE";
            this.Load += new System.EventHandler(this.Frm_imp_libro_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imprimir_asientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_Reportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource Imprimir_asientoBindingSource;
        private Datos_Reportes Datos_Reportes;
        private Datos_ReportesTableAdapters.Imprimir_asientoTableAdapter Imprimir_asientoTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer Report_asiento_conta;
    }
}