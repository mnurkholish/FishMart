using FishMart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Controller
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
        public bool createUser(string email, string password, string username, string noTelp)
        {
            var user = _userService.Create(email, password, username, noTelp);
            return user;
        }
    }
}
