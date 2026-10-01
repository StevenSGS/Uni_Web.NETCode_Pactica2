using System.ComponentModel.DataAnnotations;

namespace NuevaVida.Validations;

public class ValidarPrecioAtributo : ValidationAttribute
{
    protected override ValidationResult? IsValid(
        object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult(" 🛈  El precio unitario es obligatorio.");
        }

        if (!decimal.TryParse(value.ToString(), out decimal precio))
        {
            return new ValidationResult(" 🛈  El precio unitario debe ser un número válido.");
        }

        if (precio < 0 || precio > 1000000)
        {
            return new ValidationResult(" 🛈  El precio unitario debe estar entre 0 y 1,000,000.");
        }

        return ValidationResult.Success;
    }
}
