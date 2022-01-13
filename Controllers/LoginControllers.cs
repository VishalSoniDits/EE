using System;
using System.Security.Claims;
using System.Threading.Tasks;
using EE.Common;
using EE.Models;
using EE.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [HttpPost("CheckLogin")]
        public async Task<IActionResult> AddEmployees([FromBody] LoginDTO model)
        {
            GenerateToken generateToken = new GenerateToken();
            LoginResponse result = new LoginResponse();
            ResponseDTO response = await _loginRepository.LoginAsync(model);
            if (response.ResponseCode != 500)
            {
                Claim[] claims = new[] {
                new Claim("UserId", Convert.ToString(response.Id)),
                 new Claim("Email", model.User_Name),
                new Claim("Role", response.Role)
             };
                result.Token = generateToken.GenerateAccessToken(claims);
                result.RefreshToken = generateToken.GenerateRefreshToken();
                result.Id = response.Id;
                result.ResponseCode = response.ResponseCode;
                result.ResponseMessage = response.ResponseMessage;
                result.Role = response.Role;
                return Ok(result);
            }
            else
            {
                result.ResponseCode = response.ResponseCode;
                result.ResponseMessage = "Login cerdentials not correct!!!!";
            }
            return BadRequest(result);
        }

        [HttpPut("ChangePassword")]
        public async Task<IActionResult> UpdatePassword([FromBody] ChangePasswordDTO model)
        {
            return Ok(await _loginRepository.UpdatePasswordAsync(model));
        }
    }
}