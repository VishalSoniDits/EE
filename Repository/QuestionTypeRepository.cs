using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class QuestionTypeRepository:IQuestionTypeRepository
    {
          private string connectionString;
        public QuestionTypeRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<AddQuestionTypeDTO> AddQuestionTypeAsync(AddQuestionTypeDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<AddQuestionTypeDTO>("sp_AddQuestion_Type",model,commandType:CommandType.StoredProcedure);
                return(AddQuestionTypeDTO)result;
            }
        }

        public async Task<DeleteQuestionTypeDTO> DeleteQuestionTypeAsync(DeleteQuestionTypeDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<DeleteQuestionTypeDTO>("sp_DeleteQuestionType",model,commandType:CommandType.StoredProcedure);
                return(DeleteQuestionTypeDTO)result;
            }
        }

        public async Task<IEnumerable<GetQuestionTypeDTO>> GetQuestionTypeAsync()
        {
              using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetQuestionTypeDTO>("sp_GetAllQuestionTypes",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<UpdateQuestiontypeDTO> UpdateQuestionTypeAsync(UpdateQuestiontypeDTO model)
        {
           using(var conn=Connection)
           {
               var result=await conn.QuerySingleAsync<UpdateQuestiontypeDTO>("sp_UpdateQuestionType",model,commandType:CommandType.StoredProcedure);
               return(UpdateQuestiontypeDTO)result;
           }
        }
    }
}