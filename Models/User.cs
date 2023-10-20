#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

public class User
{
    [Required]
    [MinLength(4, ErrorMessage = "Minimo 4 caracteres")]
    public string Nombre { get; set; }
    [Required]
    [MinLength(4, ErrorMessage = "Minimo 4 caracteres")]

    public string Apellido { get; set; }
    [Required]
    [MayorAUno]
    public int Edad { get; set; }
    [Required]
    [EmailAddress(ErrorMessage = "Debe ser formato correo")]
    public string Email { get; set; }
    [Required]
        [MinLength(8, ErrorMessage = "Minimo 8 caracteres")]

    public string Password { get; set; }
}

public class MayorAUno : ValidationAttribute
{
  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        int edad = (int)value;
        if (edad <= 0)
        {
            return new ValidationResult("El numero debe ser positivo");
        } else {
            return ValidationResult.Success;
        }
    }
}