using System.Threading.Tasks;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    public class TechnicianController : ControllerBase
    {
        private readonly ITechnicianRepository _technicianRepository;
        public TechnicianController(ITechnicianRepository technicianRepository)
        {
            _technicianRepository = technicianRepository;
        }

        [HttpGet("GetTechnician")]
        public async Task<IActionResult> GetTechnicianAsync()
        {
            return Ok( await _technicianRepository.GetTechnicianAsync());
        }
    }
}