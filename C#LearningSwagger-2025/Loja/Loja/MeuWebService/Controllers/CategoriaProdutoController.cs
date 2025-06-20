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
    public class CategoriaProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriaProdutoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaProduto>>> GetCategorias()
        {
            return await _context.CategoriaProdutos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaProduto>> GetCategoria(int id)
        {
            var categoriaProduto = await _context.CategoriaProdutos
                                                 .Include(c => c.Produtos) 
                                                 .FirstOrDefaultAsync(c => c.Id == id);

            if (categoriaProduto == null)
                return NotFound();

            return categoriaProduto;
        }

        [HttpPost]
        public async Task<ActionResult<CategoriaProduto>> CreateCategoria(CategoriaProduto categoriaProduto)
        {
            _context.CategoriaProdutos.Add(categoriaProduto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategoria), new { id = categoriaProduto.Id }, categoriaProduto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoria(int id, CategoriaProduto categoriaProduto)
        {
            if (id != categoriaProduto.Id)
                return BadRequest();
            categoriaProduto.DataAlteracao = DateTime.Now;
            _context.Entry(categoriaProduto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoria(int id)
        {
            var categoriaProduto = await _context.CategoriaProdutos.FindAsync(id);

            if (categoriaProduto == null)
                return NotFound();

            _context.CategoriaProdutos.Remove(categoriaProduto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
