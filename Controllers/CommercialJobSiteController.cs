using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class CommercialJobSiteController:ControllerBase
    {
        private readonly ICommercialJobSiteRepository  _commercialJobSiteRepository;
        
        public CommercialJobSiteController(ICommercialJobSiteRepository commercialJobSiteRepository)
        {
            _commercialJobSiteRepository=commercialJobSiteRepository;
        }
       [HttpGet("GetCommercialJobSite")]
       public async Task<IActionResult> GetCommercialJobSite()
       {
           return Ok(await _commercialJobSiteRepository.GetCommercialJobSiteAsync());
       }

       [HttpPost("AddCommercialJobSite")]

       public async Task<IActionResult> AddCommercialJobSite(AddCommercialJobSiteDTO model)
       {
           return Ok(await _commercialJobSiteRepository.AddCommercialJobSiteAsync(model));
       }
        [HttpPut("EditCommercialJobSite")]
         
         public async Task<IActionResult> UpdateCommercialJobSite(UpdateCommercialJobSiteDTO model)
         {
             return Ok(await _commercialJobSiteRepository.UpdateCommercialJobSiteAsync(model));
         }
         [HttpDelete("DeleteCommercialJobSite")]

         public async Task<IActionResult> DeleteCommercialJobSite(DeleteCommercialJobSiteDTO model)
         {
             return Ok(await _commercialJobSiteRepository.DeleteCommercialJobSiteAsync(model));
         }
    }
}