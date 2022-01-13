using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ICommAssignTechnicianRepository
    {
        Task<ResponseDTO> AddCommAssignTechnicianAsync(AddCommAssignTechnicianDTO model); 
    }
}