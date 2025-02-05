using System;

public class Entidades
{
	public Entidades()
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
        public string CantidadMoras { get; set; }

    }

    public class Prestamos
    {
        public int PrestamosId { get; set; }
        public int ClienteId { get; set; }
        public int Monto { get; set; }
        public int PlazoMeses { get; set; }
        public int TasaIntereses { get; set; }
        
    }

    public class Pagos
    {
        public int PagosId { get; set; }
        public int ClienteId { get; set; }
        public int PrestamosId { get; set; }
        public int FechaPago { get; set; }
        public int MontoAnterior { get; set; }
        public int InteresPagado { get; set; }
        public int MontoPagado { get; set; }
        public int NuevoMonto { get; set; }

    }

    public class Moras
    {
        public int MorasId { get; set; }
        public int PrestamosId { get; set; }
        public int FechaMora { get; set; }
        public int MontoMora { get; set; }

    }
}
}
