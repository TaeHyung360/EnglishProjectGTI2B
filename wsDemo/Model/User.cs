using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace wsDemo.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public TypeUser Type { get; set; }

        public User()
        {
            Type = TypeUser.NotFound;
        }

        public User(int id, string email, string password, string name, TypeUser type)
        {
            Id = id;
            Email = email;
            Password = password;
            Name = name;
            Type = type;

        }

        public User(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            Email = reader.GetString(1);
            Password = reader.GetString(2);
            Name = reader.GetString(4);
            Type = (TypeUser)reader.GetInt32(3);

        }

    }

    public enum TypeUser
    {
        Client = 1,
        Receptionist = 2,
        NotFound
    }
}