namespace CHICKEN_FINGERS.Dto
{
    public class ClienteDto
    {
        public int IdCliente { get; set; }
        public string PNombre { get; set; } = string.Empty;
        public string? SNombre { get; set; }
        public string PApellido { get; set; } = string.Empty;
        public string? SApellido { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public DateTime? Fecha_Registro { get; set; }
    }
}
