using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CHICKEN_FINGERS.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        [Required, StringLength(25)]
        public string PNombre { get; set; } = string.Empty;

        [StringLength(25)]
        public string? SNombre { get; set; }

        [Required, StringLength(25)]
        public string PApellido { get; set; } = string.Empty;

        [StringLength(25)]
        public string? SApellido { get; set; }

        [StringLength(15)]
        public string? Telefono { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        [Required, StringLength(100), NotNull]
        public string Cedula { get; set; }
        [Required, StringLength(100), NotNull]
        public string Estado { get; set; }

        public DateTime? Fecha_Registro { get; set; }
    }
}
