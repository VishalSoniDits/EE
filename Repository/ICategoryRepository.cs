using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<GetCategoryDTO>> GetCategoryAsync();
       Task<AddCategoryDTO> AddCategoryAsync(AddCategoryDTO model); 
       Task<UpdateCategoryDTO> UpdateCategoryAsync(UpdateCategoryDTO model);
       Task<DeleteCategoryDTO> DeleteCategoryAsync(DeleteCategoryDTO model);
    }
}