using Microsoft.AspNetCore.Mvc;

namespace UserAuthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost(Name = "UserAuth")]
        public bool Post([FromBody] string username, [FromBody] string password)
        {
            //Accepting string passwords over HTTPS appears to be the industry standard, which is good as it means I do not have to encrypt in every app I build
            //Calls my auth function
            AuthMessage authMess = new AuthMessage();
            bool response = authMess.CheckLogin(username, password);
            return response;
        }
    }
}
