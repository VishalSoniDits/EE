using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
     public class JobFolderRepository : IJobFolderRepository
     {
          private string connectionString;
        public JobFolderRepository()
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
         public async Task<IEnumerable<GetJobFolderDTO>> GetJobFolderAsync()
        {
            using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetJobFolderDTO>("sp_GetJob_Folder",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
        public async Task<AddJobFolderDTO> AddJobFolderAsync(AddJobFolderDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<AddJobFolderDTO>("sp_AddJob_Folder",model,commandType:CommandType.StoredProcedure);
                return (AddJobFolderDTO)result;
            }
        }
        public async Task<UpdateJobFolderDTO> UpdateJobFolderAsync(UpdateJobFolderDTO model)
        {
             using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<UpdateJobFolderDTO>("sp_UpdateJob_Folder",model,commandType:CommandType.StoredProcedure);
                return (UpdateJobFolderDTO)result;
            }
        }
        public async Task<DeleteJobFolderDTO> DeleteJobFolderAsync(DeleteJobFolderDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<DeleteJobFolderDTO>("sp_DeleteJob_Folder",model,commandType:CommandType.StoredProcedure);
                return (DeleteJobFolderDTO)result;
            }
        }
    }

    }