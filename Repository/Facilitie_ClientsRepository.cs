using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class Facilitie_ClientsRepository:IFacilitie_ClientsRepository
    {
        private string connectionString;
        public Facilitie_ClientsRepository()
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

        public async Task<ResponseDTO> AddFacilite_ClientsAsync(AddFacilite_ClientsDTO model)
        {
           using(var conn=Connection)
           {
               var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddFacilite_Clients",model,commandType:CommandType.StoredProcedure);
               return(ResponseDTO)result;
           }
        }

        public async Task<ResponseDTO> DeleteFacilite_ClientsAsync(DeleteFacilite_ClientsDTO model)
        {
             using(var conn=Connection)
           {
               var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteFacilite_Clients",model,commandType:CommandType.StoredProcedure);
               return(ResponseDTO)result;
           }
        }

        public async Task<IEnumerable<GetFacilitie_ClientsDTO>> GetFacilite_ClientsAsync()
        {
          using(var conn=Connection)
          {
              var result=await conn.QueryAsync<GetFacilitie_ClientsDTO>("sp_GetAllFacilite_Clients",commandType:CommandType.StoredProcedure);
              return result;
          }
        }

        public async Task<ResponseDTO> UpdateFacilite_ClientsAsync(UpdateFacilite_ClientsDTO model)
        {
          using(var conn=Connection)
          {
              var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateFacilite_Clients",model,commandType:CommandType.StoredProcedure);
              return(ResponseDTO)result;
          }
        }
    }
}