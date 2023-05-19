using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebKhoaHoc_API.Data;
using WebKhoaHoc_API.Models;
using WebKhoaHoc_API.Repository;

namespace WebKhoaHoc_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NguoiDungsController : ControllerBase
    {
        private readonly IRepository<NguoiDung> _repository;
        private readonly IMapper _mapper;

        public NguoiDungsController(IRepository<NguoiDung> repository, IMapper mapper)
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
        public async Task<ActionResult<NguoiDung>> GetById(int id)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            var rm = _mapper.Map<NDModel>(entity);
            return Ok(rm);
        }


        [HttpPost]
        public async Task<ActionResult<NDModel>> Add(NDModel model)
        {
            var entity = _mapper.Map<NguoiDung>(model);
            await _repository.AddAsync(entity);
            var resultModel = _mapper.Map<NDModel>(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.MaND }, resultModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, NDModel model)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            _mapper.Map(model, entity);
            await _repository.UpdateAsync(entity);
            var resultModel = _mapper.Map<NDModel>(entity);
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
