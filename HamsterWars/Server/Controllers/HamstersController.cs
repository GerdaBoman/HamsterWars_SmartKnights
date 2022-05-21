using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using HamsterWars.Shared.Models;
using DataAccess.Data;

namespace HamsterWars.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        private readonly HamsterWarsContext _context;

        public HamstersController(HamsterWarsContext context)
        {
            _context = context;
        }

        // GET: api/Hamsters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hamster>>> GetHamster()
        {
          if (_context.Hamster == null)
          {
              return NotFound();
          }
            var hamsters= await _context.Hamster.ToListAsync();
            return Ok(hamsters);
            
        }

        // GET: api/Hamsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hamster>> GetHamster(int id)
        {
          if (_context.Hamster == null)
          {
              return NotFound("No hamsters available!");
          }
            var hamster = await _context.Hamster.FirstOrDefaultAsync(h=> h.Id ==id);

            if (hamster == null)
            {
                return NotFound("No hamster found!");
            }

            return Ok(hamster);
        }

        // GET: api/Hamsters/random
        [HttpGet("random")]
       
        public async Task<ActionResult<Hamster>> GetHamsterRandom()
        {
         var total = await _context.Hamster.CountAsync();
         Random random = new Random();
         var id = random.Next(1,total);
           

          if (_context.Hamster == null)
          {
              return NotFound();
          }
            var hamster = await _context.Hamster.FindAsync(id);

            if (hamster == null)
            {
                return NotFound();
            }

            return hamster;
        }

        // PUT: api/Hamsters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHamster(int id, Hamster hamster)
        {
            if (id != hamster.Id)
            {
                return BadRequest();
            }

            _context.Entry(hamster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HamsterExists(id))
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

        // POST: api/Hamsters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hamster>> PostHamster(Hamster hamster)
        {
          if (_context.Hamster == null)
          {
              return Problem("Entity set 'HamsterWarsContext.Hamster'  is null.");
          }
            _context.Hamster.Add(hamster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHamster", new { id = hamster.Id }, hamster);
        }

        // DELETE: api/Hamsters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHamster(int id)
        {
            if (_context.Hamster == null)
            {
                return NotFound();
            }
            var hamster = await _context.Hamster.FindAsync(id);
            if (hamster == null)
            {
                return NotFound();
            }

            _context.Hamster.Remove(hamster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HamsterExists(int id)
        {
            return (_context.Hamster?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
