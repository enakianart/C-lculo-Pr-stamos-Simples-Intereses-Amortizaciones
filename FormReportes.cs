using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void Reporte2BTN_Click(object sender, EventArgs e)
        {
            ReportViewer reportViewer1 = new ReportViewer();
            //y ponerle el nombre al cod de aqui.



            // Cargar el reporte
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Administrador\\Desktop\\Intereses\\Reportes\\Reporte_Clientes.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource dataSource = new ReportDataSource("DS_Clientes");
            reportViewer1.LocalReport.DataSources.Add(dataSource);

            // Mostrar y refrescar el reporte
            reportViewer1.RefreshReport();

            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);

            //DataGridView.DataSource = dataSource;
            //DataGridView.DataMember = "Clientes";

            {

            }


        }

    }
}
