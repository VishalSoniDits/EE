using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class ZipcodeController:ControllerBase
    {
           private readonly IZipcodeRepository _zipcodeRepository;
        public ZipcodeController(IZipcodeRepository zipcodeRepository)
        {
            _zipcodeRepository = zipcodeRepository;
        }

        [HttpGet("GetZipcode")]
        public async Task<IActionResult> GetZipcodeAsync()
        {
            return Ok( await _zipcodeRepository.GetZipcodeAsync());
        }
        [HttpPost("AddZipcode")]
        public async Task<IActionResult> AddZipcode([FromBody]AddZipcodeDTO model)
        {
            return Ok(await _zipcodeRepository.AddZipcodeAsync(model));
        }

        [HttpPut("UpdateZipcode")]
        public async Task<IActionResult> UpdateZipcode([FromBody]UpdateZipcodeDTO model)
        {
            return Ok(await _zipcodeRepository.UpdateZipcodeAsync(model));
        }

        [HttpDelete("DeleteZipcode")]
        public async Task<IActionResult> DeleteZipcode([FromBody]DeleteZipcodeDTO model)
        {
            return Ok(await _zipcodeRepository.DeleteZipcodeAsync(model));
        }
    }
}