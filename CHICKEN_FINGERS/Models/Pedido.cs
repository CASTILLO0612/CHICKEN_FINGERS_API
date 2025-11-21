using System.ComponentModel.DataAnnotations;

namespace CHICKEN_FINGERS.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; } = DateTime.UtcNow;
    }
}
