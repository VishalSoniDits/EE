using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IAssignedTemplatesRepository
    {
       Task<IEnumerable<GetAssignedTemplatesDTO>> GetAssignedTemplatesAsync();
       Task<ResponseDTO> AddAssignedTemplatesAsync(AddAssignedTemplatesDTO model); 
       Task<ResponseDTO> UpdateAssignedTemplatesAsync(UpdateAssignedTemplatesDTO model);
       Task<ResponseDTO> DeleteAssignedTemplatesAsync(DeleteAssignedTemplatesDTO model);
    }
}