using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Modes;

namespace EE.Repository
{
    public interface ISetRoleRepository
    {
          Task<IEnumerable<GetSetRoleDTO>> GetSetRoleAsync();
    }
}