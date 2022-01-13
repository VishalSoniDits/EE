using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class ResidentialJobSiteRepository:IResidentialJobSiteRepository
    {
          private string connectionString;
        public ResidentialJobSiteRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<ResponseDTO> AddResidentialJobSiteAsync(AddResidentialJobSiteDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddResidentialJobSite",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<ResponseDTO> DeleteResidentialJobSiteAsync(DeleteResidentialJobSiteDTO model)
        {
           using(var conn=Connection)
           {
              var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteResidentialJobSite",model,commandType:CommandType.StoredProcedure);
              return(ResponseDTO)result; 
           }
        }

        public async Task<IEnumerable<GetResidentialJobSiteDTO>> GetResidentialJobSiteAsync()
        {
           using(var conn=Connection)
           {
               var result=await conn.QueryAsync<GetResidentialJobSiteDTO>("sp_GetAllResidentialJobSite",commandType:CommandType.StoredProcedure);
               return result;
           }
        }

        public async Task<ResponseDTO> UpdateResidentialJobSiteAsync(UpdateResidentialJobSiteDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateResidentialJobSite",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }
    }
}