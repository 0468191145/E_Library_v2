using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Library2.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VaiTro",
                table: "TaiKhoan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaiTro",
                table: "TaiKhoan",
                type: "int",
                nullable: true);
        }
    }
}
