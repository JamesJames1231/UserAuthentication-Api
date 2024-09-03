using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace UserAuthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Hash
    {
        [HttpPost(Name = "Hash")]
        public byte[] post([FromBody] string str)
        {
            var passHash = new Password_Hash();
  
            return passHash.CalculateSHA256(str);
        }
    }
}
