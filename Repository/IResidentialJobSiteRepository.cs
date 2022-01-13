using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IResidentialJobSiteRepository
    {
       Task<IEnumerable<GetResidentialJobSiteDTO>> GetResidentialJobSiteAsync();
       Task<ResponseDTO> AddResidentialJobSiteAsync(AddResidentialJobSiteDTO model); 
       Task<ResponseDTO> UpdateResidentialJobSiteAsync(UpdateResidentialJobSiteDTO model);
       Task<ResponseDTO> DeleteResidentialJobSiteAsync(DeleteResidentialJobSiteDTO model);
    }
}