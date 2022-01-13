using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class AssignedTemplatesRepository:IAssignedTemplatesRepository
    {
        private string connectionString;
        public AssignedTemplatesRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<ResponseDTO> AddAssignedTemplatesAsync(AddAssignedTemplatesDTO model)
        {
           using (var conn=Connection)
           {
               var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddAssignedTemplates",model,commandType:CommandType.StoredProcedure);
               return(ResponseDTO) result;
           }
        }

        public async Task<ResponseDTO> DeleteAssignedTemplatesAsync(DeleteAssignedTemplatesDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteAssignedTemplates",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<IEnumerable<GetAssignedTemplatesDTO>> GetAssignedTemplatesAsync()
        {
            using(var conn=Connection)
            {
                var result=await conn.QueryAsync<GetAssignedTemplatesDTO>("sp_GetAllAssignedTemplates",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<ResponseDTO> UpdateAssignedTemplatesAsync(UpdateAssignedTemplatesDTO model)
        {
           using(var conn=Connection)
           {
               var result= await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateAssignedTemplates",model,commandType:CommandType.StoredProcedure);
               return(ResponseDTO)result;
           }
        }
    }
}