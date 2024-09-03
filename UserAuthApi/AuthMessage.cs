using System;
using System.Diagnostics;
using System.Text.Json;
using Microsoft.Data.Sqlite;

namespace UserAuthApi
{
    public class AuthMessage
    {
        string DbPath = "users.db";
        public string CheckLogin(string username, string password)
        {    
            //Checking to ensure a blank string hasn't appeared
            if (username != "" && password != "") {
                try
                {
                    var sql = "SELECT id, username, password FROM logins WHERE username = @username AND password = @password LIMIT 1;";
                    var connection = new SqliteConnection("Data Source=users.db");
                    connection.Open();

                    using var command = new SqliteCommand(sql, connection);
                    //Inserting user provided details
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    string id = "";

                    using var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //Will always return only a single value anyways
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0).ToString();
                            var user = reader.GetString(1);
                            var pass = reader.GetString(2);
                        }
                    }
                    else
                    {
                        connection.Close();
                        return "Username or Passwored Incorrect.";
                    }

                    connection.Close();
                    return id;
                }
                catch (Exception e)
                {
                    //Whoops most likely db file deleted by admin
                    Console.WriteLine(e.Message);
                    return "Connection to database failed.";
                }
            }
            else
            {
                //Asking user for values
                return "Please Provide a Usernmae and a Password.";
            }
        }
    }
}
