using OOP04.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Classes
{
    internal class User
    {
        public string UserName;

        public string Password;

        public Role role;

        public User(string userName, string password, Role role)
        {
            UserName = userName;
            Password = password;
            this.role = role;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"UserName = {UserName} , Password = {Password} , Role = {role}");
        }
    }
}
