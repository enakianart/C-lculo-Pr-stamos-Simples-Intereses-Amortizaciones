using System;

public class Class1
{
	public Class1()
	{

        public class Clientes
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Sueldo { get; set; }
        public string Garantia { get; set; }
        public string Estado { get; set; }

        public ICollection<Prestamo> Prestamos { get; set; }
    }

    public class Prestamo
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        // ... otras propiedades
        public ICollection<Pago> Pagos { get; set; }
    }
    // ... otras clases de entidad

}
}
