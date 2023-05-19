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
    public class DonHangsController : ControllerBase
    {
        private readonly IRepository<DonHang> _repository;
        private readonly IMapper _mapper;

        public DonHangsController(IRepository<DonHang> repository, IMapper mapper)
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
        public async Task<ActionResult<DonHang>> GetById(int id)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            var rm = _mapper.Map<DHModel>(entity);
            return Ok(rm);
        }


        [HttpPost]
        public async Task<ActionResult<DHModel>> Add(DHModel model)
        {
            var entity = _mapper.Map<DonHang>(model);
            await _repository.AddAsync(entity);
            var resultModel = _mapper.Map<DHModel>(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.MaDH }, resultModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DHModel model)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _mapper.Map(model, entity);
            await _repository.UpdateAsync(entity);
            var resultModel = _mapper.Map<DHModel>(entity);
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
