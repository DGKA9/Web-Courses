using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKhoaHoc_API.Models
{
    [Table("Chat")]
    public class Chat
    {
        [Key]
        public int MaChat { get; set; }
        public String NoiDung { get; set; }
        public DateTime NgayGui { get; set; } = DateTime.Now;


        #region Quan hệ

        public virtual KhoaHoc KhoaHoc { get; set; }

        public virtual ICollection<ChiTietChat> ChiTietChats { get; set; }
       
        public Chat()
        {
            ChiTietChats = new List<ChiTietChat>();
        }

        #endregion
    }

}
