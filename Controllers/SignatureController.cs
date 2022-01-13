using System.Threading.Tasks;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class SignatureController:ControllerBase
    {
         private readonly ISignatureRepository _signatureRepository;
        public SignatureController(ISignatureRepository signatureRepository)
        {
            _signatureRepository = signatureRepository;
        }
          [HttpGet("GetSignature")]
        public async Task<IActionResult> GetSignatureAsync()
        {
            return Ok( await _signatureRepository.GetSignatureAsync());
        }
    }
}