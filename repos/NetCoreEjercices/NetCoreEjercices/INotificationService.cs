using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEjercices
{
    internal interface INotificationService
    {
        void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"Username has been changed to:{user.Username} ");
        }
    }
}
