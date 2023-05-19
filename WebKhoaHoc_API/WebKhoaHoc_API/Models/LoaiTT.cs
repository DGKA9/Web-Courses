using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("LoaiTT")]
    public class LoaiTT
    {
        [Key]
        public int MaLTT { get; set; }
        public string TenLTT { get; set; }


        #region Quan hệ

        public virtual ICollection<ThanhToan> ThanhToans { get; set; }

        #endregion
    }

}
