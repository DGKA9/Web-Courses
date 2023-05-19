using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Models
{
    [Table("LoaiKH")]
    public class LoaiKH
    {
        [Key]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }



        #region Quan hệ

        public virtual ICollection<KhoaHoc> KhoaHoc { get; set;}

        #endregion
    }
}
