using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces
{
    internal interface INotificationService
    {
        public void SendNotification(string recipient , string message);
    }
}
