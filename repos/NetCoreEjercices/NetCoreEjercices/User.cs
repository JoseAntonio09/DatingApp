using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreEjercices
{
    internal class User
    {
        private ConsoleNotification _notificationService;

        public User(string username)
        {
            Username = username;
            _notificationService = new ConsoleNotification();
        }
        public string Username { get; private set; }

        public void ChangeUsername(string newUsername)
        {
            Username = newUsername;
            _notificationService.NotifyUsernameChanged(this);
        }
    }
      
}
