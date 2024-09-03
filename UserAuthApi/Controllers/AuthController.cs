using Microsoft.AspNetCore.Mvc;

namespace UserAuthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost(Name = "UserAuth")]
        public string Post()
        {
            return "heheh";
        }
    }
}
