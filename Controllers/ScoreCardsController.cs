using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScoreCardPlus;
using ScoreCardPlus.Models;

namespace ScoreCardPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreCardsController : ControllerBase
    {
        private readonly ScoreCardDBContext _context;

        public ScoreCardsController(ScoreCardDBContext context)
        {
            _context = context;
        }

        // GET: api/ScoreCards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScoreCard>>> GetScoreCards()
        {
          if (_context.ScoreCards == null)
          {
              return NotFound();
          }
            return await _context.ScoreCards.ToListAsync();
        }

        // GET: api/ScoreCards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ScoreCard>> GetScoreCard(Guid id)
        {
          if (_context.ScoreCards == null)
          {
              return NotFound();
          }
            var scoreCard = await _context.ScoreCards.FindAsync(id);

            if (scoreCard == null)
            {
                return NotFound();
            }

            return scoreCard;
        }

        // PUT: api/ScoreCards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScoreCard(Guid id, ScoreCard scoreCard)
        {
            if (id != scoreCard.ID)
            {
                return BadRequest();
            }

            _context.Entry(scoreCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreCardExists(id))
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

        // POST: api/ScoreCards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ScoreCard>> PostScoreCard(ScoreCard scoreCard)
        {
          if (_context.ScoreCards == null)
          {
              return Problem("Entity set 'ScoreCardDBContext.ScoreCards'  is null.");
          }
            _context.ScoreCards.Add(scoreCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScoreCard", new { id = scoreCard.ID }, scoreCard);
        }

        // DELETE: api/ScoreCards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScoreCard(Guid id)
        {
            if (_context.ScoreCards == null)
            {
                return NotFound();
            }
            var scoreCard = await _context.ScoreCards.FindAsync(id);
            if (scoreCard == null)
            {
                return NotFound();
            }

            _context.ScoreCards.Remove(scoreCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScoreCardExists(Guid id)
        {
            return (_context.ScoreCards?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
