using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class PricingController:ControllerBase
    {
        private readonly IPricingRepository _pricingRepository;
        public PricingController(IPricingRepository pricingRepository)
        {
            _pricingRepository = pricingRepository;
        }

        [HttpGet("GetPricing")]
        public async Task<IActionResult> GetPricingAsync()
        {
            return Ok( await _pricingRepository.GetPricingAsync());
        }
        [HttpPost("AddPricing")]
        public async Task<IActionResult> AddPricing([FromBody]AddPricingDTO model)
        {
            return Ok(await _pricingRepository.AddPricingAsync(model));
        }

        [HttpPut("UpdatePricing")]
        public async Task<IActionResult> UpdatePricing([FromBody]UpdatePricingDTO model)
        {
            return Ok(await _pricingRepository.UpdatePricingAsync(model));
        }

        [HttpDelete("DeletePricing")]
        public async Task<IActionResult> DeletePricing([FromBody]DeletePricingDTO model)
        {
            return Ok(await _pricingRepository.DeletePricingAsync(model));
        } 
    }
}