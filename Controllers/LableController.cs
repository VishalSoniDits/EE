using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class LableController:ControllerBase
    {
         private readonly ILableRepository _lableRepository;
        public LableController(ILableRepository lableRepository)
        {
            _lableRepository = lableRepository;
        }

        [HttpGet("GetLable")]
        public async Task<IActionResult> GetLableAsync()
        {
            return Ok( await _lableRepository.GetLableAsync());
        }
        [HttpPost("AddLable")]
        public async Task<IActionResult> AddLable([FromBody]AddLableDTO model)
        {
            return Ok(await _lableRepository.AddLableAsync(model));
        }

        [HttpPut("UpdateLable")]
        public async Task<IActionResult> UpdateLable([FromBody]UpdateLableDTO model)
        {
            return Ok(await _lableRepository.UpdateLableAsync(model));
        }

        [HttpDelete("DeleteLable")]
        public async Task<IActionResult> DeleteLable([FromQuery]DeleteLableDTO model)
        {
            return Ok(await _lableRepository.DeleteLableAsync(model));
        } 
    }
}