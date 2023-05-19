using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Data
{
    public class BaiTapModel
    {
        public string NoiDungBT { get; set; }
        public string DapAn { get; set; }
        [Range(0, 10)]
        public float Diem { get; set; }
        public int MaBH { get; set; }
    }
}
