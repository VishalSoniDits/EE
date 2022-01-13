using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ICommercialClientRepository
    {
        Task<IEnumerable<GetCommercialClientDTO>> GetCommercialClientAsync();
        Task<ResponseDTO> AddCommercialClientAsync (AddCommercialClientDTO model);

        Task<ResponseDTO> UpdateCommercialClientAsync (UpdateCommercialClientDTO model);
        Task<ResponseDTO> DeleteCommercialClientAsync (DeleteCommercialClientDTO model);

    }
}