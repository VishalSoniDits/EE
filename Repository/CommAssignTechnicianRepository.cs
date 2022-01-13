using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
     public class CommAssignTechnicianRepository:ICommAssignTechnicianRepository 
     {
          private string connectionString;
        public CommAssignTechnicianRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<ResponseDTO> AddCommAssignTechnicianAsync(AddCommAssignTechnicianDTO model)
        {
           using (var conn=Connection)
           {
               var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddCommAssignTechnician",model,commandType:CommandType.StoredProcedure);
               return(ResponseDTO)result;
           }
        }

        public Task<ResponseDTO> AddResidentialAssignTechnicianAsync(AddCommAssignTechnicianDTO model)
        {
            throw new System.NotImplementedException();
        }
    }
}