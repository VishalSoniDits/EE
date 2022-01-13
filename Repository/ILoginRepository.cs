using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface ILoginRepository
    {
        Task<ResponseDTO> LoginAsync(LoginDTO model); 
        Task<ResponseDTO> UpdatePasswordAsync(ChangePasswordDTO model);
    }
}