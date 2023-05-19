namespace WebKhoaHoc_API.Data
{
    public class PhanHoiModel
    {
        public string NoiDungPH { get; set; }
        public DateTime NgayPH { get; set; } = DateTime.Now;
        public string DiaChi { get; set; }
        public int MaND { get; set; }
    }
}
