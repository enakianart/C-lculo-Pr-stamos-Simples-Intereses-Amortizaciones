using Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        public Form Reporte_Cliente { get; set; }

        private void Reporte2BTN_Click(object sender, EventArgs e)
        {
            Formulario_para_reporte FormReport = new Formulario_para_reporte();
            FormReport.ShowDialog();
            /*
            Reporte_Cliente.ShowDialog();
            Formulario_para_reporte report = new Formulario_para_reporte();
            report.RV1.LocalReport.ReportPath = "C:\\Users\\Administrador\\Desktop\\Proyecto-Prestamos\\C-lculo-Pr-stamos-Simples-Intereses-Amortizaciones\\Reportes\\Reporte_Cliente.rdlc";
            //report.RV1
            //ReportDataSource dataSource = new ReportDataSource("DataSet1", db_prestamosDataSet.Tables["Clientes"]);
            //ReportDataSource dataSource2 = new ReportDataSource("DataSet2", db_prestamosDataSet.Tables["Amortizaciones"]);


            //datagridview con dos tablas juntas
            DataSet ds = new DataSet();
            DataTable dataset1 = new DataTable("Clientesdt");
            DataTable dataset2 = new DataTable("Amortizaciondt");

            // Agregar las DataTables al DataSet
            ds.Tables.Add(dataset1);
            ds.Tables.Add(dataset2);

            //hay relacion
            DataRelation relation = new DataRelation("FK_Clientesdt_Amortizaciondt", dataset1.Columns["ClientesId"], dataset2.Columns["ClientesId"]);
            ds.Relations.Add(relation);

           

            ClientesDT.DataSource = ds;
            DTVclientes.DataMember = "Clientesdt";*/
        }
    }
}
