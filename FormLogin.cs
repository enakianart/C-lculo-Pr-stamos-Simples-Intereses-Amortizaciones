﻿using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ClienteBTN_Click(object sender, EventArgs e)
        {
            FormularioClientes formularioClientes = new FormularioClientes();
            formularioClientes.Show();

        }

        private void ReportesBTN_Click(object sender, EventArgs e)
        {
            FormReportes frmReportes = new FormReportes();
            frmReportes.Show();
        }
    }
}
