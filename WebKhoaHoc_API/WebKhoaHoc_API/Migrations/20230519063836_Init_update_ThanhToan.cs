using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebKhoaHoc_API.Migrations
{
    public partial class Init_update_ThanhToan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TongTienTT",
                table: "ThanhToan",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TongTienTT",
                table: "ThanhToan");
        }
    }
}
