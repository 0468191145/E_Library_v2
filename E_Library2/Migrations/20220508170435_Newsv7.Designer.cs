﻿// <auto-generated />
using System;
using E_Library2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Library2.Migrations
{
    [DbContext(typeof(E_Library2Context))]
    [Migration("20220508170435_Newsv7")]
    partial class Newsv7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Libary.Models.BaiGiang_TaiNguyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChuDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("KichThuoc")
                        .HasColumnType("float");

                    b.Property<string>("LoaiFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaMon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayChinhSuaCuoi")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiChinhSua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PhanLoai")
                        .HasColumnType("bit");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BaiGiang_TaiNguyen");
                });

            modelBuilder.Entity("E_Libary.Models.DeThi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhThuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MonHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayThi")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiPheDuyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NguoiTao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PheDuyet")
                        .HasColumnType("bit");

                    b.Property<string>("TenDeThi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ThoiLuong")
                        .HasColumnType("int");

                    b.Property<bool?>("TinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DeThi");
                });

            modelBuilder.Entity("E_Libary.Models.HeThongThuVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaChiTruyCap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HieuTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoaiTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NgonNgu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NienKhoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SĐT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenThuVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HeThongThuVien");
                });

            modelBuilder.Entity("E_Libary.Models.LopHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaLop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLop")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("E_Libary.Models.TepRieng", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("KichThuoc")
                        .HasColumnType("float");

                    b.Property<DateTime?>("NgaySuaLanCuoi")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiSua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TepRieng");
                });

            modelBuilder.Entity("E_Libary.Models.ThongBao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChuDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNguoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayThongBao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhanLoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ThongBao");
                });

            modelBuilder.Entity("E_Libary.Models.TroGiup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("NgayGui")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiGui")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TroGiup");
                });
#pragma warning restore 612, 618
        }
    }
}
