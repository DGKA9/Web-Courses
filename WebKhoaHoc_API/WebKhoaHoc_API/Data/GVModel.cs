using System.ComponentModel.DataAnnotations;
using WebKhoaHoc_API.Models;

namespace WebKhoaHoc_API.Data
{
    public class GVModel
    {
        [MaxLength(100)]
        public string TenGV { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }
        public string ChuyenMon { get; set; } = string.Empty;
        public string NamHD { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;
        public int RoleID { get; set; }
        
    }
}
