using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NuevaVida.Validations;

namespace NuevaVida.Models
{
    public class Producto
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = " 🛈  El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = " 🛈  El tipo es obligatorio.")]
        public string Tipo { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = " 🛈  La cantidad no puede ser negativa.")]
        public int Cantidad { get; set; }

        [ValidarPrecioAtributo]
        [DisplayName("Precio Unitario")]
        public decimal PrecioUnitario { get; set; }
    }
}
