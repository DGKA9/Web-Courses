using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("BaiTap")]
    public class BaiTap
    {
        [Key]
        public int MaBT { get; set; }
        public string NoiDungBT { get; set; }
        public string DapAn { get; set; }
        [Range(0, 10)]
        public float Diem { get; set; }



        #region Quan hệ
        
        public int MaBH { get; set; }
        [ForeignKey("MaBH")]
        public BaiHoc BaiHoc { get; set; }
       
        #endregion
    }

}
