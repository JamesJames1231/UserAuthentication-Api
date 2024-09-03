using Microsoft.AspNetCore.Mvc;

namespace UserAuthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost(Name = "UserAuth")]
        public bool Post()
        {
            AuthMessage authMess = new AuthMessage();
            bool response = authMess.CheckLogin("gdes", "test");
            return response; ;
        }
    }
}
