using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IFacilitie_ClientsRepository
    {
         Task<IEnumerable<GetFacilitie_ClientsDTO>> GetFacilite_ClientsAsync();
       Task<ResponseDTO> AddFacilite_ClientsAsync(AddFacilite_ClientsDTO model); 
       Task<ResponseDTO> UpdateFacilite_ClientsAsync(UpdateFacilite_ClientsDTO model);
       Task<ResponseDTO> DeleteFacilite_ClientsAsync(DeleteFacilite_ClientsDTO model);
    }
}