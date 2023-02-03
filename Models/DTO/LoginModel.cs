
using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage = "Minímo de 6 caracteres deve conter 1 Letra Maiúscula, 1 Minúscula, 1 caracter especial")]
        public string? Password { get; set; }

    }
}
