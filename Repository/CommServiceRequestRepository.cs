using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
     public class CommServiceRequestRepository:ICommServiceRequestRepository
     {
        private string connectionString;
        public CommServiceRequestRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<ResponseDTO> AddCommServiceRequestAsync(AddCommServiceRequestDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddCommServiceRequest",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<IEnumerable<GetCommServiceRequestDTO>> GetCommServiceRequestAsync()
        {
            using(var conn=Connection)
            {
                var result=await conn.QueryAsync<GetCommServiceRequestDTO>("sp_GetAllCommServiceRequest",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
    }
}