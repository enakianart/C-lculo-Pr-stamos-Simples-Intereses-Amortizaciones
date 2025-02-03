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
    public partial class FormularioGestionarPago : Form
    {
        SqlDataAdapter sda;
        //DataGridView dgv;
        SqlCommandBuilder scb;

        DataTable dt;
        string nombre_servidor = Dns.GetHostName();
        public string conectar = "Data Source=ENZOACER\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;";

        public FormularioGestionarPago()
        {
            InitializeComponent();
            dt = new DataTable();

        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormularioPagos formularioPagos = new FormularioPagos();
            formularioPagos.Show();
        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            string buscar = Buscartxt.Text;
            using (SqlConnection conexion = new SqlConnection(conectar))
            {
                conexion.Open();
                string consulta = $"SELECT p.* FROM Pagos p INNER JOIN Clientes c ON p.ClientesId = c.ClientesId WHERE c.Nombre = '{buscar}%'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaclientes = new DataTable();
                adaptador.Fill(tablaclientes);
                dataGridView1.DataSource = tablaclientes;


                dataGridView1.Columns["ClientesId"].ReadOnly = false;
                dataGridView1.Columns["PrestamosId"].ReadOnly = false;
                dataGridView1.Columns["FechaPago"].ReadOnly = false;
                dataGridView1.Columns["MontoAnterior"].ReadOnly = false;
                dataGridView1.Columns["InteresPagado"].ReadOnly = false;
                dataGridView1.Columns["MontoPagado"].ReadOnly = false;
                dataGridView1.Columns["NuevoMonto"].ReadOnly = false;



                dataGridView1.AllowUserToDeleteRows = true;
            }
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;

                    // Crea una nueva fila
                    DataRow nuevaFila = dt.NewRow();

                    // *** ASIGNACIÓN DE VALORES A LA NUEVA FILA ***

                    nuevaFila["ClientesId"] = "00";
                    nuevaFila["PrestamosId"] = "000-000-0000";
                    nuevaFila["Direccion"] = "Nueva Dirección";
                    nuevaFila["Sueldo"] = 0;
                    nuevaFila["Garantia"] = 0;
                    nuevaFila["Estado"] = "Activo";

                    dt.Rows.Add(nuevaFila);

                    dataGridView1.Refresh(); // Actualiza el DataGridView
                }
                else
                {
                    MessageBox.Show("Primero debe realizar una búsqueda para cargar los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }

        
        }

        private void ActualizarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;

                    if (sda == null)
                    {
                        sda = new SqlDataAdapter("SELECT * FROM Clientes WHERE 1=0", conectar);
                    }

                    using (SqlConnection connection = new SqlConnection(conectar))
                    {
                        connection.Open();
                        sda.SelectCommand.Connection = connection;

                        scb = new SqlCommandBuilder(sda);

                        sda.Update(dt);

                        connection.Close();
                    }

                    MessageBox.Show("Datos actualizados correctamente.");

                    BuscarBTN_Click(sender, e);
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
