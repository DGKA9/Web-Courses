using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Models
{
    [Table("GiangVien")]
    public class GiangVien
    {
        [Key]
        public int MaGV { get; set; }
        [MaxLength(100)]
        public string TenGV { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string ChuyenMon { get; set; } = string.Empty;
        public string NamHD { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;



        #region Quan hệ

        public int MaRole { get; set; }
        [ForeignKey("MaRole")]
        public virtual Role Role { get; set; }


        public virtual ICollection<KhoaHoc> KhoaHocs { get; set; }

        #endregion

    }
}
