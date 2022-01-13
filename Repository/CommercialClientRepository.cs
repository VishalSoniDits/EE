using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class CommercialClientRepository:ICommercialClientRepository
    {
       public string connectionString;
       public CommercialClientRepository()
       {
           connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
       }
       public IDbConnection Connection
       {
           get{
               return new SqlConnection(connectionString);
           }
       }

        public async Task<ResponseDTO> AddCommercialClientAsync(AddCommercialClientDTO model)
        {
            using(var conn=Connection){
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddCommercialClient",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<ResponseDTO> DeleteCommercialClientAsync(DeleteCommercialClientDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteCommercialClient",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<IEnumerable<GetCommercialClientDTO>> GetCommercialClientAsync()
        {
           using(var conn=Connection){
               var result=await conn.QueryAsync<GetCommercialClientDTO>("sp_GetAllCommercialClient",commandType:CommandType.StoredProcedure);
               return result;
           }
        }

        public async Task<ResponseDTO> UpdateCommercialClientAsync(UpdateCommercialClientDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateCommercialClient",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }
    }
}