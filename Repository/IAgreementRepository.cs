using System.Collections.Generic;
using System.Threading.Tasks;
using EE.Models;

namespace EE.Repository
{
    public interface IAgreementRepository
    {
       Task<IEnumerable<GetAgreementDTO>> GetAgreementAsync();
       Task<AddAgreementDTO> AddAgreementAsync(AddAgreementDTO model); 
       Task<UpdateAgreementDTO> UpdateAgreementAsync(UpdateAgreementDTO model);
       Task<DeleteAgreementDTO> DeleteAgreementAsync(DeleteAgreementDTO model);

    }
}