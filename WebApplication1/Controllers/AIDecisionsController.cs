using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AIDecisionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AIDecisionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AIDecisions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AIDecision>>> GetAIDecisions()
        {
            return await _context.AIDecisions.ToListAsync();
        }

        // POST: api/AIDecisions
        [HttpPost]
        public async Task<ActionResult<AIDecision>> PostAIDecision(AIDecision aiDecision)
        {
            _context.AIDecisions.Add(aiDecision);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAIDecisions), new { id = aiDecision.DecisionId }, aiDecision);
        }
        // PUT: api/AIDecisions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAIDecision(int id, AIDecision aiDecision)
        {
            if (id != aiDecision.DecisionId)
            {
                return BadRequest();
            }

            _context.Entry(aiDecision).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.AIDecisions.Any(e => e.DecisionId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/AIDecisions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAIDecision(int id)
        {
            var aiDecision = await _context.AIDecisions.FindAsync(id);
            if (aiDecision == null)
            {
                return NotFound();
            }

            _context.AIDecisions.Remove(aiDecision);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
