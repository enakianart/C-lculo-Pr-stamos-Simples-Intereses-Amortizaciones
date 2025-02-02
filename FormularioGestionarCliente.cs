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
    public partial class FormularioGestionarCliente : Form
    {
        SqlDataAdapter sda;
        //DataGridView dgv;
        SqlCommandBuilder scb;

        DataTable dt;
        string nombre_servidor = Dns.GetHostName();
        public string conectar = "Data Source=ENZOACER\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;";

        public FormularioGestionarCliente()
        {
            InitializeComponent();
            dt = new DataTable();

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


                dataGridView1.Columns["ClientesId"].ReadOnly = true;
                dataGridView1.Columns["Nombre"].ReadOnly = false;
                dataGridView1.Columns["Telefono"].ReadOnly = false;
                dataGridView1.Columns["Direccion"].ReadOnly = false;
                dataGridView1.Columns["Sueldo"].ReadOnly = false;
                dataGridView1.Columns["Garantia"].ReadOnly = false;
                dataGridView1.Columns["Estado"].ReadOnly = false;


                dataGridView1.AllowUserToDeleteRows = true;
            }
        }

        private void ActualizarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;

                    // Validar el estado del cliente antes de actualizar
                    foreach (DataRow row in dt.Rows)
                    {
                        string estado = row["Estado"].ToString();
                        if (estado != "Activo" && estado != "Moroso" && estado != "Cancelado")
                        {
                            MessageBox.Show("El estado del cliente debe ser 'Activo', 'Moroso' o 'Cancelado'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Detener la actualización si el estado es inválido
                        }
                    }


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
             
                    nuevaFila["Nombre"] = "Nuevo Cliente";
                    nuevaFila["Correo"] = "Correo@ejemplo.com";
                    nuevaFila["Telefono"] = "000-000-0000";
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

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;

                    // Obtén la fila seleccionada
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                        DataRow filaAEliminar = ((DataRowView)filaSeleccionada.DataBoundItem).Row;

                        filaAEliminar.Delete(); // Elimina la fila del DataTable

                        // Actualiza el DataGridView para reflejar la eliminación
                        dataGridView1.Refresh(); // O dataGridView1.Update();
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una fila para eliminar.");
                    }
                }
                else
                {
                    MessageBox.Show("Primero debe realizar una búsqueda para cargar los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
   
        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormularioClientes formularioClientes = new FormularioClientes();
            formularioClientes.Show();
            this.Close();
        }
    }
}
