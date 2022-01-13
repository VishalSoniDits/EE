using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class CommercialJobSiteRepository:ICommercialJobSiteRepository
    {
         public string connectionstring;
         public  CommercialJobSiteRepository()
         {
          connectionstring= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
         }
         public IDbConnection  Connection
         {
             get
             {
               return new SqlConnection (connectionstring);
             }
         }

        public async Task<ResponseDTO> AddCommercialJobSiteAsync(AddCommercialJobSiteDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddCommercialJobSite",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<ResponseDTO> DeleteCommercialJobSiteAsync(DeleteCommercialJobSiteDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteCommercialJobSite",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<IEnumerable<GetCommercialJobSiteDTO>> GetCommercialJobSiteAsync()
        {
            using(var conn=Connection)
            {
                var result=await conn.QueryAsync<GetCommercialJobSiteDTO>("sp_GetAllCommercialJobSite",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<ResponseDTO> UpdateCommercialJobSiteAsync(UpdateCommercialJobSiteDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateCommercialJobSite",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }
    }
}