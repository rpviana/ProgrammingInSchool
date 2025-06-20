using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Loja.Models
{
    public class CategoriaProduto
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        public bool Ativo { get; set; } 

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime? DataAlteracao { get; set; }  

        [JsonIgnore]
        [SwaggerIgnore]
        public virtual ICollection<Produto>? Produtos { get; set; } = new List<Produto>();
    }
}
