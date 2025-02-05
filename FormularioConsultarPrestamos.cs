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
    public partial class FormularioConsultarPrestamos : Form
    {
        public FormularioConsultarPrestamos()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream:FormularioConsultarPrestamos.cs
=======
        public string ClientesId {  get; set; }
        public string Nombre { get; set; }
        public string Correo {  get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int Sueldo { get; set; }
        public string Garantia { get; set; }
        public string Estado { get; set; }

        private void Formulario_para_reporte_Load(object sender, EventArgs e)
        {
           
            this.RV1.RefreshReport();
            this.RV1.RefreshReport();
        }

    
>>>>>>> Stashed changes:Reportes/Formulario para reporte.cs
    }
}
