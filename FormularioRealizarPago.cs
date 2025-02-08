﻿using System;
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
    public partial class FormularioRealizarPago : Form
    {

        SqlDataAdapter sda;
        //DataGridView dgv;
        SqlCommandBuilder scb;

        DataTable dt;
        string nombre_servidor = Dns.GetHostName();
        public string conectar = "Data Source=ENZOACER\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;";

        public FormularioRealizarPago()
        {
            InitializeComponent();
            dt = new DataTable();

        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            string buscar = BuscarTXT.Text;

            // Limpiar los labels antes de realizar una nueva búsqueda
            MontoAnteriorLABEL.Text = "";
            MontoActualLABEL.Text = "";
            CuotaLABEL.Text = "";
            FechaPagoLABEL.Text = "";

            using (SqlConnection conexion = new SqlConnection(conectar))
            {
                conexion.Open();

                // Consulta para obtener los datos del cliente, préstamo y pagos
                string consulta = $@"
            SELECT 
                p.ClientesId,
                p.PrestamosId,
                p.Monto AS MontoPrestamo,
                p.PlazoMeses,
                p.TasaInteres,  
                pag.PagosId,
                pag.FechaPago,
                pag.MontoAnterior,
                pag.InteresPagado,
                pag.MontoPagado AS Cuota,
                pag.NuevoMonto
            FROM Prestamos p
            INNER JOIN Clientes c ON p.ClientesId = c.ClientesId
            LEFT JOIN Pagos pag ON p.PrestamosId = pag.PrestamosId AND c.ClientesId = pag.ClientesId
            WHERE c.Nombre LIKE '{buscar}%' AND c.ClientesId = (SELECT ClientesId FROM Clientes WHERE Nombre LIKE '{buscar}%')
        ";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tablaprestamos = new DataTable();
                adaptador.Fill(tablaprestamos);
                dataGridView1.DataSource = tablaprestamos;

                if (tablaprestamos.Rows.Count == 0)
                {
                    MessageBox.Show($"No se encontró ningún cliente con el nombre '{buscar}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Salir del método para evitar errores
                }

                // Si se encuentra el cliente, continuar con el procesamiento de los datos
                foreach (DataRow row in tablaprestamos.Rows)
                {
                    int plazoMeses = Convert.ToInt32(row["PlazoMeses"]);
                    decimal montoPrestamo = Convert.ToDecimal(row["MontoPrestamo"]);
                    decimal tasaInteresMensual = Convert.ToDecimal(row["TasaInteres"]);

                    tasaInteresMensual = tasaInteresMensual / 100;

                    // Calcular la cuota mensual
                    decimal interesMensual = Math.Round(montoPrestamo * (tasaInteresMensual / plazoMeses));
                    decimal cuotaCapital = Math.Round((decimal)montoPrestamo / plazoMeses);
                    decimal cuota = interesMensual + cuotaCapital;

                    // Mostrar la cuota en el label correspondiente
                    CuotaLABEL.Text = cuota.ToString();
                    InteresLABEL.Text = interesMensual.ToString();


                    // Obtener el monto anterior del préstamo
                    if (row["MontoAnterior"] != DBNull.Value)
                    {
                        MontoAnteriorLABEL.Text = Convert.ToDecimal(row["MontoAnterior"]).ToString();
                        // Calcular el monto actual restando la cuota
                        MontoActualLABEL.Text = (Convert.ToDecimal(row["MontoAnterior"]) - cuota).ToString();
                    }
                    else
                    {
                        MontoAnteriorLABEL.Text = montoPrestamo.ToString(); // Mostrar el monto original si no hay pagos
                        MontoActualLABEL.Text = (montoPrestamo - cuota).ToString();
                    }

                    // Obtener y mostrar la fecha de pago
                    if (row["FechaPago"] != DBNull.Value)
                    {
                        DateTime fechaPago = Convert.ToDateTime(row["FechaPago"]);
                        FechaPagoLABEL.Text = fechaPago.AddDays(30).ToString("dd/MM/yyyy"); // Sumar 30 días
                    }
                    else
                    {
                        FechaPagoLABEL.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Fecha actual si no hay pagos
                    }

                    // Detener el bucle foreach una vez que se encuentra el préstamo del cliente buscado
                    break;
                }

                // ... (resto del código para configurar el DataGridView)
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRow filaSeleccionada = ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem).Row;
                ActualizarLabels(filaSeleccionada); // Llamar a ActualizarLabels al seleccionar una fila
            }
        }

        private void ActualizarLabels(DataRow row)
        {
            int plazoMeses = Convert.ToInt32(row["PlazoMeses"]);
            decimal montoPrestamo = Convert.ToDecimal(row["MontoPrestamo"]);
            decimal tasaInteresMensual = Convert.ToDecimal(row["TasaInteres"]);

            tasaInteresMensual = tasaInteresMensual / 100;

            // Calcular la cuota mensual
            decimal interesMensual = Math.Round(montoPrestamo * (tasaInteresMensual / plazoMeses));
            decimal cuotaCapital = Math.Round((decimal)montoPrestamo / plazoMeses);
            decimal cuota = interesMensual + cuotaCapital;

            // Mostrar la cuota en el label correspondiente
            CuotaLABEL.Text = cuota.ToString();
            InteresLABEL.Text = interesMensual.ToString();


            // Obtener el monto anterior del préstamo
            if (row["MontoAnterior"] != DBNull.Value)
            {
                MontoAnteriorLABEL.Text = Convert.ToDecimal(row["MontoAnterior"]).ToString();
                // Calcular el monto actual restando la cuota
                MontoActualLABEL.Text = (Convert.ToDecimal(row["MontoAnterior"]) - cuota).ToString();
            }
            else
            {
                MontoAnteriorLABEL.Text = montoPrestamo.ToString(); // Mostrar el monto original si no hay pagos
                MontoActualLABEL.Text = (montoPrestamo - cuota).ToString();
            }

            // Obtener y mostrar la fecha de pago
            if (row["FechaPago"] != DBNull.Value)
            {
                DateTime fechaPago = Convert.ToDateTime(row["FechaPago"]);
                FechaPagoLABEL.Text = fechaPago.AddDays(30).ToString("dd/MM/yyyy"); // Sumar 30 días
            }
            else
            {
                FechaPagoLABEL.Text = DateTime.Now.ToString("dd/MM/yyyy"); // Fecha actual si no hay pagos
            }
        
    }

        private void PagarBTN_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener los datos de la fila seleccionada
                DataRowView rowView = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                int prestamosId = Convert.ToInt32(rowView["PrestamosId"]);
                int clientesId = Convert.ToInt32(rowView["ClientesId"]);
                decimal montoPrestamo = Convert.ToDecimal(rowView["MontoPrestamo"]);
                int plazoMeses = Convert.ToInt32(rowView["PlazoMeses"]);
                decimal tasaInteres = Convert.ToDecimal(rowView["TasaInteres"]);
                DateTime fechaPago = DateTime.Now;

                // Calcular el interés mensual y la cuota
                tasaInteres = tasaInteres / 100;
                decimal interesMensual = Math.Round(montoPrestamo * (tasaInteres / plazoMeses), 2); // Redondear a 2 decimales
                decimal cuotaCapital = Math.Round((decimal)montoPrestamo / plazoMeses, 2); // Redondear a 2 decimales
                decimal cuota = interesMensual + cuotaCapital;

                // Obtener el monto anterior del préstamo
                decimal montoAnterior = montoPrestamo; // Monto inicial si no hay pagos anteriores
                if (rowView["MontoAnterior"] != DBNull.Value)
                {
                    montoAnterior = Convert.ToDecimal(rowView["MontoAnterior"]);
                }

                // Calcular el nuevo monto del préstamo
                decimal nuevoMonto = montoAnterior - cuota;

                // Insertar el pago en la base de datos
                using (SqlConnection conexion = new SqlConnection(conectar))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Pagos (PrestamosId, ClientesId, FechaPago, MontoAnterior, InteresPagado, MontoPagado, NuevoMonto) " +
                                       "VALUES (@PrestamosId, @ClientesId, @FechaPago, @MontoAnterior, @InteresPagado, @MontoPagado, @NuevoMonto)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@PrestamosId", prestamosId);
                    comando.Parameters.AddWithValue("@ClientesId", clientesId);
                    comando.Parameters.AddWithValue("@FechaPago", fechaPago);
                    comando.Parameters.AddWithValue("@MontoAnterior", montoAnterior);
                    comando.Parameters.AddWithValue("@InteresPagado", interesMensual);
                    comando.Parameters.AddWithValue("@MontoPagado", cuota);
                    comando.Parameters.AddWithValue("@NuevoMonto", nuevoMonto);
                    comando.ExecuteNonQuery();
                }

                using (SqlConnection conexion = new SqlConnection(conectar))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Pagos (PrestamosId, ClientesId, FechaPago, MontoAnterior, InteresPagado, MontoPagado, NuevoMonto) " +
                                       "VALUES (@PrestamosId, @ClientesId, @FechaPago, @MontoAnterior, @InteresPagado, @MontoPagado, @NuevoMonto)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@PrestamosId", prestamosId);
                    comando.Parameters.AddWithValue("@ClientesId", clientesId);
                    comando.Parameters.AddWithValue("@FechaPago", fechaPago);
                    comando.Parameters.AddWithValue("@MontoAnterior", montoAnterior);
                    comando.Parameters.AddWithValue("@InteresPagado", interesMensual);
                    comando.Parameters.AddWithValue("@MontoPagado", cuota);
                    comando.Parameters.AddWithValue("@NuevoMonto", nuevoMonto);
                    comando.ExecuteNonQuery();

                    // Verificar si se ha completado el pago del préstamo
                    if (nuevoMonto <= 0 || HaAlcanzadoPlazo(prestamosId, plazoMeses))
                    {
                        MessageBox.Show("El préstamo ha sido pagado en su totalidad.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Puedes realizar acciones adicionales aquí, como deshabilitar el botón de pagar o limpiar los campos.
                    }
                }
                // Limpiar los labels y el DataGridView
                MontoAnteriorLABEL.Text = "";
                MontoActualLABEL.Text = "";
                CuotaLABEL.Text = "";
                FechaPagoLABEL.Text = "";
                dataGridView1.DataSource = null;

                MessageBox.Show("Pago realizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para realizar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool HaAlcanzadoPlazo(int prestamosId, int plazoMeses)
        {
            using (SqlConnection conexion = new SqlConnection(conectar))
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Pagos WHERE PrestamosId = @PrestamosId";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@PrestamosId", prestamosId);
                int cantidadPagos = (int)comando.ExecuteScalar();
                return cantidadPagos >= plazoMeses;
            }
        }


        private void UltimoPagoBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay pagos para este cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si se ha seleccionado una fila
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar el último pago realizado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

            // Obtener los datos del último pago
            int prestamosId = Convert.ToInt32(filaSeleccionada.Cells["PrestamosId"].Value);
            int clientesId = Convert.ToInt32(filaSeleccionada.Cells["ClientesId"].Value);
            decimal montoAnterior = Convert.ToDecimal(filaSeleccionada.Cells["NuevoMonto"].Value); // El nuevo monto es el anterior para el siguiente pago
            DateTime fechaPago = Convert.ToDateTime(filaSeleccionada.Cells["FechaPago"].Value);

            // Calcular la cuota (puedes obtenerla de la base de datos o calcularla si la tienes)
            decimal cuota = ObtenerCuota(prestamosId); // Función para obtener la cuota

            // Calcular el nuevo monto
            decimal nuevoMonto = montoAnterior - cuota;

            // Mostrar los datos en los labels
            MontoAnteriorLABEL.Text = montoAnterior.ToString();
            MontoActualLABEL.Text = nuevoMonto.ToString();
            CuotaLABEL.Text = cuota.ToString();
            FechaPagoLABEL.Text = fechaPago.AddDays(30).ToString("dd/MM/yyyy"); // Sumar 30 días a la fecha de pago anterior
        }

        // Función para obtener la cuota de la base de datos
        private decimal ObtenerCuota(int prestamosId)
        {
            using (SqlConnection conexion = new SqlConnection(conectar))
            {
                conexion.Open();
                // Corregir el nombre de la columna a "MontoPagado"
                string consulta = "SELECT MontoPagado FROM Pagos WHERE PrestamosId = @PrestamosId";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@PrestamosId", prestamosId);
                // Asegúrate de que ExecuteScalar() devuelva un valor decimal
                return Convert.ToDecimal(comando.ExecuteScalar());
            }
        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            FormularioPagos formularioPagos = new FormularioPagos();
            formularioPagos.Show();
            this.Close();
        }

        private void NoPagarBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView rowView = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                int prestamosId = Convert.ToInt32(rowView["PrestamosId"]);
                int clientesId = Convert.ToInt32(rowView["ClientesId"]);
                DateTime fechaPago = DateTime.Now;

                // Verificar si los campos obligatorios están llenos
                if (string.IsNullOrEmpty(InteresLABEL.Text) || string.IsNullOrEmpty(MontoAnteriorLABEL.Text) ||
                    string.IsNullOrEmpty(MontoActualLABEL.Text) || string.IsNullOrEmpty(FechaPagoLABEL.Text))
                {
                    MessageBox.Show("Debe llenar todos los campos para registrar el no pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insertar el no pago en la base de datos con MontoPagado como NULL
                using (SqlConnection conexion = new SqlConnection(conectar))
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Pagos (PrestamosId, ClientesId, FechaPago, MontoAnterior, InteresPagado, MontoPagado, NuevoMonto) " +
                                       "VALUES (@PrestamosId, @ClientesId, @FechaPago, @MontoAnterior, @InteresPagado, @MontoPagado, @NuevoMonto)";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@PrestamosId", prestamosId);
                    comando.Parameters.AddWithValue("@ClientesId", clientesId);
                    comando.Parameters.AddWithValue("@FechaPago", fechaPago);
                    comando.Parameters.AddWithValue("@MontoAnterior", Convert.ToDecimal(MontoAnteriorLABEL.Text));
                    comando.Parameters.AddWithValue("@InteresPagado", Convert.ToDecimal(InteresLABEL.Text));
                    comando.Parameters.AddWithValue("@MontoPagado", 0); // Insertar NULL para MontoPagado
                    comando.Parameters.AddWithValue("@NuevoMonto", Convert.ToDecimal(MontoActualLABEL.Text));
                    comando.ExecuteNonQuery();

                    // Actualizar la cantidad de moras en la tabla Clientes
                    string consultaMoras = "UPDATE Clientes SET CantidadMoras = CantidadMoras + 1 WHERE ClientesId = @ClientesId";
                    SqlCommand comandoMoras = new SqlCommand(consultaMoras, conexion);
                    comandoMoras.Parameters.AddWithValue("@ClientesId", clientesId);
                    comandoMoras.ExecuteNonQuery();
                }

                // Limpiar los labels y el DataGridView
                MontoAnteriorLABEL.Text = "";
                MontoActualLABEL.Text = "";
                CuotaLABEL.Text = "";
                FechaPagoLABEL.Text = "";
                dataGridView1.DataSource = null;

                MessageBox.Show("No pago registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para registrar el no pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
