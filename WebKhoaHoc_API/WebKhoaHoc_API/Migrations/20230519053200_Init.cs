using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebKhoaHoc_API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiKH",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiKH", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTT",
                columns: table => new
                {
                    MaLTT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLTT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTT", x => x.MaLTT);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    MaTT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayTT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaLTT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => x.MaTT);
                    table.ForeignKey(
                        name: "FK_ThanhToan_LoaiTT_MaLTT",
                        column: x => x.MaLTT,
                        principalTable: "LoaiTT",
                        principalColumn: "MaLTT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    MaGV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChuyenMon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.MaGV);
                    table.ForeignKey(
                        name: "FK_GiangVien_Role_MaRole",
                        column: x => x.MaRole,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    MaND = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenND = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.MaND);
                    table.ForeignKey(
                        name: "FK_NguoiDung_Role_MaRole",
                        column: x => x.MaRole,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuanTriVien",
                columns: table => new
                {
                    MaQTV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenQTV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanTriVien", x => x.MaQTV);
                    table.ForeignKey(
                        name: "FK_QuanTriVien_Role_MaRole",
                        column: x => x.MaRole,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHoc",
                columns: table => new
                {
                    MaKH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoLuongBH = table.Column<int>(type: "int", nullable: true),
                    SoNguoiVien = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<double>(type: "float", nullable: true),
                    MaLoai = table.Column<int>(type: "int", nullable: false),
                    MaGV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHoc", x => x.MaKH);
                    table.ForeignKey(
                        name: "FK_KhoaHoc_GiangVien_MaGV",
                        column: x => x.MaGV,
                        principalTable: "GiangVien",
                        principalColumn: "MaGV",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhoaHoc_LoaiKH_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiKH",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuan",
                columns: table => new
                {
                    MaBL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaND = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuan", x => x.MaBL);
                    table.ForeignKey(
                        name: "FK_BinhLuan_NguoiDung_MaND",
                        column: x => x.MaND,
                        principalTable: "NguoiDung",
                        principalColumn: "MaND",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    MaDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongGiaTri = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NguoiDungMaND = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.MaDH);
                    table.ForeignKey(
                        name: "FK_DonHang_NguoiDung_NguoiDungMaND",
                        column: x => x.NguoiDungMaND,
                        principalTable: "NguoiDung",
                        principalColumn: "MaND",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanHoi",
                columns: table => new
                {
                    MaPH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDungPH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayPH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaND = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanHoi", x => x.MaPH);
                    table.ForeignKey(
                        name: "FK_PhanHoi_NguoiDung_MaND",
                        column: x => x.MaND,
                        principalTable: "NguoiDung",
                        principalColumn: "MaND",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaiHoc",
                columns: table => new
                {
                    MaBH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoiDungBH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiHoc", x => x.MaBH);
                    table.ForeignKey(
                        name: "FK_BaiHoc_KhoaHoc_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhoaHoc",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    MaChat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayGui = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhoaHocMaKH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.MaChat);
                    table.ForeignKey(
                        name: "FK_Chat_KhoaHoc_KhoaHocMaKH",
                        column: x => x.KhoaHocMaKH,
                        principalTable: "KhoaHoc",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChungChi",
                columns: table => new
                {
                    MaCC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    MaND = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChungChi", x => x.MaCC);
                    table.ForeignKey(
                        name: "FK_ChungChi_KhoaHoc_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhoaHoc",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ChungChi_NguoiDung_MaND",
                        column: x => x.MaND,
                        principalTable: "NguoiDung",
                        principalColumn: "MaND",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietBinhLuan",
                columns: table => new
                {
                    MaCTBL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaBL = table.Column<int>(type: "int", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietBinhLuan", x => x.MaCTBL);
                    table.ForeignKey(
                        name: "FK_ChiTietBinhLuan_BinhLuan_MaBL",
                        column: x => x.MaBL,
                        principalTable: "BinhLuan",
                        principalColumn: "MaBL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietBinhLuan_KhoaHoc_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhoaHoc",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDonHang",
                columns: table => new
                {
                    MaCTDH = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDH = table.Column<int>(type: "int", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false),
                    SoLuongKH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDonHang", x => x.MaCTDH);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_DonHang_MaDH",
                        column: x => x.MaDH,
                        principalTable: "DonHang",
                        principalColumn: "MaDH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDonHang_KhoaHoc_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhoaHoc",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BaiTap",
                columns: table => new
                {
                    MaBT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiDungBT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DapAn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diem = table.Column<float>(type: "real", nullable: false),
                    MaBH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiTap", x => x.MaBT);
                    table.ForeignKey(
                        name: "FK_BaiTap_BaiHoc_MaBH",
                        column: x => x.MaBH,
                        principalTable: "BaiHoc",
                        principalColumn: "MaBH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietChat",
                columns: table => new
                {
                    MaCTC = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaND = table.Column<int>(type: "int", nullable: false),
                    MaChat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietChat", x => x.MaCTC);
                    table.ForeignKey(
                        name: "FK_ChiTietChat_Chat_MaChat",
                        column: x => x.MaChat,
                        principalTable: "Chat",
                        principalColumn: "MaChat",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietChat_NguoiDung_MaND",
                        column: x => x.MaND,
                        principalTable: "NguoiDung",
                        principalColumn: "MaND",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaiHoc_MaKH",
                table: "BaiHoc",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_BaiTap_MaBH",
                table: "BaiTap",
                column: "MaBH");

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuan_MaND",
                table: "BinhLuan",
                column: "MaND");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_KhoaHocMaKH",
                table: "Chat",
                column: "KhoaHocMaKH");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietBinhLuan_MaBL",
                table: "ChiTietBinhLuan",
                column: "MaBL");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietBinhLuan_MaKH",
                table: "ChiTietBinhLuan",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietChat_MaChat",
                table: "ChiTietChat",
                column: "MaChat");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietChat_MaND",
                table: "ChiTietChat",
                column: "MaND");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_MaDH",
                table: "ChiTietDonHang",
                column: "MaDH");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDonHang_MaKH",
                table: "ChiTietDonHang",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_ChungChi_MaKH",
                table: "ChungChi",
                column: "MaKH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChungChi_MaND",
                table: "ChungChi",
                column: "MaND");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_NguoiDungMaND",
                table: "DonHang",
                column: "NguoiDungMaND");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_MaRole",
                table: "GiangVien",
                column: "MaRole");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHoc_MaGV",
                table: "KhoaHoc",
                column: "MaGV");

            migrationBuilder.CreateIndex(
                name: "IX_KhoaHoc_MaLoai",
                table: "KhoaHoc",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_MaRole",
                table: "NguoiDung",
                column: "MaRole");

            migrationBuilder.CreateIndex(
                name: "IX_PhanHoi_MaND",
                table: "PhanHoi",
                column: "MaND");

            migrationBuilder.CreateIndex(
                name: "IX_QuanTriVien_MaRole",
                table: "QuanTriVien",
                column: "MaRole");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_MaLTT",
                table: "ThanhToan",
                column: "MaLTT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaiTap");

            migrationBuilder.DropTable(
                name: "ChiTietBinhLuan");

            migrationBuilder.DropTable(
                name: "ChiTietChat");

            migrationBuilder.DropTable(
                name: "ChiTietDonHang");

            migrationBuilder.DropTable(
                name: "ChungChi");

            migrationBuilder.DropTable(
                name: "PhanHoi");

            migrationBuilder.DropTable(
                name: "QuanTriVien");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropTable(
                name: "BaiHoc");

            migrationBuilder.DropTable(
                name: "BinhLuan");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "LoaiTT");

            migrationBuilder.DropTable(
                name: "KhoaHoc");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "LoaiKH");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
