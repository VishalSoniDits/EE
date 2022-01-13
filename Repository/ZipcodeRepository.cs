using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class ZipcodeRepository:IZipcodeRepository
    {
           private string connectionString;
        public ZipcodeRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<ResponseDTO> AddZipcodeAsync(AddZipcodeDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddZipCode",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<ResponseDTO> DeleteZipcodeAsync(DeleteZipcodeDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteZipCode",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<IEnumerable<GetZipcodeDTO>> GetZipcodeAsync()
        {
            using(var conn=Connection)
            {
                var result=await conn.QueryAsync<GetZipcodeDTO>("sp_GetAllZipCode",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<ResponseDTO> UpdateZipcodeAsync(UpdateZipcodeDTO model)
        {
          using(var conn=Connection)
          {
              var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateZipCode",model,commandType:CommandType.StoredProcedure);
              return(ResponseDTO)result;
          }
        }
    }
}