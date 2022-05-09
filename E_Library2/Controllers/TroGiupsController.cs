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
    public class TroGiupsController : ControllerBase
    {
        private readonly E_Library2Context _context;

        public TroGiupsController(E_Library2Context context)
        {
            _context = context;
        }

        // GET: api/TroGiups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TroGiup>>> GetTroGiup()
        {
            return await _context.TroGiup.ToListAsync();
        }

        // GET: api/TroGiups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TroGiup>> GetTroGiup(int id)
        {
            var troGiup = await _context.TroGiup.FindAsync(id);

            if (troGiup == null)
            {
                return NotFound();
            }

            return troGiup;
        }

        //// PUT: api/TroGiups/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTroGiup(int id, TroGiup troGiup)
        //{
        //    if (id != troGiup.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(troGiup).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TroGiupExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/TroGiups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TroGiup>> PostTroGiup(TroGiup troGiup)
        {
            _context.TroGiup.Add(troGiup);
            troGiup.NgayGui = DateTime.Now;
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetTroGiup", new { id = troGiup.Id }, troGiup);
        }

        // DELETE: api/TroGiups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTroGiup(int id)
        {
            try
            {
                var troGiup = await _context.TroGiup.FindAsync(id);
                if (troGiup == null)
                {
                    return NotFound("Không tìm thấy");
                }

                _context.TroGiup.Remove(troGiup);
                await _context.SaveChangesAsync();

                return Ok("Xóa thành công");
            }catch(Exception ex)
            {
                return BadRequest("Error");
            }
        }

        private bool TroGiupExists(int id)
        {
            return _context.TroGiup.Any(e => e.Id == id);
        }
    }
}
