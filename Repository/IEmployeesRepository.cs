using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IEmployeesRepository
    {
       Task<IEnumerable<GetEmployeesDTO>> GetEmployeesAsync();
       Task<AddEmployeesDTO> AddEmployeesAsync(AddEmployeesDTO model); 
       Task<UpdateEmployeesDTO> UpdateEmployeesAsync(UpdateEmployeesDTO model);
       Task<DeleteEmployeesDTO> DeleteEmployeesAsync(DeleteEmployeesDTO model);

    
    Task <AddImageResponseDTO>  AddImageAsync(AddImageDTO modal ,string actionPerformedBy);

       Task<ResponseDTO> ChakeEamilAsync(ChakeEamilDTO model);
       }
}
