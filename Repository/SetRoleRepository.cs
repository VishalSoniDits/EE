using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Modes;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class SetRoleRepository:ISetRoleRepository
    {
        private string connectionString;
        public SetRoleRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<IEnumerable<GetSetRoleDTO>> GetSetRoleAsync()
        {
             using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetSetRoleDTO>("sp_GetAllSetRoles",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
    }
}