using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Models
{
    [Table("ChungChi")]
    public class ChungChi
    {
        [Key]
        public int MaCC { get; set; }
        public string TenCC { get; set; }
        public DateTime NgayCap { get; set; } = DateTime.Now;


        #region Quan hệ
        public int MaKH { get; set; }
        [ForeignKey("MaKH")]
        public virtual KhoaHoc KhoaHoc { get; set; }
      
        public int MaND { get; set; }
        [ForeignKey("MaND")]
        public virtual NguoiDung NguoiDung { get; set; }




        #endregion
    }
}
