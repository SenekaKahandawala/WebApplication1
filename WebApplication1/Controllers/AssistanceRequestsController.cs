using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistanceRequestsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AssistanceRequestsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AssistanceRequests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssistanceRequest>>> GetAssistanceRequests()
        {
            return await _context.AssistanceRequests.ToListAsync();
        }

        // POST: api/AssistanceRequests
        [HttpPost]
        public async Task<ActionResult<AssistanceRequest>> PostAssistanceRequest(AssistanceRequest request)
        {
            _context.AssistanceRequests.Add(request);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAssistanceRequests), new { id = request.RequestId }, request);
        }
        // PUT: api/AssistanceRequests/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssistanceRequest(int id, AssistanceRequest request)
        {
            if (id != request.RequestId)
            {
                return BadRequest();
            }

            _context.Entry(request).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.AssistanceRequests.Any(e => e.RequestId == id))
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

        // DELETE: api/AssistanceRequests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssistanceRequest(int id)
        {
            var request = await _context.AssistanceRequests.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }

            _context.AssistanceRequests.Remove(request);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
