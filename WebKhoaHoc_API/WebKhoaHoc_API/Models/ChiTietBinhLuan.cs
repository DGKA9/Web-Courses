using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Models
{
    public class ChiTietBinhLuan
    {
        [Key] 
        public int MaCTBL { get; set; }
        public int MaBL { get; set; }
        public int MaKH { get; set; }


        public virtual KhoaHoc KhoaHoc { get; set; }
        public virtual BinhLuan BinhLuan { get; set; }
    }
}
