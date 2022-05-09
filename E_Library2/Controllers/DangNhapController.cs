using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using E_Libary.Models;
using E_Library2.Data;
using E_Library2.Mail;
using System.Net.Mail;

namespace E_Library2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangNhapController : ControllerBase
    {
        private readonly E_Library2Context _context;
        private SmtpClient client = new SmtpClient("smtp.gmail.com");
        private string _from = "ptai22092001@gmail.com";
        private string _to = "ptai22092001@gmail.com";
        private string _subject = "Mã xác thực ";
        private string _body = "Mã xác thực của bạn là ";

        public DangNhapController(E_Library2Context context)
        {
            _context = context;
        }

        // GET: api/DangNhap
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaiKhoan>>> GetTaiKhoan()
        {
            return await _context.TaiKhoan.ToListAsync();
        }

        public async Task<ActionResult<TaiKhoan>> GetTaiKhoan(string username, string password)
        {
            var taiKhoan = await _context.TaiKhoan.SingleOrDefaultAsync(n=>n.UserName==username&&n.PassWord==password);

            if (taiKhoan == null)
            {
                return NotFound();
            }

            return taiKhoan;
        }

        // PUT: api/DangNhap/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaiKhoan(int id, TaiKhoan taiKhoan)
        {
            if (id != taiKhoan.Id)
            {
                return BadRequest();
            }

            _context.Entry(taiKhoan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaiKhoanExists(id))
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

        // POST: api/DangNhap
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaiKhoan>> PostTaiKhoan(TaiKhoan taiKhoan)
        {
            _context.TaiKhoan.Add(taiKhoan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTaiKhoan", new { id = taiKhoan.Id }, taiKhoan);
        }
        public async Task<string> PostTaiKhoan(string username)
        {
            if(_context.TaiKhoan.SingleOrDefault(n=>n.UserName==username)!=null)
            {
                Random rd = new Random();
                string code = "";
                for (int i = 0; i < 6; i++)
                {
                    code += rd.Next(9);
                }
                _body += code;
            }
            else
                return "Không tìm thấy tài khoản";
            try
            {
                var message = await MailUtils.SendMail(_from, _to, _subject, _body);
                return message ;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // DELETE: api/DangNhap/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaiKhoan(int id)
        {
            var taiKhoan = await _context.TaiKhoan.FindAsync(id);
            if (taiKhoan == null)
            {
                return NotFound();
            }

            _context.TaiKhoan.Remove(taiKhoan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaiKhoanExists(int id)
        {
            return _context.TaiKhoan.Any(e => e.Id == id);
        }
    }
}
