using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("NguoiDung")]
    public class NguoiDung
    {

        [Key]
        public int MaND { get; set; }

        [MaxLength(100)]
        public string TenDangNhap { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;
        [MaxLength(100)]
        public string TenND { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;

        #region Quan hệ
        public int MaRole { get; set; }
        [ForeignKey("MaRole")]
        public virtual Role Role { get; set; }

        public virtual ICollection<ChiTietChat> ChiTietChats { get; set; }
        public virtual ICollection<ChungChi> ChungChis { get; set; }
        public virtual ICollection<PhanHoi> PhanHois { get; set; }
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        public virtual ICollection<DonHang> DonHangs { get; set; }

        public NguoiDung()
        {
            ChiTietChats = new List<ChiTietChat>();
        }

        #endregion
    }



}
