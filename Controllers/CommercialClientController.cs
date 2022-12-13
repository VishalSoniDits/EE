using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")] 
    public class CommercialClientController:ControllerBase
    {
        private readonly ICommercialClientRepository _commercialClientRepository;
           public CommercialClientController(ICommercialClientRepository commercialClientRepository)
           {
               _commercialClientRepository =commercialClientRepository;
           }
           ///hsdhjdhdujkd
           [HttpGet("AddCommercialClient")]

            public async Task<IActionResult> GetCommercialClient()
            {
                return Ok(await _commercialClientRepository.GetCommercialClientAsync());
            }
            [HttpPost("AddCommercialClient")]
            public async Task<IActionResult> AddCommercialClient(AddCommercialClientDTO model)
            {
                return Ok(await _commercialClientRepository.AddCommercialClientAsync(model));
            }
            [HttpPut("EditCommercialClient")]
            public async Task<IActionResult> UpdateCommercialClient(UpdateCommercialClientDTO model)
            {
                return Ok(await _commercialClientRepository.UpdateCommercialClientAsync(model));
            }
            [HttpDelete("DeleteCommercialClient")]
            public async Task<IActionResult> DeleteCommercialClient(DeleteCommercialClientDTO model)
            {
                return Ok(await _commercialClientRepository.DeleteCommercialClientAsync(model));
            }
        } 
    }
