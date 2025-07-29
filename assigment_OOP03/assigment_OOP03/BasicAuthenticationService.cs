using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_OOP03
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, (string Password, string Role)> _users = new()
    {
        { "admin", ("admin123", "Administrator") },
        { "user1", ("pass123", "User") }
    };

        public bool AuthenticateUser(string username, string password)
        {
            if (_users.ContainsKey(username))
            {
                return _users[username].Password == password;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (_users.ContainsKey(username))
            {
                return _users[username].Role == role;
            }
            return false;
        }
    }
}
