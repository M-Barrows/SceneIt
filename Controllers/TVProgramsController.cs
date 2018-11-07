using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TVTracker.Models;

namespace TVTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVProgramsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TVProgramsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/TVPrograms
        [HttpGet]
        public IEnumerable<TVProgram> GetTVProgram()
        {
            return _context.TVProgram.OrderBy(x => x.Title).ThenByDescending(x => x.Season).ThenByDescending(x=>x.Episode).ToList();
        }

        // GET: api/TVPrograms/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTVProgram([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tVProgram = await _context.TVProgram.FindAsync(id);

            if (tVProgram == null)
            {
                return NotFound();
            }

            return Ok(tVProgram);
        }

        // PUT: api/TVPrograms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTVProgram([FromRoute] int id, [FromBody] TVProgram tVProgram)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tVProgram.Id)
            {
                return BadRequest();
            }

            _context.Entry(tVProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TVProgramExists(id))
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

        // POST: api/TVPrograms
        [HttpPost]
        public async Task<IActionResult> PostTVProgram([FromBody] TVProgram tVProgram)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TVProgram.Add(tVProgram);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTVProgram", new { id = tVProgram.Id }, tVProgram);
        }

        // DELETE: api/TVPrograms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTVProgram([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tVProgram = await _context.TVProgram.FindAsync(id);
            if (tVProgram == null)
            {
                return NotFound();
            }

            _context.TVProgram.Remove(tVProgram);
            await _context.SaveChangesAsync();

            return Ok(tVProgram);
        }

        private bool TVProgramExists(int id)
        {
            return _context.TVProgram.Any(e => e.Id == id);
        }
    }
}