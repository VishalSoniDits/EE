using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IQuestionTypeRepository
    {
       Task<IEnumerable<GetQuestionTypeDTO>> GetQuestionTypeAsync();
       Task<AddQuestionTypeDTO> AddQuestionTypeAsync(AddQuestionTypeDTO model); 
       Task<UpdateQuestiontypeDTO> UpdateQuestionTypeAsync(UpdateQuestiontypeDTO model);
       Task<DeleteQuestionTypeDTO> DeleteQuestionTypeAsync(DeleteQuestionTypeDTO model);
    }
}