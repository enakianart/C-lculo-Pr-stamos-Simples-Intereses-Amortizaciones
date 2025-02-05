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
    public partial class FormularioGestionarPrestamo : Form
    {

        SqlDataAdapter sda;
        //DataGridView dgv;
        SqlCommandBuilder scb;

        DataTable dt;
        string nombre_servidor = Dns.GetHostName();
        public string conectar = "Data Source=ENZOACER\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;";

        public FormularioGestionarPrestamo()
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
                string consulta = $"SELECT p.*, c.Sueldo, c.Garantia From Prestamos p INNER JOIN Clientes c ON p.ClientesId = c.ClientesId WHERE Nombre Like '{buscar}%'"; // Incluir Sueldo y Garantia
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaprestamos = new DataTable();
                adaptador.Fill(tablaprestamos);
                dataGridView1.DataSource = tablaprestamos;


                dataGridView1.Columns["PrestamosId"].ReadOnly = true;
                dataGridView1.Columns["ClientesId"].ReadOnly = false;
                dataGridView1.Columns["Monto"].ReadOnly = false;
                dataGridView1.Columns["PlazoMeses"].ReadOnly = false;
                dataGridView1.Columns["TasaInteres"].ReadOnly = false;
                dataGridView1.Columns["Sueldo"].ReadOnly = true; // Hacer Sueldo de solo lectura
                dataGridView1.Columns["Garantia"].ReadOnly = true; // Hacer Garantia de solo lectura


                dataGridView1.AllowUserToDeleteRows = true;
            }
        }

        private void ActualizarAgregarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;

                    if (sda == null)
                    {
                        sda = new SqlDataAdapter("SELECT * FROM Prestamos WHERE 1=0", conectar);
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

        private void FormularioGestionarPrestamo_Shown(object sender, EventArgs e)
        {
            // Calcular la tasa para las filas existentes (si las hay)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int plazoMeses = Convert.ToInt32(row.Cells["PlazoMeses"].Value);
                decimal tasaInteres = CalcularTasaInteres(plazoMeses);
                row.Cells["TasaInteres"].Value = tasaInteres;
            }
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCliente = AgregarPrestamoTXT.Text;

                using (SqlConnection conexion = new SqlConnection(conectar))
                {
                    conexion.Open();
                    string consultaCliente = $"SELECT ClientesId, Sueldo, Garantia FROM Clientes WHERE Nombre LIKE '{nombreCliente}%'";
                    SqlCommand comandoCliente = new SqlCommand(consultaCliente, conexion);
                    using (SqlDataReader lectorCliente = comandoCliente.ExecuteReader()) // Using para asegurar el cierre del lector
                    {
                        if (!lectorCliente.Read())
                        {
                            MessageBox.Show($"No se encontró ningún cliente con el nombre '{nombreCliente}'.");
                            return; // Salir si no se encuentra el cliente
                        }

                        int clienteId = lectorCliente.GetInt32(0);
                        int sueldo = lectorCliente.GetInt32(1);
                        string garantia = lectorCliente.GetString(2);

                        if (dataGridView1.DataSource == null)
                        {
                            MessageBox.Show("Primero debe realizar una búsqueda para cargar los datos.");
                            return;
                        }

                        dt = (DataTable)dataGridView1.DataSource;
                        DataRow nuevaFila = dt.NewRow();

                        nuevaFila["ClientesId"] = clienteId;
                        nuevaFila["PrestamosId"] = DBNull.Value;
                        nuevaFila["Monto"] = 0;
                        nuevaFila["PlazoMeses"] = 1; // Valor inicial
                        nuevaFila["TasaInteres"] = 0; 
                        nuevaFila["Sueldo"] = sueldo; // Asignar sueldo
                        nuevaFila["Garantia"] = garantia;

                        dt.Rows.Add(nuevaFila);
                        dataGridView1.Refresh();

                        // *** Calcular TasaInteres DESPUÉS de que se agrega la fila ***
                       // dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;

                        // Suscribir eventos (CellValidating y CellValueChanged)
                        dataGridView1.CellValidating += dataGridView1_CellValidating;
                        dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void DataGridView1_DataBindingComplete(object sender, EventArgs e)
        {
            dataGridView1.DataBindingComplete -= DataGridView1_DataBindingComplete; // Desuscribir el evento

            if (dataGridView1.Rows.Count > 0)
            {
                int plazoMeses = Convert.ToInt32(dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["PlazoMeses"].Value);
                decimal tasaInteres = CalcularTasaInteres(plazoMeses);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["TasaInteres"].Value = tasaInteres;
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Validar PlazoMeses
            if (e.ColumnIndex == dataGridView1.Columns["PlazoMeses"].Index)
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                    MessageBox.Show("El plazo de meses no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(e.FormattedValue.ToString(), out int plazoMeses))
                {
                    e.Cancel = true;
                    MessageBox.Show("El plazo de meses debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (plazoMeses < 1)
                {
                    e.Cancel = true;
                    MessageBox.Show("El plazo de meses debe ser mayor o igual a 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Validar Monto
            if (e.ColumnIndex == dataGridView1.Columns["Monto"].Index)
            {
                int montoPrestamo;
                if (int.TryParse(e.FormattedValue.ToString(), out montoPrestamo))
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["Sueldo"].Value == DBNull.Value) return; // Salir si Sueldo es DBNull
                    int sueldo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Sueldo"].Value);

                    if (montoPrestamo > sueldo * 4)
                    {
                        e.Cancel = true;
                        MessageBox.Show($"El monto del préstamo no puede ser superior a 4 veces el sueldo del cliente. Monto Max: {sueldo * 4} (Sueldo: {sueldo}).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Monto del préstamo no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["PlazoMeses"].Index && e.RowIndex >= 0)
            {
                try
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells["PlazoMeses"].Value == DBNull.Value) return; // Evitar error si la celda está vacía

                    int plazoMeses = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PlazoMeses"].Value);
                    decimal tasaInteres = CalcularTasaInteres(plazoMeses);
                    dataGridView1.Rows[e.RowIndex].Cells["TasaInteres"].Value = tasaInteres;
                }
                catch (Exception)
                {
                    // Manejar errores de conversión
                }
            }
        }

        private decimal CalcularTasaInteres(int plazoMeses)
        {
            if (plazoMeses >= 1 && plazoMeses <= 3)
            {
                return 10;
            }
            else if (plazoMeses >= 4 && plazoMeses <= 6)
            {
                return 8;
            }
            else if (plazoMeses >= 7 && plazoMeses <= 12)
            {
                return 7;
            }
            else if (plazoMeses > 12)
            {
                return 5;
            }
            else
            {
                throw new ArgumentException("Plazo de meses inválido."); // Manejo de error para plazos negativos o cero.
            }
        }
       

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormularioPrestamos formularioPrestamos = new FormularioPrestamos();
            formularioPrestamos.Show();
            this.Close();

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


    }
}