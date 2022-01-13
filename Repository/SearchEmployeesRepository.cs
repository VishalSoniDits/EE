using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class SearchEmployeesRepository:ISearchEmployeesRepository
    {
         private string connectionString;
        public SearchEmployeesRepository()
        {
            connectionString= @"Server=DITSDEV46;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<IEnumerable<GetEmployeesDTO>> GetSearchEmployeesAsync(GetSearchEmployeesDTO model)
        {
             using (var conn = Connection)
           {
        var result = await conn.QueryAsync<GetEmployeesDTO>("sp_SearchEmployees",model,commandType:CommandType.StoredProcedure);
         return result;
          }
        }

        // public async Task<IEnumerable<GetSearchEmployeesDTO>> GetSearchEmployeesAsync()
        // {
        //     using (var conn = Connection)
        //     {
        //     var result = await conn.QueryAsync<GetSearchEmployeesDTO>("sp_Search_Employees",commandType:CommandType.StoredProcedure);
        //         return result;
        //     }
    }      
    }
