using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")] 
    public class AssignedTemplatesController:ControllerBase
    {
          private readonly IAssignedTemplatesRepository _assignedTemplatesRepository;
        public AssignedTemplatesController(IAssignedTemplatesRepository assignedTemplatesRepository)
        {
            _assignedTemplatesRepository = assignedTemplatesRepository;
        }

        [HttpGet("GetAssignedTemplates")]
        public async Task<IActionResult> GetAssignedTemplatesAsync()
        {
            return Ok( await _assignedTemplatesRepository.GetAssignedTemplatesAsync());
        }
        [HttpPost("AddAssignedTemplates")]
        public async Task<IActionResult> AddAssignedTemplates([FromBody]AddAssignedTemplatesDTO model)
        {
            return Ok(await _assignedTemplatesRepository.AddAssignedTemplatesAsync(model));
        }

        [HttpPut("UpdateAssignedTemplates")]
        public async Task<IActionResult> UpdateAssignedTemplates([FromBody]UpdateAssignedTemplatesDTO model)
        {
            return Ok(await _assignedTemplatesRepository.UpdateAssignedTemplatesAsync(model));
        }

        [HttpDelete("DeleteAssignedTemplates")]
        public async Task<IActionResult> DeleteAssignedTemplates([FromBody]DeleteAssignedTemplatesDTO model)
        {
            return Ok(await _assignedTemplatesRepository.DeleteAssignedTemplatesAsync(model));
        } 
    }
}