namespace CHICKEN_FINGERS.Dto
{
    public class ReporteClienteDto
    {
        public int IdCliente { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public string Estado { get; set; }
        public string? Telefono { get; set; }
        public int CantidadPedidos { get; set; }
        public decimal TotalComprado { get; set; }
    }
}
