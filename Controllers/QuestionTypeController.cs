using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{   [ApiController]
    [Route("api/[controller]")]
    public class QuestionTypeController:ControllerBase
    {
        private readonly IQuestionTypeRepository _questionTypeRepository;
        public QuestionTypeController(IQuestionTypeRepository questionTypeRepository)
        {
            _questionTypeRepository = questionTypeRepository;
        }

        [HttpGet("GetQuestionType")]
        public async Task<IActionResult> GetQuestionTypeAsync()
        {
            return Ok( await _questionTypeRepository.GetQuestionTypeAsync());
        }
        [HttpPost("AddQuestionType")]
        public async Task<IActionResult> AddQuestionType([FromBody]AddQuestionTypeDTO model)
        {
            return Ok(await _questionTypeRepository.AddQuestionTypeAsync(model));
        }

        [HttpPut("UpdateQuestionType")]
        public async Task<IActionResult> UpdateQuestionType([FromBody]UpdateQuestiontypeDTO model)
        {
            return Ok(await _questionTypeRepository.UpdateQuestionTypeAsync(model));
        }

        [HttpDelete("DeleteQuestionType")]
        public async Task<IActionResult> DeleteQuestionType([FromQuery]DeleteQuestionTypeDTO model)
        {
            return Ok(await _questionTypeRepository.DeleteQuestionTypeAsync(model));
        }
    }
}