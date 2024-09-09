using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBiteApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string NomorHp { get; set; }
        public string Location { get; set; }

        public void Register()
        {
            // Logic for registering user
        }

        public void Login()
        {
            // Logic for user login
        }

        public void Logout()
        {
            // Logic for user logout
        }
    }
}
