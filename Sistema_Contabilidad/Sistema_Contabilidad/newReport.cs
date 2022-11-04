using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_dato;
using capa_negocio;
using System.Data.SqlClient;
using System.Globalization;

namespace sistema_contable01
{
    public partial class newReport : Form
    {
        public newReport()
        {
            InitializeComponent();
        }

        private void newReport_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetpruevanuevo.detalle_libro' Puede moverla o quitarla según sea necesario.
           


            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }
    }
}
