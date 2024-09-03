using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;

namespace UserAuthApi
{
    public class Password_Hash
    {
        public byte[] CalculateSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] hashValue;
            UTF8Encoding objUtf8 = new UTF8Encoding();

            hashValue = sha256.ComputeHash(objUtf8.GetBytes(str));

            //I would add a salt but its really not that big of a deal for this small project
            return hashValue;
        }
    }
}
