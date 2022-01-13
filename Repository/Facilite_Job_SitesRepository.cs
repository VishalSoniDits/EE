using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class Facilite_Job_SitesRepository:IFacilite_Job_SitesRepository
    {
        private string connectionString;
        public Facilite_Job_SitesRepository()
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

        public async Task<ResponseDTO> AddFacilite_Job_SitesAsync(AddFacilite_Job_SitesDTO model)
        {
              using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddFacilite_Job_Sites",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<ResponseDTO> DeleteFacilite_Job_SitesAsync(DeleteFacilite_Job_SitesDTO model)
        {
              using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteFacilite_Job_Sites",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<IEnumerable<GetFacilite_Job_SitesDTO>> GetFacilite_Job_SitesAsync()
        {
            using (var conn=Connection)
            {
                var result=await conn.QueryAsync<GetFacilite_Job_SitesDTO>("sp_GetAllFacilite_Job_Sites",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<ResponseDTO> UpdateFacilite_Job_SitesAsync(UpdateFacilite_Job_SitesDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateFacilite_Job_Sites",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }
    }
}