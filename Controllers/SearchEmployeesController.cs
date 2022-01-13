using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")]

    public class SearchEmployeesController:ControllerBase
    {
         private readonly ISearchEmployeesRepository _searchEmployeesRepository;
        public SearchEmployeesController(ISearchEmployeesRepository searchEmployeesRepository)
        {
            _searchEmployeesRepository = searchEmployeesRepository;
        }
        //   [HttpGet("GetSearchEmployees")]
        // public async Task<IActionResult> GetSearchEmployeesAsync()
        // {
        //     return Ok( await _searchEmployeesRepository.GetSearchEmployeesAsync());
        // }
          [HttpPost("GetSearchEmployees")]
        public async Task<IActionResult> GetSearchEmployeesAsync([FromBody]GetSearchEmployeesDTO model)
        {
            return Ok(await _searchEmployeesRepository.GetSearchEmployeesAsync(model));
        }
    }
}