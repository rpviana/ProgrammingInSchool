using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Loja.Models
{
    public class MoradaCliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Rua { get; set; }

        [Required]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(10)]
        public string CodigoPostal { get; set; }

        [Required]
        [StringLength(50)]
        public string Pais { get; set; }

        // Relacionamento 1:N com Clientes (um cliente tem uma morada)(nao tava a dar n:n)
        [JsonIgnore]
        [SwaggerIgnore]
        public List<Clientes> Clientes { get; set; } = new List<Clientes>();
    }
}

