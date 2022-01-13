using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class ResidentialJobSiteController:ControllerBase
    {
           private readonly IResidentialJobSiteRepository _residentialJobSiteRepository;
        public ResidentialJobSiteController(IResidentialJobSiteRepository residentialJobSiteRepository)
        {
            _residentialJobSiteRepository = residentialJobSiteRepository;
        }

        [HttpGet("GetResidentialJobSite")]
        public async Task<IActionResult> GetResidentialJobSiteAsync()
        {
            return Ok( await _residentialJobSiteRepository.GetResidentialJobSiteAsync());
        }
        [HttpPost("AddResidentialJobSite")]
        public async Task<IActionResult> AddResidentialJobSite([FromBody]AddResidentialJobSiteDTO model)
        {
            return Ok(await _residentialJobSiteRepository.AddResidentialJobSiteAsync(model));
        }

        [HttpPut("UpdateResidentialJobSite")]
        public async Task<IActionResult> UpdateResidentialJobSite([FromBody]UpdateResidentialJobSiteDTO model)
        {
            return Ok(await _residentialJobSiteRepository.UpdateResidentialJobSiteAsync(model));
        }

        [HttpDelete("DeleteResidentialJobSite")]
        public async Task<IActionResult> DeleteResidentialJobSite([FromBody]DeleteResidentialJobSiteDTO model)
        {
            return Ok(await _residentialJobSiteRepository.DeleteResidentialJobSiteAsync(model));
        }
    }
}