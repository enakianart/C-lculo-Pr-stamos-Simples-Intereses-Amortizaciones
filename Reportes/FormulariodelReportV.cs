using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones.Reportes
{
    public partial class FormulariodelReportV : Form
    {
        public FormulariodelReportV()
        {
            InitializeComponent();
        }

        private void FormulariodelReportV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_prestamosDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.db_prestamosDataSet.Clientes);

            this.RV_Clientes.RefreshReport();
        }

        private void RV_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_prestamosDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.db_prestamosDataSet.Clientes);

            this.RV_Clientes.RefreshReport();
        }
    }
}
