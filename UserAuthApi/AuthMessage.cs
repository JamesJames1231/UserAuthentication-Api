using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace UserAuthApi
{
    public class AuthMessage
    {
        string DbPath = "users.db";
        public string CheckLogin(string username, string password)
        {
            var conn = new SqliteConnection($"Data Source ={DbPath}");
            conn.OpenAsync();

            using var cmd = new SqliteCommand("CREATE DATABASE users;");
            //Checking to ensure a blank string hasn't appeared
            if (username != "" && password != "") {
                
                 
                return "Success";
            }
            else
            {
                return "Please Provide a Usernmae and a Password.";
            }
        }
    }
}
