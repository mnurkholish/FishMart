using FishMart.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishMart.Utils;
using FishMart.Services;

namespace FishMart.Controller
{
    public class AuthController
    {
        private readonly UserService _service;

        public AuthController()
        {
            _service = new UserService();
        }

        public bool Login(string username, string password)
        {
            var user = _service.Login(username, password);
            return user != null;
        }
    }
}
