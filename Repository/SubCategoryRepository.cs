using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class SubCategoryRepository:ISubCategoryRepository
    {
        private string connectionString;
        public SubCategoryRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<AddSubCategoryDTO> AddSubCategoryAsync(AddSubCategoryDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<AddSubCategoryDTO>("sp_AddSubCategorys",model,commandType:CommandType.StoredProcedure);
                return(AddSubCategoryDTO)result;
            }
        }

        public async Task<DeleteSubCategoryDTO> DeleteSubCategoryAsync(DeleteSubCategoryDTO model)
        {
        using(var conn=Connection)
        {
            var result=await conn.QuerySingleAsync<DeleteSubCategoryDTO>("sp_DeleteSubCategorys",model,commandType:CommandType.StoredProcedure);
            return(DeleteSubCategoryDTO)result;
          }
        }

        public async Task<IEnumerable<GetSubCategorysDTO>> GetSubCategoryAsync()
        {
            using (var conn=Connection)
            {
                var result=await conn.QueryAsync<GetSubCategorysDTO>("sp_GetAllSubCategorys",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<UpdateSubCategoryDTO> UpdateSubCategoryAsync(UpdateSubCategoryDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<UpdateSubCategoryDTO>("sp_UpdateSubCategorys",model,commandType:CommandType.StoredProcedure);
                return(UpdateSubCategoryDTO)result;
            }
        }
    }
}