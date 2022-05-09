using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using E_Libary.Models;
using E_Library2.Data;

namespace E_Library2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TepRiengsController : ControllerBase
    {
        private readonly E_Library2Context _context;

        public TepRiengsController(E_Library2Context context)
        {
            _context = context;
        }

        // GET: api/TepRiengs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TepRieng>>> GetTepRieng()
        {
            return await _context.TepRieng.ToListAsync();
        }

        // GET: api/TepRiengs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TepRieng>> GetTepRieng(int id)
        {
            var tepRieng = await _context.TepRieng.FindAsync(id);

            if (tepRieng == null)
            {
                return NotFound();
            }

            return tepRieng;
        }

        // PUT: api/TepRiengs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTepRieng(int id, TepRieng tepRieng)
        {
            if (id != tepRieng.Id)
            {
                return BadRequest();
            }

            _context.Entry(tepRieng).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TepRiengExists(id))
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

        // POST: api/TepRiengs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TepRieng>> PostTepRieng(TepRieng tepRieng)
        {
            _context.TepRieng.Add(tepRieng);
            tepRieng.NgaySuaLanCuoi = DateTime.Now;
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTepRieng", new { id = tepRieng.Id }, tepRieng);
        }

        // DELETE: api/TepRiengs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTepRieng(int id)
        {
            var tepRieng = await _context.TepRieng.FindAsync(id);
            if (tepRieng == null)
            {
                return NotFound();
            }

            _context.TepRieng.Remove(tepRieng);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TepRiengExists(int id)
        {
            return _context.TepRieng.Any(e => e.Id == id);
        }
    }
}
