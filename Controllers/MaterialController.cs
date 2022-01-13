using System.Threading.Tasks;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class MaterialController :ControllerBase
    {
         private readonly IMaterialRepository _materialRepository;
        public MaterialController(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }
          [HttpGet("GetMaterial")]
        public async Task<IActionResult> GetMaterialAsync()
        {
            return Ok( await _materialRepository.GetMaterialAsync());
        }
    }
}