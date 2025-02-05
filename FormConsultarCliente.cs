using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_Préstamos_Simples__Intereses__Amortizaciones
{
    public partial class FormConsultarCliente : Form
    {
        SqlDataAdapter sda;
        //DataGridView dgv;
        SqlCommandBuilder scb;

        DataTable dt;
        string nombre_servidor = Dns.GetHostName();
        public string conectar = "Data Source=ENZOACER\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;";



        public FormConsultarCliente()
        {
            InitializeComponent();
            dt = new DataTable();

        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            //<<<<<<< HEAD
            FormularioClientes formularioClientes = new FormularioClientes();
            formularioClientes.Show();
            this.Close();
            //=======

            //>>>>>>> 1263d0f81bb970c4d04ac7bc9849c1069c9da9c5
        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {

            string buscar = Buscartxt.Text;
            using (SqlConnection conexion = new SqlConnection(conectar))
            {
                conexion.Open();
                string consulta = $"SELECT * FROM Clientes WHERE Nombre Like '{buscar}%'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaclientes = new DataTable();
                adaptador.Fill(tablaclientes);
                dataGridView1.DataSource = tablaclientes;

                //<<<<<<< HEAD

                dataGridView1.Columns["ClientesId"].ReadOnly = true;
                dataGridView1.Columns["Nombre"].ReadOnly = false;
                dataGridView1.Columns["Telefono"].ReadOnly = false;
                dataGridView1.Columns["Direccion"].ReadOnly = false;
                dataGridView1.Columns["Sueldo"].ReadOnly = true;
                dataGridView1.Columns["Garantia"].ReadOnly = true;
                dataGridView1.Columns["Estado"].ReadOnly = true;
                dataGridView1.Columns["CantidadMoras"].ReadOnly = true;



                dataGridView1.AllowUserToDeleteRows = false;

            }
        }

        private void ActualizarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;

                    // Usa la cadena de conexión directamente en la creación del adaptador
                    if (sda == null)
                    {
                        sda = new SqlDataAdapter("SELECT * FROM Clientes WHERE 1=0", conectar); // Inicializa el DataAdapter
                    }

                    using (SqlConnection connection = new SqlConnection(conectar))
                    {
                        connection.Open();
                        sda.SelectCommand.Connection = connection; // Asigna la conexión al comando

                        scb = new SqlCommandBuilder(sda); // Crea el SqlCommandBuilder

                        // Actualiza los datos en la base de datos
                        sda.Update(dt);

                        connection.Close();
                    }

                    MessageBox.Show("Datos actualizados correctamente.");

                    // Refresca el DataGridView para reflejar los cambios (opcional)
                    BuscarBTN_Click(sender, e); // O tu método preferido para refrescar
                }
                else
                {
                    MessageBox.Show("Primero debe realizar una búsqueda para cargar los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }

        }

        
    }
}
    

    
//=======
               

//            }
//        }
//    }
//}
//>>>>>>> 1263d0f81bb970c4d04ac7bc9849c1069c9da9c5
