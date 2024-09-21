using OOP04.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces
{
    internal interface IAuthenticationService
    {
        
        bool AuthenticateUser(string UserName , string password);
        

        bool AuthorizeUser(string UserName, Role Role);
    }
}
