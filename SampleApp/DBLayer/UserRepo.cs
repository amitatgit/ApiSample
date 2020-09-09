using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBLayer
{
    public class UserRepo: IUserRepo
    {
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Users\akumar\source\repos\SampleApp\DBLayer\DB.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User]", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                users.Add(new User()
                {
                    UserId = (int)reader["UserId"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Email = reader["Email"].ToString()
                });
            }
            return users;
        }
    }
}
