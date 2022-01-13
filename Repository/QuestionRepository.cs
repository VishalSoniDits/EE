using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    
    public class QuestionRepository:IQuestionRepository
    {
         private string connectionString;
        public QuestionRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<AddQuestionDTO> AddQuestionAsync(AddQuestionDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<AddQuestionDTO>("sp_AddQuestion",model,commandType:CommandType.StoredProcedure);
                return(AddQuestionDTO)result;
            }
        }

        public async Task<DeleteQuestionDTO> DeleteQuestionAsync(DeleteQuestionDTO model)
        {
           using(var conn=Connection)
           {
               var result=await conn.QuerySingleAsync<DeleteQuestionDTO>("sp_DeleteQuestion",model,commandType:CommandType.StoredProcedure);
               return(DeleteQuestionDTO)result;
           }
        }

        public async Task<IEnumerable<GetQuestioDTO>> GetQuestionAsync()
        {
              using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetQuestioDTO>("sp_GetAllQuestion",commandType:CommandType.StoredProcedure);
                return result;
            }
        }

        public async Task<UpdateQuestionDTO> UpdateQuestionAsync(UpdateQuestionDTO model)
        {
        using(var conn=Connection){
            var result=await conn.QuerySingleAsync<UpdateQuestionDTO>("sp_UpdateQuestion",model,commandType:CommandType.StoredProcedure);
            return(UpdateQuestionDTO)result;
        }
        }
    }
}