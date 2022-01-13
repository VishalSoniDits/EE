using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ISupplierRepository
    {
       Task<IEnumerable<GetSupplierDTO>> GetSupplierAsync();
       Task<AddSupplierDTO> AddSupplierAsync(AddSupplierDTO model); 
       Task<UpdateSupplierDTO> UpdateSupplierAsync(UpdateSupplierDTO model);
       Task<DeleteSupplierDTO> DeleteSupplierAsync(DeleteSupplierDTO model);
    }
}