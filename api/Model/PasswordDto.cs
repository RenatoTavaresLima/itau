using System.ComponentModel.DataAnnotations;

namespace itau_teste.Controllers
{
    public class PasswordDto
    {
        
        [Required]
        [RegularExpression(@"(?!.*(.).*\1{1})(?=.*[a-z])(?=.*[A-Z])(?=.*[\d])(?=.*[!@#$%^&*()\-+])[a-zA-Z\d!@#$%^&*()\-+]{9,}", 
         ErrorMessage = "A senha deve conter no mínimo 9 posições (Não pode conter caracteres repetidos), com pelo menos: 1 letra maiúscula, 1 letra minúscula, 1 número e 1 dos seguintes caracteres especiais: !@#$%^&*()-+")]
        public string password { get; set; }
    }
}
