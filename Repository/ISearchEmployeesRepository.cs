using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ISearchEmployeesRepository
    {
        //  Task<IEnumerable<GetSearchEmployeesDTO>> GetSearchEmployeesAsync();
         Task<IEnumerable<GetEmployeesDTO>> GetSearchEmployeesAsync(GetSearchEmployeesDTO model); 
    }
}