using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebKhoaHoc_API.Migrations
{
    public partial class Init_update_KhoaHoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoNguoiVien",
                table: "KhoaHoc",
                newName: "SoLuong");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "KhoaHoc",
                newName: "SoNguoiVien");
        }
    }
}
