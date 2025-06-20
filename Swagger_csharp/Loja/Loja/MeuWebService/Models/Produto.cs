using Loja.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

public class Produto
{
    [Key]
    public int Id { get; set; }  

    [Required]
    [StringLength(200)]
    public string Titulo { get; set; }  

    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }  

    public bool Ativo { get; set; }  

    // Relacionamento com CategoriaProduto (um produto pertence a uma categoria)
    public int CategoriaProdutoId { get; set; }  // Chave estrangeira para CategoriaProduto

    [ForeignKey("CategoriaProdutoId")]
    [SwaggerIgnore]// o meu brother disse que deixava mais giro
    public virtual CategoriaProduto? CategoriaProduto { get; set; } 
}
