using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [MaxLength(100)]
        public string? RoleName { get; set; }

        #region Quan hệ

        public virtual ICollection<GiangVien> GiangViens { get; set; }
        public virtual ICollection<NguoiDung> NguoiDung { get; set; }
        public virtual ICollection<QuanTriVien> QuanTriViens { get; set; }

        #endregion
    }
}
