using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Besar_1214081_1214085.model
{
    internal class M_User
    {
        string name, username, password, role;

        public M_User()
        {

        }

        public M_User(string name, string username, string password, string role)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
