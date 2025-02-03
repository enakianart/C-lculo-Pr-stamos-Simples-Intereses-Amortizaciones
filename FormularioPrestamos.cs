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
    public partial class FormularioPrestamos : Form
    {
        public FormularioPrestamos()
        {
            InitializeComponent();
        }

       

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void ConsultarPrestamoBTN_Click(object sender, EventArgs e)
        {
            FormularioConsultarPrestamos formularioConsultarPrestamos = new FormularioConsultarPrestamos();
            formularioConsultarPrestamos.Show();
        }
    }
}
