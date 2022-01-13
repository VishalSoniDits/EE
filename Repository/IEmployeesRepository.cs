using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<GetEmployeesDTO>> GetEmployeesAsync();
       Task<ResponseDTO> AddEmployeesAsync(AddEmployeesDTO model); 
       Task<ResponseDTO> UpdateEmployeesAsync(UpdateEmployeesDTO model);
       Task<ResponseDTO> DeleteEmployeesAsync(DeleteEmployeesDTO model);
       Task <AddImageResponseDTO>  AddImageAsync(AddImageDTO modal ,string actionPerformedBy);

       Task<ResponseDTO> ChakeEamilAsync(ChakeEamilDTO model);
    }
}