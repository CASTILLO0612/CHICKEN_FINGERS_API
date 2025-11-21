using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace CHICKEN_FINGERS.Models
{
    public class TarjetaPunto
    {
        public int IdTarjetaPunto { get; set; }
        [Required, StringLength(10)]
        public string CodigoTarjeta { get; set; }
        public int IdCliente { get; set; }
        public decimal PuntosAcumulados { get; set; }
    }
}
