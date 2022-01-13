using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using Dapper;
using EE.Common;
using EE.Models;
using EE.Repository;
using Microsoft.Data.SqlClient;

namespace EE.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private string ImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "BookImage");
        private string connectionString;
        public EmployeesRepository()
        {
            connectionString = @"Server=DITSDEV12\SQLEXPRESS;Database=EE;Trusted_Connection=true;";
        }
        // private string LocationPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Upload", "ProductImage");
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
        public async Task<IEnumerable<GetEmployeesDTO>> GetEmployeesAsync()
        {
            using (var conn = Connection)
            {
                var result = await conn.QueryAsync<GetEmployeesDTO>("sp_GetEmployeeDetails", commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public async Task<ResponseDTO> AddEmployeesAsync(AddEmployeesDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<ResponseDTO>("sp_AddEmployees", model, commandType: CommandType.StoredProcedure);
                return (ResponseDTO)result;
            }
        }
        public async Task<ResponseDTO> UpdateEmployeesAsync(UpdateEmployeesDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<ResponseDTO>("sp_UpdateEmployees", model, commandType: CommandType.StoredProcedure);
                return (ResponseDTO)result;
            }
        }
        public async Task<ResponseDTO> DeleteEmployeesAsync(DeleteEmployeesDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<ResponseDTO>("sp_DeleteEmployee", model, commandType: CommandType.StoredProcedure);
                return (ResponseDTO)result;
            }
        }

        public async Task<AddImageResponseDTO> AddImageAsync(AddImageDTO addImageDTO, string actionPerformedBy)
        {
            try
            {
                var uploadImages = new ImageUpload();
                AddImageData model = new AddImageData();
                model.Image_Type = addImageDTO.Image_Type;
                model.IsActive = true;
                model.ActionPerformedBy = "rajput@gmail.com";
                model.Image_File = uploadImages.UploadImage(ImagePath, "Images", addImageDTO.Image_File);
                using (var conn = Connection)
                {
                    return await conn.QuerySingleAsync<AddImageResponseDTO>("sp_Addimages", param: model, commandType: CommandType.StoredProcedure);
                }
            }
            // catch (System.Exception ex)
            catch (System.Exception ex)
            {
                throw;
            }
        }

        public async Task<ResponseDTO> ChakeEamilAsync(ChakeEamilDTO model)
        {
            using (var conn = Connection)
            {
                var result = await conn.QuerySingleAsync<ResponseDTO>("sp_ChakeEmail", model, commandType: CommandType.StoredProcedure);
                // return(ResponseDTO)result;
                if(result.ResponseCode==200)
                {
               SendEmail Email = new SendEmail();
               Email.SendEmails(model.Email,"This is test Email <a herf=\"http://127.0.0.1:5501/ChangePassword.html\">link</a>","Forgot password",false);
                }
                return result;

            }
        }
    }
}


