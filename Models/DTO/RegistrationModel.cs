using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string?  Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public string? UserName { get; set; }

        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()@%&]).{6,}$", ErrorMessage ="Minímo de 6 caracteres deve conter 1 Letra Maiúscula, 1 Minúscula, 1 caracter especial")]
         public string? Password { get; set; }

        [Required]
        [Compare("Password")]
        public string? PasswordConfirm { get; set; }
        public string? Role { get; set; }

    }
}
