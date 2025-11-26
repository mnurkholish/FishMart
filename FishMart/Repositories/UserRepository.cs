
using FishMart.Models;
using FishMart.Utils;
using Npgsql;
using System.Data;

namespace FishMart.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User? GetUserByEmail(string email)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(
                @"SELECT id, email, password_hash, username, no_telp, is_admin
                  FROM users 
                  WHERE email = @e", conn);
            cmd.Parameters.AddWithValue("@e", email);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return new User
            {
                Id = reader.GetInt32(0),
                Email = reader.GetString(1),
                PasswordHash = reader.GetString(2),
                Username = reader.GetString(3),
                NoTelp = reader.GetString(4),
                IsAdmin = reader.GetBoolean(5)
            };
        }

        public void Create(User user)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(
                @"INSERT INTO users(email, password_hash, username, no_telp)
                VALUES(@e, @p, @u, @n)", conn);

            cmd.Parameters.AddWithValue("@e", user.Email);
            cmd.Parameters.AddWithValue("@p", user.PasswordHash);
            cmd.Parameters.AddWithValue("@u", user.Username);
            cmd.Parameters.AddWithValue("@n", user.NoTelp);

            cmd.ExecuteNonQuery();
        }

        public DataTable GetAkunKasir()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var data = new NpgsqlDataAdapter(
                @"SELECT id, email, password_hash, username, no_telp
                  FROM users 
                  WHERE is_admin = false", conn);

            DataTable dt = new DataTable();
            data.Fill(dt);
            return dt;
        }
    }
}
