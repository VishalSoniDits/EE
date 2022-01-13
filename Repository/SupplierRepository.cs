using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using EE.Models;
using EE.Repository;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
     public class SupplierRepository : ISupplierRepository
     {
          private string connectionString;
        public SupplierRepository()
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
         public async Task<IEnumerable<GetSupplierDTO>> GetSupplierAsync()
        {
            using (var conn = Connection)
            {
            var result = await conn.QueryAsync<GetSupplierDTO>("sp_GetAllSupplier",commandType:CommandType.StoredProcedure);
                return result;
            }
        }
        public async Task<AddSupplierDTO> AddSupplierAsync(AddSupplierDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<AddSupplierDTO>("sp_AddSupplier",model,commandType:CommandType.StoredProcedure);
                return (AddSupplierDTO)result;
            }
        }
        public async Task<UpdateSupplierDTO> UpdateSupplierAsync(UpdateSupplierDTO model)
        {
             using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<UpdateSupplierDTO>("sp_UpdateSupplier",model,commandType:CommandType.StoredProcedure);
                return (UpdateSupplierDTO)result;
            }
        }
        public async Task<DeleteSupplierDTO> DeleteSupplierAsync(DeleteSupplierDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<DeleteSupplierDTO>("sp_DeleteSupplier",model,commandType:CommandType.StoredProcedure);
                return (DeleteSupplierDTO)result;
            }
        }
    }

    }
