using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class CommServiceRequestController:ControllerBase
    {
        private readonly ICommServiceRequestRepository _commServiceRequestRepository;
        public CommServiceRequestController(ICommServiceRequestRepository commServiceRequestRepository)
        {
            _commServiceRequestRepository = commServiceRequestRepository;
        }
        [HttpGet("GetCommercialServiceRequest")]
        public async Task<IActionResult> GetCommServiceRequestAsync()
        {
            return Ok( await _commServiceRequestRepository.GetCommServiceRequestAsync());
        }
        [HttpPost("AddCommercialServiceRequest")]
        public async Task<IActionResult> AddCommServiceRequestSite([FromBody]AddCommServiceRequestDTO model)
        {
            return Ok(await _commServiceRequestRepository.AddCommServiceRequestAsync(model));
        }
    }
}