using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IQuestionRepository
    {
         Task<IEnumerable<GetQuestioDTO>> GetQuestionAsync();
       Task<AddQuestionDTO> AddQuestionAsync(AddQuestionDTO model); 
       Task<UpdateQuestionDTO> UpdateQuestionAsync(UpdateQuestionDTO model);
       Task<DeleteQuestionDTO> DeleteQuestionAsync(DeleteQuestionDTO model);
    }
}