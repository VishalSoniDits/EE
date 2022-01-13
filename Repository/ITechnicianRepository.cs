using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ITechnicianRepository
    {
       Task<IEnumerable<GetTechnicianDTO>> GetTechnicianAsync();
    }
}