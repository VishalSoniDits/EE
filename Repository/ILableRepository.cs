using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ILableRepository
    {
       Task<IEnumerable<GetLableDTO>> GetLableAsync();
       Task<AddLableDTO> AddLableAsync(AddLableDTO model); 
       Task<UpdateLableDTO> UpdateLableAsync(UpdateLableDTO model);
       Task<DeleteLableDTO> DeleteLableAsync(DeleteLableDTO model);
    }
}