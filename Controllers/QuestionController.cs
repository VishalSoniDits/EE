using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class QuestionController:ControllerBase
    {
         private readonly IQuestionRepository _questionRepository;
        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpGet("GetQuestion")]
        public async Task<IActionResult> GetQuestionAsync()
        {
            return Ok( await _questionRepository.GetQuestionAsync());
        }
        [HttpPost("AddQuestion")]
        public async Task<IActionResult> AddQuestion([FromBody]AddQuestionDTO model)
        {
            return Ok(await _questionRepository.AddQuestionAsync(model));
        }

        [HttpPut("UpdateQuestion")]
        public async Task<IActionResult> UpdateQuestion([FromBody]UpdateQuestionDTO model)
        {
            return Ok(await _questionRepository.UpdateQuestionAsync(model));
        }

        [HttpDelete("DeleteQuestion")]
        public async Task<IActionResult> DeleteQuestion([FromQuery]DeleteQuestionDTO model)
        {
            return Ok(await _questionRepository.DeleteQuestionAsync(model));
        } 
    }
}