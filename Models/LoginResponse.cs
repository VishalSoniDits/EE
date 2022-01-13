namespace EE.Models
{
    public class LoginResponse : ResponseDTO
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }

    }
}