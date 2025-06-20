using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Loja.Data;
using Loja.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Loja.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]

    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            var res = await _context.Produtos.Include(p => p.CategoriaProduto).ToListAsync();
            return res;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await _context.Produtos.Include(p => p.CategoriaProduto).FirstOrDefaultAsync(p => p.Id == id);

            if (produto == null) return NotFound();

            return produto;
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> CreateProduto([FromBody] Produto produto)
        {
            var categoria = await _context.CategoriaProdutos.FindAsync(produto.CategoriaProdutoId);
            if (categoria == null)
            {
                return BadRequest("Categoria não encontrada.");
            }

            produto.CategoriaProduto = categoria;

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduto(int id, [FromBody] Produto produto)
        {
            if (id != produto.Id) return BadRequest();

            var categoria = await _context.CategoriaProdutos.FindAsync(produto.CategoriaProdutoId);
            if (categoria == null)
            {
                return BadRequest("Categoria não encontrada.");
            }

            produto.CategoriaProduto = categoria;

            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null) return NotFound();

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
