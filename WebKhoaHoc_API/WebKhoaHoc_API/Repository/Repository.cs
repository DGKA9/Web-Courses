using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebKhoaHoc_API.Models;

namespace WebKhoaHoc_API.Repository
{
    public class Repository<T> : IRepository<T>  where T : class
    {
        private readonly WebKhoaHocDbContext _dbContext;
        private readonly IMapper _mapper;

        public Repository(WebKhoaHocDbContext dbContext, IMapper mapper) 
        { 
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task AddAsync(T item)
        {
            await _dbContext.Set<T>().AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            if (entity != null)
            {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            var loaiTT = await _dbContext.Set<T>()!.ToListAsync();
            return _mapper.Map<List<T>>(loaiTT);
        }

        public async Task<T> GetAsync(int id)
        {
            var t = await _dbContext.Set<T>().FindAsync(id);
            return t;
        }

        public async Task UpdateAsync(T item)
        {
            _dbContext.Set<T>().Update(item);
            await _dbContext.SaveChangesAsync();
           
        }

    }
}
