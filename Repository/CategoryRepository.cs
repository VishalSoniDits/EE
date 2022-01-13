using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class CategoryRepository:ICategoryRepository
    {
         private string connectionString;
        public CategoryRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<AddCategoryDTO> AddCategoryAsync(AddCategoryDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<AddCategoryDTO>("sp_AddCategorys",model,commandType:CommandType.StoredProcedure);
                return(AddCategoryDTO)result;
            }
        }

        public async Task<DeleteCategoryDTO> DeleteCategoryAsync(DeleteCategoryDTO model)
        {
            using(var conn=Connection){
                var result=await conn.QuerySingleAsync<DeleteCategoryDTO>("sp_DeleteCategorys",model,commandType:CommandType.StoredProcedure);
                return(DeleteCategoryDTO)result;
            }
        }

        public async Task<IEnumerable<GetCategoryDTO>> GetCategoryAsync()
        {
             using(var conn=Connection)
             {
                 var result= await conn.QueryAsync<GetCategoryDTO>("sp_GetAllCategory",commandType:CommandType.StoredProcedure);
                 return result;
             }
        }

        public async Task<UpdateCategoryDTO> UpdateCategoryAsync(UpdateCategoryDTO model)
        {
            using (var conn=Connection){
                var result=await conn.QuerySingleAsync<UpdateCategoryDTO>("sp_UpdateCategorys",model,commandType:CommandType.StoredProcedure);
                return(UpdateCategoryDTO)result;
            }
        }
    }
}