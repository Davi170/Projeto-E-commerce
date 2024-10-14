using System.ComponentModel.DataAnnotations;

namespace RegistroPessoa.Models
{
    public class Usuario
    {
        [Required]
        public string? Nome { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }
    }
}
