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
    public class MoradaClienteController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MoradaClienteController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MoradaCliente>>> GetMoradasClientes()
        {
            return await _context.MoradasClientes
                                 .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MoradaCliente>> GetMoradaCliente(int id)
        {
            var moradaCliente = await _context.MoradasClientes
                                              .FirstOrDefaultAsync(m => m.Id == id);

            if (moradaCliente == null) return NotFound();

            return moradaCliente;
        }

        [HttpPost]
        public async Task<ActionResult<MoradaCliente>> CreateMoradaCliente([FromBody] MoradaCliente moradaCliente)
        {
            _context.MoradasClientes.Add(moradaCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMoradaCliente), new { id = moradaCliente.Id }, moradaCliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMoradaCliente(int id, [FromBody] MoradaCliente moradaCliente)
        {
            if (id != moradaCliente.Id) return BadRequest();

            _context.Entry(moradaCliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoradaCliente(int id)
        {
            var moradaCliente = await _context.MoradasClientes.FindAsync(id);

            if (moradaCliente == null) return NotFound();

            _context.MoradasClientes.Remove(moradaCliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
