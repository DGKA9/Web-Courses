using System.ComponentModel.DataAnnotations;

namespace WebKhoaHoc_API.Data
{
    public class NDModel
    {
        [MaxLength(100)]
        public string TenDangNhap { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Password { get; set; } = string.Empty;
        [MaxLength(100)] 
        public string TenND { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public int RoleID { get; set; }
    }
}
