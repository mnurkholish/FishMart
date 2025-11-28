using DotNetEnv;
using FishMart.Models;
using FishMart.Services;
using FishMart.Session;
using FishMart.Utils;
using FishMart.View;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (user == null) return false;

            Form form;
            if (user.IsAdmin)
            {
                MessageBox.Show("Login Sukses Sebagai Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form = new V_DashboardAdmin();
            }
            else
            {
                MessageBox.Show("Login Sukses Sebagai Kasir", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form = new V_Transaksi();
            }

            form.Show();
            
            return user != null;
        }

        public void logout(Form currentForm)
        {
            UserSession.Clear();
            MessageBox.Show("Logout Berhasil", "Logout", MessageBoxButtons.OK, MessageBoxIcon.None);
            currentForm.Close();
        }
    }
}
