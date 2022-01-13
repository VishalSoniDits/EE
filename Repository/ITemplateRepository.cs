using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;
namespace EE.Repository
{
    public interface  ITemplateRepository
    {
        
       Task<IEnumerable<GetTemplatesDTO>> GetTemplateAsync();
       Task<AddTemplatesDTO> AddTemplateAsync(AddTemplatesDTO model); 
       Task<UpdateTemplateDTO> UpdateTemplateAsync(UpdateTemplateDTO model);
       Task<DeleteTemplateDTO> DeleteTemplateAsync(DeleteTemplateDTO model);
    }
}