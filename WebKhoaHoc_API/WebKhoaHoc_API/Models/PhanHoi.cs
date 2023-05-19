using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("PhanHoi")]
    public class PhanHoi
    {
        [Key]
        public int MaPH { get; set; }
        public string NoiDungPH { get; set; }
        public DateTime NgayPH { get; set; } = DateTime.Now;
        public string DiaChi { get; set; }


        #region Quan hệ

        public int MaND { get; set; }
        [ForeignKey("MaND")]
        public virtual NguoiDung NguoiDung { get; set; }

        #endregion
    }

}
