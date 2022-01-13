using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
     public class AgreementRepository : IAgreementRepository
     {
          private string connectionString;
        public AgreementRepository()
        {        
            connectionString = @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }
        // private string LocationPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "ProductImage");
        public IDbConnection Connection
        {
        get
        {
        return new SqlConnection(connectionString);
        }  
        }
         public async Task<IEnumerable<GetAgreementDTO>> GetAgreementAsync()
        {
            using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetAgreementDTO>("sp_GetAgreement",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
        public async Task<AddAgreementDTO> AddAgreementAsync(AddAgreementDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<AddAgreementDTO>("sp_AddAgreement",model,commandType:CommandType.StoredProcedure);
                return (AddAgreementDTO)result;
            }
        }
        public async Task<UpdateAgreementDTO> UpdateAgreementAsync(UpdateAgreementDTO model)
        {
             using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<UpdateAgreementDTO>("sp_UpdateAgreement",model,commandType:CommandType.StoredProcedure);
                return (UpdateAgreementDTO)result;
            }
        }
        public async Task<DeleteAgreementDTO> DeleteAgreementAsync(DeleteAgreementDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<DeleteAgreementDTO>("sp_DeleteAgreement",model,commandType:CommandType.StoredProcedure);
                return (DeleteAgreementDTO)result;
            }
        }
    }

    }