using System.Threading.Tasks;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{    [ApiController]
    [Route("api/[controller]")]
    public class SetRoleController: ControllerBase
    {
        private readonly ISetRoleRepository _setRoleRepository;
        public SetRoleController(ISetRoleRepository setRoleRepository)
        {
            _setRoleRepository = setRoleRepository;
        }
          [HttpGet("GetSetRole")]
        public async Task<IActionResult> GetSetRoleAsync()
        {
            return Ok( await _setRoleRepository.GetSetRoleAsync());
        }
    }
}