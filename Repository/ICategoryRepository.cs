using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<GetCategoryDTO>> GetCategoryAsync();
       Task<ResponseDTO> AddCategoryAsync(AddCategoryDTO model); 
       Task<ResponseDTO> UpdateCategoryAsync(UpdateCategoryDTO model);
       Task<ResponseDTO> DeleteCategoryAsync(DeleteCategoryDTO model);
        Task<IEnumerable<GetCategoryDTO>> GetSearchCategoryAsync(GetSearchCategoryDTO model); 
    }
}