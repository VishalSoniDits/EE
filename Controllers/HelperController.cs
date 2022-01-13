using System.Threading.Tasks;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    public class HelperController : ControllerBase
    {
        private readonly IHelperRepository _helperRepository;
        public HelperController(IHelperRepository helperRepository)
        {
            _helperRepository = helperRepository;
        }

        [HttpGet("GetHelper")]
        public async Task<IActionResult> GetHelperAsync()
        {
            return Ok( await _helperRepository.GetHelperAsync());
        }
    }
}