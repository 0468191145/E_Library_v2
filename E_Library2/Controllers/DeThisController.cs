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
    public class DeThisController : ControllerBase
    {
        private readonly E_Library2Context _context;

        public DeThisController(E_Library2Context context)
        {
            _context = context;
        }

        // GET: api/DeThis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeThi>>> GetDeThi()
        {
            return await _context.DeThi.ToListAsync();
        }

        // GET: api/DeThis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeThi>> GetDeThi(int id)
        {
            var deThi = await _context.DeThi.FindAsync(id);

            if (deThi == null)
            {
                return NotFound();
            }

            return deThi;
        }

        // PUT: api/DeThis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeThi(int id, DeThi deThi)
        {
            if (id != deThi.Id)
            {
                return BadRequest();
            }

            _context.Entry(deThi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeThiExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok("Cập nhật thành công");
        }

        // POST: api/DeThis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DeThi>> PostDeThi(DeThi deThi)
        {
            deThi.NgayTao = DateTime.Now;
            deThi.TinhTrang = "Chờ phê duyệt";
            _context.DeThi.Add(deThi);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeThi", new { id = deThi.Id }, deThi);
        }
        [HttpPut]
        public async Task<ActionResult<DeThi>> PheDuyet(int id, string ten,string tinhtrang)
        {
            DeThi dethi= await _context.DeThi.FindAsync(id);
            dethi.NguoiPheDuyet = ten;
            dethi.TinhTrang = tinhtrang;
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeThi", new { id = dethi.Id }, dethi);
        }

        // DELETE: api/DeThis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeThi(int id)
        {
            var deThi = await _context.DeThi.FindAsync(id);
            if (deThi == null)
            {
                return NotFound();
            }

            _context.DeThi.Remove(deThi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeThiExists(int id)
        {
            return _context.DeThi.Any(e => e.Id == id);
        }
    }
}
