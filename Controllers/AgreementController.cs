using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    public class AgreementController : ControllerBase
    {
        private readonly IAgreementRepository _agreementRepository;
        public AgreementController(IAgreementRepository agreementRepository)
        {
            _agreementRepository = agreementRepository;
        }

        [HttpGet("GetAgreement")]
        public async Task<IActionResult> GetAgreementAsync()
        {
            return Ok( await _agreementRepository.GetAgreementAsync());
        }
        [HttpPost("AddAgreement")]
        public async Task<IActionResult> AddAgreement([FromBody]AddAgreementDTO model)
        {
            return Ok(await _agreementRepository.AddAgreementAsync(model));
        }

        [HttpPut("UpdateAgreement")]
        public async Task<IActionResult> UpdateAgreement([FromBody]UpdateAgreementDTO model)
        {
            return Ok(await _agreementRepository.UpdateAgreementAsync(model));
        }

        [HttpDelete("DeleteAgreement")]
        public async Task<IActionResult> DeleteAgreement([FromQuery]DeleteAgreementDTO model)
        {
            return Ok(await _agreementRepository.DeleteAgreementAsync(model));
        }
    }
}