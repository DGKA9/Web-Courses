using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Models
{
    [Table("KhoaHoc")]
    public class KhoaHoc
    {
        [Key]
        public int MaKH { get; set; }

        public string? TenKH { get; set; }
        public string? MoTa { get; set; }
        public int? SoLuongBH { get; set; }
        public int? SoLuong { get; set; }
        [Range(0, double.MaxValue)]
        public double? Gia { get; set; }



        #region Quan hệ

        public virtual ChungChi ChungChi { get; set; }
        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public virtual LoaiKH LoaiKH { get; set; }

        public int MaGV { get; set; }
        [ForeignKey("MaGV")]
        public virtual GiangVien GiangVien { get; set; }
       
        public virtual ICollection<BaiHoc> BaiHocs { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<ChiTietBinhLuan> ChiTietBinhLuans { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }



        public KhoaHoc()
        {
            ChiTietBinhLuans = new List<ChiTietBinhLuan>();
            ChiTietDonHangs = new List<ChiTietDonHang>();
        }


        
        #endregion
    }
}
