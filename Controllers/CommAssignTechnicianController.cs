using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{ //test
     [ApiController]
    [Route("api/[controller]")]
    public class CommAssignTechnicianController:ControllerBase
    {
        private readonly ICommAssignTechnicianRepository _commAssignTechnicianRepository;
        public CommAssignTechnicianController(ICommAssignTechnicianRepository commAssignTechnicianRepository)
        {
            _commAssignTechnicianRepository = commAssignTechnicianRepository;
        }
         [HttpPost("AddCommercialServiceRequest")]
        public async Task<IActionResult> AddCommAssignTechnicianSite([FromBody]AddCommAssignTechnicianDTO model)
        {
            return Ok(await _commAssignTechnicianRepository.AddCommAssignTechnicianAsync(model));
        }
    }
}