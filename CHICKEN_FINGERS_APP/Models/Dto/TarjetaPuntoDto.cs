using System.ComponentModel.DataAnnotations;

namespace CHICKEN_FINGERS.Dto
{
    public class TarjetaPuntoDto
    {
        public int IdTarjetaPunto { get; set; }
        public string CodigoTarjeta { get; set; }
        public int IdCliente { get; set; }
        public decimal PuntosAcumulados { get; set; }
    }
}
