using FishMart.DataBase;
using FishMart.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Controler
{
    public class AuthController
    {
        private dbContext _dbContext;

        public AuthController()
        {
            _dbContext = new dbContext();
        }

        public bool Login(Akun akun)
        {
            using (var conn = new NpgsqlConnection(_dbContext.connStr))
            {
                conn.Open();
                string query = "SELECT 1 FROM users WHERE email = @email AND password = @password LIMIT 1";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", akun.Email);
                    cmd.Parameters.AddWithValue("@password", akun.Password);

                    using (var read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }
        }

    }
}
