using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Library2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PheDuyet",
                table: "DeThi");

            migrationBuilder.AlterColumn<string>(
                name: "TinhTrang",
                table: "DeThi",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaNguoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaiTro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.AlterColumn<bool>(
                name: "TinhTrang",
                table: "DeThi",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PheDuyet",
                table: "DeThi",
                type: "bit",
                nullable: true);
        }
    }
}
