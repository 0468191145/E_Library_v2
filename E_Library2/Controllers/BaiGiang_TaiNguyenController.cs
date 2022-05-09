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
    public class BaiGiang_TaiNguyenController : ControllerBase
    {
        private readonly E_Library2Context _context;

        public BaiGiang_TaiNguyenController(E_Library2Context context)
        {
            _context = context;
        }

        // GET: api/BaiGiang_TaiNguyen

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BaiGiang_TaiNguyen>>> BaiGiang_TaiNguyen(bool phanloai)
        {
            if (phanloai == true)
            {
                return await _context.BaiGiang_TaiNguyen.Where(n=>n.PhanLoai==true).ToListAsync();
            }
            else
            {
                return await _context.BaiGiang_TaiNguyen.Where(n => n.PhanLoai == false).ToListAsync();
            }
        }

        // GET: api/BaiGiang_TaiNguyen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BaiGiang_TaiNguyen>> GetBaiGiang_TaiNguyen(int id)
        {
            var baiGiang_TaiNguyen = await _context.BaiGiang_TaiNguyen.FindAsync(id);

            if (baiGiang_TaiNguyen == null)
            {
                return NotFound();
            }

            return baiGiang_TaiNguyen;
        }

        // PUT: api/BaiGiang_TaiNguyen/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBaiGiang_TaiNguyen(int id, BaiGiang_TaiNguyen baiGiang_TaiNguyen)
        {
            try
            {
                if (!BaiGiang_TaiNguyenExists(id))
            {
                return NotFound();
            }

                BaiGiang_TaiNguyen put = await _context.BaiGiang_TaiNguyen.FindAsync(id);
                put.ChuDe = baiGiang_TaiNguyen.ChuDe;
                put.KichThuoc = baiGiang_TaiNguyen.KichThuoc;
                put.NgayChinhSuaCuoi = DateTime.Now;
                put.NguoiChinhSua = baiGiang_TaiNguyen.NguoiChinhSua;
                put.Ten = baiGiang_TaiNguyen.Ten;
           
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest("Error");
            }

            return Ok("Cập nhật thành công");
        }
        //Thêm Bài giảng Tài nguyên vào môn học
        public async Task<IActionResult> PutBaiGiang_TaiNguyen(int id,string ten=null, string mon=null)
        {
            try
            {
                if (!BaiGiang_TaiNguyenExists(id))
                {
                    return NotFound();
                }

                BaiGiang_TaiNguyen put = await _context.BaiGiang_TaiNguyen.FindAsync(id);
                put.MaMon = mon==null?put.MaMon:mon;
                put.Ten = ten == null ? put.Ten : ten;
                put.NgayChinhSuaCuoi = DateTime.Now;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest("Error");
            }

            return Ok("Cập nhật thành công");
        }

        //Đổi tên bài giảng tài nguyên

        // POST: api/BaiGiang_TaiNguyen
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BaiGiang_TaiNguyen>> PostBaiGiang_TaiNguyen(bool phanloai,BaiGiang_TaiNguyen baiGiang_TaiNguyen)
        {
            baiGiang_TaiNguyen.PhanLoai = phanloai;
            baiGiang_TaiNguyen.NgayChinhSuaCuoi = DateTime.Now;
            _context.BaiGiang_TaiNguyen.Add(baiGiang_TaiNguyen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBaiGiang_TaiNguyen", new { id = baiGiang_TaiNguyen.Id }, baiGiang_TaiNguyen);
        }

        // DELETE: api/BaiGiang_TaiNguyen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBaiGiang_TaiNguyen(int id)
        {
            var baiGiang_TaiNguyen = await _context.BaiGiang_TaiNguyen.FindAsync(id);
            if (baiGiang_TaiNguyen == null)
            {
                return NotFound();
            }

            _context.BaiGiang_TaiNguyen.Remove(baiGiang_TaiNguyen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BaiGiang_TaiNguyenExists(int id)
        {
            return _context.BaiGiang_TaiNguyen.Any(e => e.Id == id);
        }
    }
}
