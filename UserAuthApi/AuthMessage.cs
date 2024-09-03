namespace UserAuthApi
{
    public class AuthMessage
    {
        string u = "test";
        string p = "test";
        public bool CheckLogin(string username, string password)
        {
            if (u == username && p == password) {
                return true;
            }
            return false;
        }   
    }
}
