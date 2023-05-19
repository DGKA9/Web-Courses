using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("BinhLuan")]
    public class BinhLuan
    {
        [Key]
        public int MaBL { get; set; }

        public string NoiDung { get; set; }
        public DateTime NgayBL { get; set; } = DateTime.Now;

        #region Quan hệ

        public int MaND { get; set; }
        [ForeignKey("MaND")]
        public NguoiDung NguoiDung { get; set;}


        public virtual ICollection<ChiTietBinhLuan> ChiTietBinhLuans { get; set; }
        public BinhLuan() 
        {
            ChiTietBinhLuans = new List<ChiTietBinhLuan>();
        }
        
        #endregion
    }

}
