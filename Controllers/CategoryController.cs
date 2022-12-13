using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{ //test
     [ApiController]
    [Route("api/[controller]")]
    public class CategoryController:ControllerBase
    {
           private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet("GetCategory")]
        public async Task<IActionResult> GetCategoryAsync()
        {
            return Ok( await _categoryRepository.GetCategoryAsync());
        }
        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory([FromBody]AddCategoryDTO model)
        {
            return Ok(await _categoryRepository.AddCategoryAsync(model));
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody]UpdateCategoryDTO model)
        {
            return Ok(await _categoryRepository.UpdateCategoryAsync(model));
        }

        [HttpDelete("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory([FromBody]DeleteCategoryDTO model)
        {
            return Ok(await _categoryRepository.DeleteCategoryAsync(model));
        }
         [HttpPost("GetSearchCategory")]
        public async Task<IActionResult> GetSearchCategoryAsync([FromBody]GetSearchCategoryDTO model)
        {
            return Ok(await _categoryRepository.GetSearchCategoryAsync(model));
        }
    }
}