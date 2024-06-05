using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Concretes.Linq
{
    public class LinqUserDal
    {
        private SqlConnection connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=RentACar;Trusted_Connection=True;");
        public List<User> GetUser(string userName,string password)
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserName = @userName AND Password = @password", connection);
            command.Parameters.AddWithValue("@userName", userName);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = command.ExecuteReader();

            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UserName = reader["UserName"].ToString(),
                    Password = reader["Password"].ToString(),
                    Role = reader["Role"].ToString() // Role alanını doğru alana güncelledim
                };
                users.Add(user);
            }
            connection.Close();
            return users;
        }


        private void ConnectionControl()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}