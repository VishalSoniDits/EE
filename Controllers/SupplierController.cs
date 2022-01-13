using System.Threading.Tasks;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        [HttpGet("GetSupplier")]
        public async Task<IActionResult> GetSupplierAsync()
        {
            return Ok( await _supplierRepository.GetSupplierAsync());
        }
        [HttpPost("AddSupplier")]
        public async Task<IActionResult> AddSupplier([FromBody]AddSupplierDTO model)
        {
            return Ok(await _supplierRepository.AddSupplierAsync(model));
        }

        [HttpPut("UpdateSupplier")]
        public async Task<IActionResult> UpdateSupplier([FromBody]UpdateSupplierDTO model)
        {
            return Ok(await _supplierRepository.UpdateSupplierAsync(model));
        }

        [HttpDelete("DeleteSupplier")]
        public async Task<IActionResult> DeleteSupplier([FromBody]DeleteSupplierDTO model)
        {
            return Ok(await _supplierRepository.DeleteSupplierAsync(model));
        }
    }
}