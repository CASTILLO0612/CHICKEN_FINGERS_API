namespace CHICKEN_FINGERS.Dto
{
    public class ProductoUpdateDto
    {
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public int IdCategoria { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
