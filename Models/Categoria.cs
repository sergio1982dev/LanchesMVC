using System.ComponentModel.DataAnnotations;

namespace LanchesMVC.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [StringLength(50,ErrorMessage ="Máximo de 50 caracteres")]
        public string? CategoriaNome { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [StringLength(200, ErrorMessage ="Máximo 200 caracteres")]
        public string? Descricao { get; set; }

        public List<Lanche>? Lanches { get; set; }
    }
}
