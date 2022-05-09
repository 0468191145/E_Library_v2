using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Library2.Migrations
{
    public partial class News : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaiGiang_TaiNguyen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhanLoai = table.Column<bool>(type: "bit", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaMon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenMon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuDe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiChinhSua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayChinhSuaCuoi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KichThuoc = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiGiang_TaiNguyen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeThi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiFile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDeThi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhThuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiLuong = table.Column<int>(type: "int", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayThi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: true),
                    PheDuyet = table.Column<bool>(type: "bit", nullable: true),
                    NguoiPheDuyet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeThi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeThongThuVien",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HieuTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenThuVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiTruyCap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SĐT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgonNgu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NienKhoa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeThongThuVien", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaiGiang_TaiNguyen");

            migrationBuilder.DropTable(
                name: "DeThi");

            migrationBuilder.DropTable(
                name: "HeThongThuVien");
        }
    }
}
