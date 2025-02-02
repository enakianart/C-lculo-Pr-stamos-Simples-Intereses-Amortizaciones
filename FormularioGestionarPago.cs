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
    public partial class FormularioGestionarPago : Form
    {
        public FormularioGestionarPago()
        {
            InitializeComponent();
        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormularioPagos formularioPagos = new FormularioPagos();
            formularioPagos.Show();
        }
    }
}
