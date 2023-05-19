using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Data
{
    public class KHModel
    {
        public string? TenKH { get; set; }
        public string? MoTa { get; set; }
        public int? SoLuongBH { get; set; }
        public int? SoNguoiVien { get; set; }

        [Range(0, double.MaxValue)]
        public double? Gia { get; set; }

        public int MaQTV { get; set; }
        public int MaLoai {get; set;}
        public int MaGV { get; set;}
    }
}
