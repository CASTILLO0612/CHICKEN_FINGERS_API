namespace CHICKEN_FINGERS.Dto
{
    public class PedidoCreateDto
    {
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }= DateTime.UtcNow;
    }
}
