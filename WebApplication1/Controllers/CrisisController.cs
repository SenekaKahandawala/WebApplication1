using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public class CrisisController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CrisisController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crisis>>> GetCrises()
        {
            return await _context.Crises.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Crisis>> GetCrisis(int id)
        {
            var crisis = await _context.Crises.FindAsync(id);
            if (crisis == null) return NotFound();
            return crisis;
        }

        [HttpPost]
        public async Task<ActionResult<Crisis>> PostCrisis(Crisis crisis)
        {
            _context.Crises.Add(crisis);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCrises), new { id = crisis.Id }, crisis);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCrisis(int id, Crisis crisis)
        {
            if (id != crisis.Id) return BadRequest();
            _context.Entry(crisis).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Crises.Any(e => e.Id == id)) return NotFound();
                else throw;
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCrisis(int id)
        {
            var crisis = await _context.Crises.FindAsync(id);
            if (crisis == null) return NotFound();
            _context.Crises.Remove(crisis);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
