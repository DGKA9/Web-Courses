using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Data
{
    public class DHModel
    {
        public string TenDH { get; set; }
        public DateTime NgayLap { get; set; } = DateTime.Now;
        [Range(0, int.MaxValue)]
        public double TongGiaTri { get; set; }
        public string TrangThai { get; set; }
        public int MaND { get; set; }
        public int MaTT { get; set; }
    }
}
