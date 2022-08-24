using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Este Campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este Campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este Campo deve conter entre 3 e 60 caracteres")]
        public string? Title { get; set; }

        [MaxLength(1024, ErrorMessage = " Este Campo deve conter no máximo 1024 caracteres")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço de ser maior que zero")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria Inválida")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}