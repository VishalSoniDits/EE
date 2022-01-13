using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
     public class LoginRepository : ILoginRepository
     {
          private string connectionString;
        public LoginRepository()
        {        
            connectionString = @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }
        public IDbConnection Connection
        {
        get
        {
        return new SqlConnection(connectionString);
        }  
    }  

        public async Task<ResponseDTO> LoginAsync(LoginDTO model)
        {           
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<ResponseDTO>("sp_Login",model,commandType:CommandType.StoredProcedure);
                return (ResponseDTO)result;
            }       
        }
        public async Task<ResponseDTO> UpdatePasswordAsync(ChangePasswordDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_ChangeCurrentPassword",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            } 
    }
}
}