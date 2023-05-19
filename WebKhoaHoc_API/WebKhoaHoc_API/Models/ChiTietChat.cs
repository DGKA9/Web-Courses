using AutoMapper.Execution;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    public class ChiTietChat
    {
        [Key]
        public int MaCTC { get; set; }
        public int MaND { get; set; }
        public int MaChat { get; set; }


        #region Quan hệ
     
        public virtual NguoiDung NguoiDung { get; set; }
        public virtual Chat Chat { get; set; }

        #endregion
    }
}
