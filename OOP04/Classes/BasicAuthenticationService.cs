using OOP04.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP04.Enum;

namespace OOP04.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private User[] users = {
            
            new User("Waleed", "33rhw8a3", Role.AdmisAdministrator)
            ,
            new User("Mohamed", "90909090", Role.Guest)
            ,
            new User("Ali", "aad2q", Role.User)
        };
        public bool AuthenticateUser(string UserName , string Password)
        {
            foreach(User user in users)
            {
                if(user.UserName == UserName && user.Password == Password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string UserName , Role role)
        {
         foreach(User user in users)
            {
                if(user.UserName == UserName && user.role == role)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
