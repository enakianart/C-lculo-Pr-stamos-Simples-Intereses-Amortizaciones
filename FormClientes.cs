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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD:Form1.cs
        private void ConsultarClienteBTN_Click(object sender, EventArgs e)
        {
            FormConsultarCliente formConsultarCliente = new FormConsultarCliente();
            formConsultarCliente.Show();
            this.Close();

        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }
=======
        private void Form1_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 1263d0f81bb970c4d04ac7bc9849c1069c9da9c5:FormClientes.cs
    }
}
