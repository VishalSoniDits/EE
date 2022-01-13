using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{[ApiController]
    [Route("api/[controller]")]    
    public class TemplateController:ControllerBase
    {
        private readonly ITemplateRepository _templateRepository;
        public TemplateController(ITemplateRepository templateRepository)
        {
            _templateRepository = templateRepository;
        }

        [HttpGet("GetTemplate")]
        public async Task<IActionResult> GetTemplateAsync()
        {
            return Ok( await _templateRepository.GetTemplateAsync());
        }
        [HttpPost("AddQuestion")]
        public async Task<IActionResult> AddQuestion([FromBody]AddTemplatesDTO model)
        {
            return Ok(await _templateRepository.AddTemplateAsync(model));
        }

        [HttpPut("UpdateQuestion")]
        public async Task<IActionResult> UpdateQuestion([FromBody]UpdateTemplateDTO model)
        {
            return Ok(await _templateRepository.UpdateTemplateAsync(model));
        }

        [HttpDelete("DeleteQuestion")]
        public async Task<IActionResult> DeleteQuestion([FromQuery]DeleteTemplateDTO model)
        {
            return Ok(await _templateRepository.DeleteTemplateAsync(model));
        } 
    }
}