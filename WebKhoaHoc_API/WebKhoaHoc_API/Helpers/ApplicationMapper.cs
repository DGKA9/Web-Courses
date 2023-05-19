using AutoMapper;
using WebKhoaHoc_API.Data;
using WebKhoaHoc_API.Models;

namespace WebKhoaHoc_API.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<GiangVien, GVModel>().ReverseMap();
            CreateMap<NguoiDung, NDModel>().ReverseMap();
            CreateMap<QuanTriVien, QuanTriVienModel>().ReverseMap();
            CreateMap<Chat, ChatModel>().ReverseMap();
            CreateMap<Role, RoleModel>().ReverseMap();
            CreateMap<BaiHoc, BaiHocModel>().ReverseMap();
            CreateMap<BaiTap, BaiTapModel>().ReverseMap();
            //CreateMap<BinhLuan, BLModel>().ReverseMap();
            CreateMap<DonHang, DHModel>().ReverseMap();
            CreateMap<LoaiKH, LoaiKHModel>().ReverseMap();
            CreateMap<LoaiTT, LoaiTTModel>().ReverseMap();
            CreateMap<PhanHoi, PhanHoiModel>().ReverseMap();
            CreateMap<ThanhToan, ThanhToanModel>().ReverseMap();
            CreateMap<KhoaHoc, KHModel>().ReverseMap();

        }
    }
}
