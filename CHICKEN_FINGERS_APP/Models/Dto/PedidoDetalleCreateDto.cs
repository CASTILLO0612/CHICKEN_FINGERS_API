namespace CHICKEN_FINGERS.Dto
{
    public class PedidoDetalleCreateDto
    {
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
