namespace CHICKEN_FINGERS.Dto
{
    public class PedidoDto
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; } = DateTime.UtcNow;
    }
}
