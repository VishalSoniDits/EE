using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class Facilite_Job_SitesController:ControllerBase
    {
         private readonly IFacilite_Job_SitesRepository _facilite_Job_SitesRepository;
        public Facilite_Job_SitesController(IFacilite_Job_SitesRepository facilite_Job_SitesRepository)
        {
            _facilite_Job_SitesRepository = facilite_Job_SitesRepository;
        }

        [HttpGet("GetFaciliteJobSites")]
        public async Task<IActionResult> GetFacilite_Job_SitesAsync()
        {
            return Ok( await _facilite_Job_SitesRepository.GetFacilite_Job_SitesAsync());
        }
        [HttpPost("AddFaciliteJobSites")]
        public async Task<IActionResult> AddFacilite_Job_Sites([FromBody]AddFacilite_Job_SitesDTO model)
        {
            return Ok(await _facilite_Job_SitesRepository.AddFacilite_Job_SitesAsync(model));
        }

        [HttpPut("UpdateFaciliteJobSites")]
        public async Task<IActionResult> UpdateFacilite_Job_Sites([FromBody]UpdateFacilite_Job_SitesDTO model)
        {
            return Ok(await _facilite_Job_SitesRepository.UpdateFacilite_Job_SitesAsync(model));
        }

        [HttpDelete("DeleteFaciliteJobSites")]
        public async Task<IActionResult> DeleteFacilite_Job_Sites([FromQuery]DeleteFacilite_Job_SitesDTO model)
        {
            return Ok(await _facilite_Job_SitesRepository.DeleteFacilite_Job_SitesAsync(model));
        } 
    }
}