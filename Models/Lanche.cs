using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMVC.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(80,MinimumLength=5, ErrorMessage ="Mínimo 5 e máximo 80 caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string? DescricaoDetalhada { get; set; }

        [Required]
        [Column(TypeName ="decimal(10, 2)")]
        public decimal Preco { get; set; }

        [StringLength(200, ErrorMessage ="Máximo 200 caracteres")]
        public string? ImagemUrl { get; set; }

        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string? ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }
    }
}
