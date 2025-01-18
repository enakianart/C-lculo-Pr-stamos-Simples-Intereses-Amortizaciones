using System;
using System.Data.SqlClient;
using System.Net;

public class Class1
{
	public void conectar()
	{
        try
        {
            string nombre_servidor = Dns.GetHostName();
            string connectionString = "Data Source=" + nombre_servidor + "\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;Trust Server Certificate=True";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
       // string connectionString = "Data Source="+ nombre_servidor+ "\\SQLEXPRESS;Initial Catalog=db_prestamos;Integrated Security=True;Trust Server Certificate=True";
    