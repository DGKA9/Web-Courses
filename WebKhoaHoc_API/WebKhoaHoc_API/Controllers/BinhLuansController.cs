//using AutoMapper;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using WebKhoaHoc_API.Data;
//using WebKhoaHoc_API.Models;
//using WebKhoaHoc_API.Repository;

//namespace WebKhoaHoc_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BinhLuansController : ControllerBase
//    {
//        private readonly IRepository<BinhLuan> _repository;
//        private readonly IMapper _mapper;

//        public BinhLuansController(IRepository<BinhLuan> repository, IMapper mapper)
//        {
//            _repository = repository;
//            _mapper = mapper;
//        }

//        [HttpGet]
//        public async Task<IActionResult> GetAll()
//        {
//            try
//            {
//                return Ok(await _repository.GetAllAsync());
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }

//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<BinhLuan>> GetById(int id)
//        {
//            var entity = await _repository.GetAsync(id);
//            if (entity == null)
//            {
//                return NotFound();
//            }
//            var rm = _mapper.Map<BLModel>(entity);
//            return Ok(rm);
//        }


//        [HttpPost]
//        public async Task<ActionResult<BLModel>> Add(BLModel model)
//        {
//            var entity = _mapper.Map<BinhLuan>(model);
//            await _repository.AddAsync(entity);
//            var resultModel = _mapper.Map<BLModel>(entity);
//            return CreatedAtAction(nameof(GetById), new { id = entity.MaBL }, resultModel);
//        }

//        [HttpPut("{id}")]
//        public async Task<IActionResult> Update(int id, BLModel model)
//        {
//            var entity = await _repository.GetAsync(id);
//            if (entity == null)
//            {
//                return NotFound();
//            }

//            _mapper.Map(model, entity);
//            await _repository.UpdateAsync(entity);
//            var resultModel = _mapper.Map<BLModel>(entity);
//            return Ok(resultModel);
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Delete(int id)
//        {
//            await _repository.DeleteAsync(id);
//            return NoContent();
//        }
//    }
//}
