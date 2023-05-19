using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int MaCTDH { get; set; }
        public int MaDH { get; set; }
        public int MaKH { get; set; }
        public int SoLuongKH { get; set; }

        #region Quan hệ

        public virtual DonHang DonHang { get; set; }
        public virtual KhoaHoc KhoaHoc { get; set; }

        #endregion
    }
}
