using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IHelperRepository
    {
       Task<IEnumerable<GetHelperDTO>> GetHelperAsync();
    }
}