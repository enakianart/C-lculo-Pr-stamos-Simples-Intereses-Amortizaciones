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
    public partial class FormularioPagos : Form
    {
        public FormularioPagos()
        {
            InitializeComponent();
        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void GestionarPagoBTN_Click(object sender, EventArgs e)
        {
            FormularioGestionarPago formularioGestionarPago = new FormularioGestionarPago();
            formularioGestionarPago.Show();
        }

        private void ConsultarPagoBTN_Click(object sender, EventArgs e)
        {
            FormularioRealizarPago formularioConsultarPago = new FormularioRealizarPago();
            formularioConsultarPago.Show();
            this.Close();
        }
    }
}
