using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class MaterialRepository:IMaterialRepository
    {
          private string connectionString;
        public MaterialRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<IEnumerable<GetMaterialDTO>> GetMaterialAsync()
        {
            using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetMaterialDTO>("sp_GetAllMaterial",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
    }
}