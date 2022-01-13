using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class SignatureRepository:ISignatureRepository
    {
         private string connectionString;
        public SignatureRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<IEnumerable<GetSignatureDTO>> GetSignatureAsync()
        {
            using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetSignatureDTO>("sp_GetAllSignatures",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
    }
}