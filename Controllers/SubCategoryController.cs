using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class SubCategoryController:ControllerBase
    {
         private readonly ISubCategoryRepository _subCategoryRepository;
        public SubCategoryController(ISubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        [HttpGet("GetSubCategory")]
        public async Task<IActionResult> GetSubCategoryAsync()
        {
            return Ok( await _subCategoryRepository.GetSubCategoryAsync());
        }
        [HttpPost("AddSubCategory")]
        public async Task<IActionResult> AddSubCategory([FromBody]AddSubCategoryDTO model)
        {
            return Ok(await _subCategoryRepository.AddSubCategoryAsync(model));
        }

        [HttpPut("UpdateSubCategory")]
        public async Task<IActionResult> UpdateSubCategory([FromBody]UpdateSubCategoryDTO model)
        {
            return Ok(await _subCategoryRepository.UpdateSubCategoryAsync(model));
        }

        [HttpDelete("DeleteSubCategory")]
        public async Task<IActionResult> DeleteSubCategory([FromBody]DeleteSubCategoryDTO model)
        {
            return Ok(await _subCategoryRepository.DeleteSubCategoryAsync(model));
        }
    }
}