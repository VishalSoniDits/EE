using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ICommServiceRequestRepository
    {
       Task<IEnumerable<GetCommServiceRequestDTO>> GetCommServiceRequestAsync();
       Task<ResponseDTO> AddCommServiceRequestAsync(AddCommServiceRequestDTO model); 
    }
}