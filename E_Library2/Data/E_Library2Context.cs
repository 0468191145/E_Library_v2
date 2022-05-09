using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_Libary.Models;

namespace E_Library2.Data
{
    public class E_Library2Context : DbContext
    {
        public E_Library2Context (DbContextOptions<E_Library2Context> options)
            : base(options)
        {
        }

        public DbSet<E_Libary.Models.BaiGiang_TaiNguyen> BaiGiang_TaiNguyen { get; set; }

        public DbSet<E_Libary.Models.DeThi> DeThi { get; set; }

        public DbSet<E_Libary.Models.HeThongThuVien> HeThongThuVien { get; set; }

        public DbSet<E_Libary.Models.TroGiup> TroGiup { get; set; }

        public DbSet<E_Libary.Models.ThongBao> ThongBao { get; set; }

        public DbSet<E_Libary.Models.TepRieng> TepRieng { get; set; }

        public DbSet<E_Libary.Models.LopHoc> LopHoc { get; set; }

        public DbSet<E_Libary.Models.NguoiDung> NguoiDung { get; set; }

        public DbSet<E_Libary.Models.Role> Role { get; set; }
    }
}
