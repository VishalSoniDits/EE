using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class Facilitie_ClientsController:ControllerBase
    {
         private readonly IFacilitie_ClientsRepository _facilitie_ClientsRepository;
        public Facilitie_ClientsController(IFacilitie_ClientsRepository facilitie_ClientsRepository)
        {
            _facilitie_ClientsRepository = facilitie_ClientsRepository;
        }

        [HttpGet("GetFaciliteClients")]
        public async Task<IActionResult> GetFacilite_ClientsAsync()
        {
            return Ok( await _facilitie_ClientsRepository.GetFacilite_ClientsAsync());
        }
        [HttpPost("AddFaciliteClients")]
        public async Task<IActionResult> AddFacilite_Clients([FromBody]AddFacilite_ClientsDTO model)
        {
            return Ok(await _facilitie_ClientsRepository.AddFacilite_ClientsAsync(model));
        }

        [HttpPut("UpdateFaciliteClients")]
        public async Task<IActionResult> UpdateFacilite_Clients([FromBody]UpdateFacilite_ClientsDTO model)
        {
            return Ok(await _facilitie_ClientsRepository.UpdateFacilite_ClientsAsync(model));
        }

        [HttpDelete("DeleteFaciliteClients")]
        public async Task<IActionResult> DeleteFacilite_Clients([FromQuery]DeleteFacilite_ClientsDTO model)
        {
            return Ok(await _facilitie_ClientsRepository.DeleteFacilite_ClientsAsync(model));
        } 
    }
}