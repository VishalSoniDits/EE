using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ISupplierRepository
    {
         Task<IEnumerable<GetSupplierDTO>> GetSupplierAsync();
       Task<ResponseDTO> AddSupplierAsync(AddSupplierDTO model); 
       Task<ResponseDTO> UpdateSupplierAsync(UpdateSupplierDTO model);
       Task<ResponseDTO> DeleteSupplierAsync(DeleteSupplierDTO model);
    }
}