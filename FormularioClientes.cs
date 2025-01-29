using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    public partial class FormularioClientes : Form
    {
        public FormularioClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClienteBTN_Click(object sender, EventArgs e)
        {
            FormConsultarCliente formConsultarCliente = new FormConsultarCliente();
            formConsultarCliente.Show();
        }
    }
}
