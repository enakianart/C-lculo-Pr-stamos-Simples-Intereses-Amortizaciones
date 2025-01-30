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
<<<<<<< HEAD
            FormularioClientes formularioClientes = new FormularioClientes();
            formularioClientes.Show();
            this.Close();
=======

>>>>>>> 1263d0f81bb970c4d04ac7bc9849c1069c9da9c5
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

<<<<<<< HEAD

                dataGridView1.Columns["ClientesId"].ReadOnly = true;
                dataGridView1.Columns["Nombre"].ReadOnly = false; 
                dataGridView1.Columns["Telefono"].ReadOnly = false;
                dataGridView1.Columns["Direccion"].ReadOnly = false;
                dataGridView1.Columns["Sueldo"].ReadOnly = true;
                dataGridView1.Columns["Garantia"].ReadOnly = true;

                dataGridView1.AllowUserToDeleteRows = false;

            }
        }
        
        }
    }

    
=======
               

            }
        }
    }
}
>>>>>>> 1263d0f81bb970c4d04ac7bc9849c1069c9da9c5
