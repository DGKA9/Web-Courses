using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("DonHang")]
    public class DonHang
    {
        [Key]
        public int MaDH { get; set; }

        public string TenDH { get; set; }
        public DateTime NgayLap { get; set; } = DateTime.Now;
        [Range(0, int.MaxValue)]
        public double TongGiaTri { get; set; }
        public string TrangThai { get; set; }



        #region Quan hệ

        public virtual NguoiDung NguoiDung { get; set; }
       
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public DonHang()
        {
            ChiTietDonHangs = new List<ChiTietDonHang>();
        }

        #endregion
    }

}
