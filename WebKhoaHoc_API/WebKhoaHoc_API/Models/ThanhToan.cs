using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("ThanhToan")]
    public class ThanhToan
    {
        [Key]
        public int MaTT { get; set; }
        [Range(0, int.MaxValue)]
        public int TongTienTT { get; set; }
        public DateTime NgayTT { get; set; }

        #region Quan hệ

        public int MaLTT { get; set; }
        [ForeignKey("MaLTT")]
        public virtual LoaiTT LoaiTT { get; set; }

        #endregion
    }

}
