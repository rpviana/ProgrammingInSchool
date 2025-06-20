using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Loja.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public int Nif { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [Phone]
        public int Telefone { get; set; }

        public bool Ativo { get; set; } = true;

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        [Required]
        public int MoradaClienteId { get; set; }

        [ForeignKey("MoradaClienteId")]
        [JsonIgnore]
        [SwaggerIgnore]
        public virtual MoradaCliente? MoradaCliente { get; set; }
    }
}
