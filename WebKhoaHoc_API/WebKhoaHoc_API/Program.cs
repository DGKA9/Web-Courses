using Microsoft.EntityFrameworkCore;
using WebKhoaHoc_API.Data;
using WebKhoaHoc_API.Models;
using WebKhoaHoc_API.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


#region Khai báo Database

builder.Services.AddDbContext<WebKhoaHocDbContext>(op => {
    op.UseSqlServer(builder.Configuration.GetConnectionString("WebKhoaHoc"));
});

#endregion

#region Khai báo Repository

builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<BaiHoc>, Repository<BaiHoc>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<BaiTap>, Repository<BaiTap>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<BinhLuan>, Repository<BinhLuan>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<Chat>, Repository<Chat>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<ChungChi>, Repository<ChungChi>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<DonHang>, Repository<DonHang>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<GiangVien>, Repository<GiangVien>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<LoaiKH>, Repository<LoaiKH>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<NguoiDung>, Repository<NguoiDung>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<PhanHoi>, Repository<PhanHoi>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<LoaiTT>, Repository<LoaiTT>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<KhoaHoc>, Repository<KhoaHoc>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<Role>, Repository<Role>>();
builder.Services.AddScoped<WebKhoaHoc_API.Repository.IRepository<QuanTriVien>, Repository<QuanTriVien>>();


#endregion





builder.Services.AddAutoMapper(typeof(Program));





WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
