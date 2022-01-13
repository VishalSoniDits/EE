using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    public class JobFolderController : ControllerBase
    {
        private readonly IJobFolderRepository _jobFolderRepository;
        public JobFolderController(IJobFolderRepository jobFolderRepository)
        {
            _jobFolderRepository = jobFolderRepository;
        }

        [HttpGet("GetJobFolder")]
        public async Task<IActionResult> GetJobFolderAsync()
        {
            return Ok( await _jobFolderRepository.GetJobFolderAsync());
        }
        [HttpPost("AddJobFolder")]
        public async Task<IActionResult> AddJobFolder([FromBody]AddJobFolderDTO model)
        {
            return Ok(await _jobFolderRepository.AddJobFolderAsync(model));
        }

        [HttpPut("UpdateJobFolder")]
        public async Task<IActionResult> UpdateJobFolder([FromBody]UpdateJobFolderDTO model)
        {
            return Ok(await _jobFolderRepository.UpdateJobFolderAsync(model));
        }

        [HttpDelete("DeleteJobFolder")]
        public async Task<IActionResult> DeleteJobFolder([FromQuery]DeleteJobFolderDTO model)
        {
            return Ok(await _jobFolderRepository.DeleteJobFolderAsync(model));
        }
    }
}