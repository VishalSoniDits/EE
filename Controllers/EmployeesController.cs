using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesRepository _employeesRepository;
        public EmployeesController(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetCustomerAsync()
        {
            return Ok( await _employeesRepository.GetEmployeesAsync());
        }
        [HttpPost("AddEmployees")]
        public async Task<IActionResult> AddEmployees([FromBody]AddEmployeesDTO model)
        {
            return Ok(await _employeesRepository.AddEmployeesAsync(model));
        }

        [HttpPut("UpdateEmployees")]
        public async Task<IActionResult> UpdateEmployees([FromBody]UpdateEmployeesDTO model)
        {
            return Ok(await _employeesRepository.UpdateEmployeesAsync(model));
        }

        [HttpDelete("DeleteEmployees")]
        public async Task<IActionResult> DeleteEmployees([FromBody]DeleteEmployeesDTO model)
        {
            return Ok(await _employeesRepository.DeleteEmployeesAsync(model));
        }
         [HttpPost("AddImage")]
        public async Task<IActionResult> AddImageAsync([FromForm] AddImageDTO model)
        {
            return Ok(await _employeesRepository.AddImageAsync(model, ""));
        }

        [HttpPost("CheckEmail")]
         public async Task<IActionResult> ChakeEamil([FromBody]ChakeEamilDTO model)
         {
             return Ok(await _employeesRepository.ChakeEamilAsync(model));
         }
    }
}