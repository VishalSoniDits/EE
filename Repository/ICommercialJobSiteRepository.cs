using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ICommercialJobSiteRepository
    {
         Task<IEnumerable<GetCommercialJobSiteDTO>> GetCommercialJobSiteAsync();
         Task<ResponseDTO> AddCommercialJobSiteAsync (AddCommercialJobSiteDTO model);
         Task<ResponseDTO> UpdateCommercialJobSiteAsync (UpdateCommercialJobSiteDTO model);
         Task<ResponseDTO> DeleteCommercialJobSiteAsync (DeleteCommercialJobSiteDTO model);
    }
}