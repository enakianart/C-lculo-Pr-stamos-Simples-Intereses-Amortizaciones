using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    public partial class FormConsultarCliente : Form
    {
        string nombre_servidor = Dns.GetHostName();
        public string conectar = "Data Source=ENZOACER\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;";

        public FormConsultarCliente()
        {
            InitializeComponent();
        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {

        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {

            string buscar = Buscartxt.Text;
            using (SqlConnection conexion = new SqlConnection(conectar))
            {
                conexion.Open();
                string consulta = $"SELECT * FROM Clientes WHERE Nombre Like '{buscar}%'";
                SqlCommand comando = new SqlCommand(consulta,conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaclientes = new DataTable();
                adaptador.Fill(tablaclientes);
                dataGridView1.DataSource = tablaclientes;

               

            }
        }
    }
}
