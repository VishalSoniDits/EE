using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class SupplierRepository:ISupplierRepository
    {
          private string connectionString;
        public SupplierRepository()
        {
            connectionString= @"Server=DESKTOP-4P5GAT6\SQLEXPRESS;Database=EE;Trusted_Connection=true;";
        }

          public IDbConnection Connection
        {
            get{
                return new SqlConnection(connectionString);
            }
        }

        public async Task<ResponseDTO> AddSupplierAsync(AddSupplierDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_AddSupplier",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;

            }
        }

        public async Task<ResponseDTO> DeleteSupplierAsync(DeleteSupplierDTO model)
        {
           using(var conn=Connection)
           {
               var result=await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteSupplier",model,commandType:CommandType.StoredProcedure);
               return(ResponseDTO)result;
           }
        }

        public async Task<IEnumerable<GetSupplierDTO>> GetSupplierAsync()
        {
            using(var conn=Connection)
             {
                 var result= await conn.QueryAsync<GetSupplierDTO>("sp_GetAllSupplier",commandType:CommandType.StoredProcedure);
                 return result;
             } 
        }

        public async Task<ResponseDTO> UpdateSupplierAsync(UpdateSupplierDTO model)
        {
            using(var conn=Connection)
            {
                var result=await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateSupplier",model,commandType:CommandType.StoredProcedure);
                return(ResponseDTO)result;
            }
        }
    }
}