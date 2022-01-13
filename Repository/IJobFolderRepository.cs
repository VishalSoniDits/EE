using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IJobFolderRepository
    {
       Task<IEnumerable<GetJobFolderDTO>> GetJobFolderAsync();
       Task<AddJobFolderDTO> AddJobFolderAsync(AddJobFolderDTO model); 
       Task<UpdateJobFolderDTO> UpdateJobFolderAsync(UpdateJobFolderDTO model);
       Task<DeleteJobFolderDTO> DeleteJobFolderAsync(DeleteJobFolderDTO model);

    }
}