using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ISubCategoryRepository
    {
      Task<IEnumerable<GetSubCategorysDTO>> GetSubCategoryAsync();
       Task<AddSubCategoryDTO> AddSubCategoryAsync(AddSubCategoryDTO model); 
       Task<UpdateSubCategoryDTO> UpdateSubCategoryAsync(UpdateSubCategoryDTO model);
       Task<DeleteSubCategoryDTO> DeleteSubCategoryAsync(DeleteSubCategoryDTO model);
    }
}