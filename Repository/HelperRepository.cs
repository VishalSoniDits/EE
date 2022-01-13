using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
     public class HelperRepository : IHelperRepository
     {
          private string connectionString;
        public HelperRepository()
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
         public async Task<IEnumerable<GetHelperDTO>> GetHelperAsync()
        {
            using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetHelperDTO>("sp_GetHelper",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
     }
}