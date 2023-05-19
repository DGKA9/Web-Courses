using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Models
{
    [Table("QuanTriVien")]
    public class QuanTriVien
    {
        [Key]
        public int MaQTV { get; set; }
        public string TenQTV { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = string.Empty;



        #region Quan hệ

        public int MaRole { get; set; }
        [ForeignKey("MaRole")]
        public virtual Role Role { get; set; }

        #endregion
    }
}
