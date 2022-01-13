using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
     public class TechnicianRepository : ITechnicianRepository
     {
          private string connectionString;
        public TechnicianRepository()
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
         public async Task<IEnumerable<GetTechnicianDTO>> GetTechnicianAsync()
        {
            using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetTechnicianDTO>("sp_GetTechnician",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
     }
}