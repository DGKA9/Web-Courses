using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("BaiHoc")]
    public class BaiHoc
    {
        [Key]
        public int MaBH { get; set; }
        public string TenBH { get; set; }
        public string NoiDungBH { get; set; }
        public string Video { get; set; }


        #region Quan hệ

        public int MaKH { get; set; }
        [ForeignKey("MaKH")]
        public KhoaHoc KhoaHoc { get; set; }


        public virtual ICollection<BaiTap> BaiTaps { get; set; }

        #endregion
    }

}
