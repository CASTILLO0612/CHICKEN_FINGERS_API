namespace CHICKEN_FINGERS.Dto
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public string IdCategoria { get; set; } = string.Empty;
        public decimal PrecioUnitario { get; set; }

    }
}
