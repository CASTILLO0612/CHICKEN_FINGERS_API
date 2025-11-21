using System.ComponentModel.DataAnnotations;

namespace CHICKEN_FINGERS.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        [Required, StringLength(50)]
        public string NombreCategoria { get; set; } = string.Empty;
    }
}
