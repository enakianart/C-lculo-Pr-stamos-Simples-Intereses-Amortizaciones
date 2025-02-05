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
    public partial class FormularioConsultarPrestamos : Form
    {
        SqlDataAdapter sda;
        //DataGridView dgv;
        SqlCommandBuilder scb;

        DataTable dt;
        string nombre_servidor = Dns.GetHostName();
        public string conectar = "Data Source=ENZOACER\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;";

        public FormularioConsultarPrestamos()
        {
            InitializeComponent();
            dt = new DataTable();

        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            string buscar = BuscarTXT.Text;
            using (SqlConnection conexion = new SqlConnection(conectar))
            {
                conexion.Open();
                string consulta = $"SELECT p.* FROM Prestamos p INNER JOIN Clientes c ON p.ClientesId = c.ClientesId WHERE c.Nombre LIKE '{buscar}%'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaprestamos = new DataTable();
                adaptador.Fill(tablaprestamos);
                dataGridView1.DataSource = tablaprestamos;

                dataGridView1.Columns["PrestamosId"].ReadOnly = true;
                dataGridView1.Columns["ClientesId"].ReadOnly = false;
                dataGridView1.Columns["Monto"].ReadOnly = false;
                dataGridView1.Columns["PlazoMeses"].ReadOnly = false;

                dataGridView1.AllowUserToDeleteRows = false;

                if (dataGridView1.Columns.Contains("TasaInteres"))
                {
                    dataGridView1.Columns["TasaInteres"].Visible = false;
                }
            }
        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormularioPrestamos formularioPrestamos = new FormularioPrestamos();
            formularioPrestamos.Show();
            this.Close();
        }
    }
}
