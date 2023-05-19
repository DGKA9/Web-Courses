using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebKhoaHoc_API.Data;
using WebKhoaHoc_API.Models;
using WebKhoaHoc_API.Repository;

namespace WebKhoaHoc_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiangViensController : ControllerBase
    {
        private readonly IRepository<GiangVien> _repository;
        private readonly IMapper _mapper;

        public GiangViensController(IRepository<GiangVien> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _repository.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GiangVien>> GetById(int id)
        {
            var entity = await _repository.GetAsync(id);
            
            if (entity == null)
            {
                return NotFound();
            }
            var rm = _mapper.Map<GVModel>(entity);
            return Ok(rm);
        }


        [HttpPost]
        public async Task<ActionResult<GVModel>> Add(GVModel model)
        {
            var entity = _mapper.Map<GiangVien>(model);
            await _repository.AddAsync(entity);
            var resultModel = _mapper.Map<GVModel>(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.MaGV }, resultModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, GVModel model)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _mapper.Map(model, entity);
            await _repository.UpdateAsync(entity);
            var resultModel = _mapper.Map<GVModel>(entity);
            return Ok(resultModel);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
