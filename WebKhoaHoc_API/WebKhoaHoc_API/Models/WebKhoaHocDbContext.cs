using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebKhoaHoc_API.Data;

namespace WebKhoaHoc_API.Models
{
    public class WebKhoaHocDbContext : DbContext
    {
        public WebKhoaHocDbContext()
        {
        }

        public WebKhoaHocDbContext(DbContextOptions options) : base(options) { }

        #region DbSet

        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<BaiHoc> BaiHoc { get; set; }
        public DbSet<BaiTap> BaiTap { get; set; }
        public DbSet<ChungChi> ChungChi { get; set; }
        public DbSet<BinhLuan> BinhLuan { get; set; }
        public DbSet<DonHang> DonHang { get; set; }
        public DbSet<GiangVien> GiangVien { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<LoaiKH> LoaiKH { get; set; }
        public DbSet<LoaiTT> LoaiTT { get; set; }
        public DbSet<PhanHoi> PhanHoi { get; set; }
        public DbSet<QuanTriVien> QuanTriVien { get; set; }
        public DbSet<ThanhToan> ThanhToan { get; set; }
        #endregion


        #region OnModelsCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietBinhLuan>()
                   .HasKey(c => c.MaCTBL);

            modelBuilder.Entity<ChiTietBinhLuan>()
                        .HasOne(c => c.BinhLuan)
                        .WithMany(b => b.ChiTietBinhLuans)
                        .HasForeignKey(c => c.MaBL);

            modelBuilder.Entity<ChiTietBinhLuan>()
                        .HasOne(c => c.KhoaHoc)
                        .WithMany(k => k.ChiTietBinhLuans)
                        .HasForeignKey(c => c.MaKH);



            modelBuilder.Entity<ChiTietDonHang>()
                    .HasKey(c => c.MaCTDH);

            modelBuilder.Entity<ChiTietDonHang>()
                        .HasOne(c => c.DonHang)
                        .WithMany(b => b.ChiTietDonHangs)
                        .HasForeignKey(c => c.MaDH);

            modelBuilder.Entity<ChiTietDonHang>()
                        .HasOne(c => c.KhoaHoc)
                        .WithMany(k => k.ChiTietDonHangs)
                        .HasForeignKey(c => c.MaKH);


            modelBuilder.Entity<ChiTietChat>()
                    .HasKey(c => c.MaCTC);

            modelBuilder.Entity<ChiTietChat>()
                        .HasOne(c => c.Chat)
                        .WithMany(b => b.ChiTietChats)
                        .HasForeignKey(c => c.MaChat);

            modelBuilder.Entity<ChiTietChat>()
                        .HasOne(c => c.NguoiDung)
                        .WithMany(k => k.ChiTietChats)
                        .HasForeignKey(c => c.MaND);


            
        }
        #endregion



    }
}
