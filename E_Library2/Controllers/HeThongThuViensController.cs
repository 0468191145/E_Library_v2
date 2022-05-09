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
    public class HeThongThuViensController : ControllerBase
    {
        private readonly E_Library2Context _context;

        public HeThongThuViensController(E_Library2Context context)
        {
            _context = context;
        }

        // GET: api/HeThongThuViens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HeThongThuVien>>> GetHeThongThuVien()
        {
            return await _context.HeThongThuVien.ToListAsync();
        }

        // GET: api/HeThongThuViens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HeThongThuVien>> GetHeThongThuVien(int id)
        {
            var heThongThuVien = await _context.HeThongThuVien.FindAsync(id);

            if (heThongThuVien == null)
            {
                return NotFound();
            }

            return heThongThuVien;
        }

        // PUT: api/HeThongThuViens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHeThongThuVien(int id, HeThongThuVien heThongThuVien)
        {
            if (id != heThongThuVien.Id)
            {
                return BadRequest();
            }

            _context.Entry(heThongThuVien).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeThongThuVienExists(id))
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

        // POST: api/HeThongThuViens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HeThongThuVien>> PostHeThongThuVien(HeThongThuVien heThongThuVien)
        {
            _context.HeThongThuVien.Add(heThongThuVien);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHeThongThuVien", new { id = heThongThuVien.Id }, heThongThuVien);
        }

        // DELETE: api/HeThongThuViens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHeThongThuVien(int id)
        {
            var heThongThuVien = await _context.HeThongThuVien.FindAsync(id);
            if (heThongThuVien == null)
            {
                return NotFound();
            }

            _context.HeThongThuVien.Remove(heThongThuVien);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HeThongThuVienExists(int id)
        {
            return _context.HeThongThuVien.Any(e => e.Id == id);
        }
    }
}
