using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class TemplateRepository:ITemplateRepository
    {
        private string connectionString;
        public TemplateRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<AddTemplatesDTO> AddTemplateAsync(AddTemplatesDTO model)
        {
            using (var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<AddTemplatesDTO>("sp_AddTemplate",model,commandType:CommandType.StoredProcedure);
                return(AddTemplatesDTO)result;
            }
        }

        public async Task<DeleteTemplateDTO> DeleteTemplateAsync(DeleteTemplateDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<DeleteTemplateDTO>("sp_DeleteTemplate",model,commandType:CommandType.StoredProcedure);
                return(DeleteTemplateDTO)result;
            }
        }

        public async Task<IEnumerable<GetTemplatesDTO>> GetTemplateAsync()
        {
           using(var conn=Connection)
           {
               var result=await conn.QueryAsync<GetTemplatesDTO>("sp_GetAllTemplate",commandType:CommandType.StoredProcedure);
               return result;
           }
        }

        public async Task<UpdateTemplateDTO> UpdateTemplateAsync(UpdateTemplateDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<UpdateTemplateDTO>("sp_UpdateTemplate",model,commandType:CommandType.StoredProcedure);
                return(UpdateTemplateDTO)result;
            }
        }
    }
}