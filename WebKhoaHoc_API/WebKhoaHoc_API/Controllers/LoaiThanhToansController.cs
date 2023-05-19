using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml;
using WebKhoaHoc_API.Data;
using WebKhoaHoc_API.Models;
using WebKhoaHoc_API.Repository;

namespace WebKhoaHoc_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiThanhToansController : ControllerBase
    {
        private readonly IRepository<LoaiTT> _repository;
        private readonly IMapper _mapper;

        public LoaiThanhToansController(IRepository<LoaiTT> repository, IMapper mapper)
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
        public async Task<ActionResult<LoaiTT>> GetById(int id)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            var rm = _mapper.Map<LoaiTTModel>(entity);
            return Ok(rm);
        }


        [HttpPost]
        public async Task<ActionResult<LoaiTTModel>> Add(LoaiTTModel model)
        {
            var entity = _mapper.Map<LoaiTT>(model);
            await _repository.AddAsync(entity);
            var resultModel = _mapper.Map<LoaiTTModel>(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.MaLTT }, resultModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, LoaiTTModel model)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _mapper.Map(model, entity);
            await _repository.UpdateAsync(entity);
            var resultModel = _mapper.Map<LoaiTTModel>(entity);
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
