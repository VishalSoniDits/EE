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
            connectionString= @"Server=DITSDEV12\SQLEXPRESS;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<ResponseDTO> AddCategoryAsync(AddCategoryDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddCategorys",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }

        public async Task<ResponseDTO> DeleteCategoryAsync(DeleteCategoryDTO model)
        {
            using(var conn=Connection){
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteCategorys",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
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

        public async Task<ResponseDTO> UpdateCategoryAsync(UpdateCategoryDTO model)
        {
            using (var conn=Connection){
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateCategorys",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }
        public async Task<IEnumerable<GetCategoryDTO>> GetSearchCategoryAsync(GetSearchCategoryDTO model)
        {
             using (var conn = Connection)
           {
        var result = await conn.QueryAsync<GetCategoryDTO>("sp_Search_category",model,commandType:CommandType.StoredProcedure);
         return result;
          }
        }
    }
}