namespace SalesSystem.API.Models
{
    public class AuthenticateResponse
    {
        public AuthenticateResponse()
        {

        }
        public AuthenticateResponse(string token)
        {
            Token = token;
        }
        public string Token { get; set; }
        public string Error { get; set; }
    }
}
