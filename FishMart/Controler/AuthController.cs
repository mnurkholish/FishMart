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

namespace FishMart.Controler
{
    public class AuthController
    {
        public void Login()
        {
            using var conn = Database.GetConnection();

            try
            {
                
                conn.Open();
                MessageBox.Show("Koneksi ke Neon berhasil!");

                // Tes query
                using var cmd = new NpgsqlCommand("SELECT version()", conn);
                var version = cmd.ExecuteScalar();
                MessageBox.Show("Postgres version: " + version);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal konek: " + ex.Message);
            }
        }

    }
}
