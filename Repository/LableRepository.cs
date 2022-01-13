using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class LableRepository:ILableRepository
    {
         private string connectionString;
        public LableRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<AddLableDTO> AddLableAsync(AddLableDTO model)
        {
            using (var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<AddLableDTO>("sp_AddLable",model,commandType:CommandType.StoredProcedure);
                return(AddLableDTO)result;
            }
        }

        public async Task<DeleteLableDTO> DeleteLableAsync(DeleteLableDTO model)
        {
            using(var conn=Connection){
                var result=await conn.QuerySingleAsync<DeleteLableDTO>("sp_DeleteLable",model,commandType:CommandType.StoredProcedure);
                return(DeleteLableDTO)result;
            }
        }

        public async Task<IEnumerable<GetLableDTO>> GetLableAsync()
        {
            using(var conn=Connection)
            {
                var result=await conn.QueryAsync<GetLableDTO>("sp_GetAllLable",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<UpdateLableDTO> UpdateLableAsync(UpdateLableDTO model)
        {
            using (var conn=Connection){
                var result=await conn.QuerySingleAsync<UpdateLableDTO>("sp_UpdateLable",model,commandType:CommandType.StoredProcedure);
                return(UpdateLableDTO)result;
            }
        }
    }
}