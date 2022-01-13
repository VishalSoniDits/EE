using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IZipcodeRepository
    {
       Task<IEnumerable<GetZipcodeDTO>> GetZipcodeAsync();
       Task<ResponseDTO> AddZipcodeAsync(AddZipcodeDTO model); 
       Task<ResponseDTO> UpdateZipcodeAsync(UpdateZipcodeDTO model);
       Task<ResponseDTO> DeleteZipcodeAsync(DeleteZipcodeDTO model);
    }
}