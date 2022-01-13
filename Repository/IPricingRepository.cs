using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IPricingRepository
    {
       Task<IEnumerable<GetPricingDTO>> GetPricingAsync();
       Task<ResponseDTO> AddPricingAsync(AddPricingDTO model); 
       Task<ResponseDTO> UpdatePricingAsync(UpdatePricingDTO model);
       Task<ResponseDTO> DeletePricingAsync(DeletePricingDTO model);
    }
}