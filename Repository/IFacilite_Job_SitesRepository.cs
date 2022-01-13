using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IFacilite_Job_SitesRepository
    {
       Task<IEnumerable<GetFacilite_Job_SitesDTO>> GetFacilite_Job_SitesAsync();
       Task<ResponseDTO> AddFacilite_Job_SitesAsync(AddFacilite_Job_SitesDTO model); 
       Task<ResponseDTO> UpdateFacilite_Job_SitesAsync(UpdateFacilite_Job_SitesDTO model);
       Task<ResponseDTO> DeleteFacilite_Job_SitesAsync(DeleteFacilite_Job_SitesDTO model);
    }
}