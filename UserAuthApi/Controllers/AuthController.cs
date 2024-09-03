using Microsoft.AspNetCore.Mvc;

namespace UserAuthApi.Controllers
{
    [ApiController]
    [Route("LoginRequest")]
    public class AuthController : ControllerBase
    {
        [HttpPost(Name = "LoginRequest")]
        public string Post([FromBody] string userpass)
        {
            //Accepting string passwords over HTTPS appears to be the industry standard, which is good as it means I do not have to encrypt in every app I build
            string[] words = userpass.Split(':');
            string username = words[0].Trim();
            string password = words[1].Trim();
            
            //Calls my auth function
            AuthMessage authMess = new AuthMessage();
            string response = authMess.CheckLogin(username, password);

            return response;
        }
    }
}
