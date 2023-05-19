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
    public class ChatsController : ControllerBase
    {
        private readonly IRepository<Chat> _repository;
        private readonly IMapper _mapper;

        public ChatsController(IRepository<Chat> repository, IMapper mapper)
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
        public async Task<ActionResult<Chat>> GetById(int id)
        {
            var entity = await _repository.GetAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            var rm = _mapper.Map<ChatModel>(entity);
            return entity;
        }


        [HttpPost]
        public async Task<ActionResult<ChatModel>> Add(ChatModel model) 
        { 
            var entity = _mapper.Map<Chat>(model);
            await _repository.AddAsync(entity);
            var resultModel = _mapper.Map<ChatModel>(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.MaChat }, resultModel);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Chat entity)
        {
            if (id != entity.MaChat)
            {
                return BadRequest();
            }
            var r = _mapper.Map<Chat>(entity);
            await _repository.UpdateAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
