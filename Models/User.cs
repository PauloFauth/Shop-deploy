using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class User
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Este Campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este Campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este Campo deve conter entre 3 e 60 caracteres")]
        public int UserName { get; set; }

        [Required(ErrorMessage = "Este Campo é obrigatório")]
        [MaxLength(20, ErrorMessage = "Este Campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este Campo deve conter entre 3 e 60 caracteres")]
        public string? Password { get; set; }

        public string? Role { get; set; }
    }
}