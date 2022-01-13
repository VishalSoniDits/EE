using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class PricingRepository:IPricingRepository
    {
         private string connectionString;
        public PricingRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<ResponseDTO> AddPricingAsync(AddPricingDTO model)
        {
           using(var conn=Connection)
           {
               var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddPricing",model,commandType:CommandType.StoredProcedure);
               return(ResponseDTO)result;
           }
        }

        public async Task<ResponseDTO> DeletePricingAsync(DeletePricingDTO model)
        {
          using(var conn=Connection)
          {
              var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeletePricing",model,commandType:CommandType.StoredProcedure);
              return(ResponseDTO)result;
          }
        }

        public async Task<IEnumerable<GetPricingDTO>> GetPricingAsync()
        {
            using(var conn=Connection)
            {
                var result=await conn.QueryAsync<GetPricingDTO>("sp_GetAllPricing",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<ResponseDTO> UpdatePricingAsync(UpdatePricingDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdatePricing",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }
    }
}