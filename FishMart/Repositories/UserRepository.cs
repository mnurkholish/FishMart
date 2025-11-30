
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
                @"SELECT id, email, password_hash, username, no_telp, is_admin, is_active
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
                IsAdmin = reader.GetBoolean(5),
                IsActive = reader.GetBoolean(6)
            };
        }

        public User? GetUserById(int id)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(
                @"SELECT id, email, password_hash, username, no_telp, is_admin, is_active
                  FROM users 
                  WHERE id = @i", conn);
            cmd.Parameters.AddWithValue("@i", id);

            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;

            return new User
            {
                Id = reader.GetInt32(0),
                Email = reader.GetString(1),
                PasswordHash = reader.GetString(2),
                Username = reader.GetString(3),
                NoTelp = reader.GetString(4),
                IsAdmin = reader.GetBoolean(5),
                IsActive = reader.GetBoolean(6)
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

        public void Update(User user)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(
                @"UPDATE users SET 
                username = @u,
                no_telp = @nt,
                password_hash = @p
                WHERE id = @id;", conn);

            cmd.Parameters.AddWithValue("@u", user.Username);
            cmd.Parameters.AddWithValue("@nt", user.NoTelp);
            cmd.Parameters.AddWithValue("@p", user.PasswordHash);
            cmd.Parameters.AddWithValue("@id", user.Id);

            cmd.ExecuteNonQuery();
        }

        public List<User> GetAkunKasir()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            SELECT id, email, username, no_telp, is_active
            FROM users
            WHERE is_admin = false;";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            List<User> list = new List<User>();

            while (reader.Read())
            {
                list.Add(new User
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Email = reader.GetString(reader.GetOrdinal("email")),
                    Username = reader.GetString(reader.GetOrdinal("username")),
                    NoTelp = reader.GetString(reader.GetOrdinal("no_telp")),
                    IsActive = reader.GetBoolean(reader.GetOrdinal("is_active"))
                });
            }

            return list;
        }

        public void ToggleStatus(int userId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            
            var query = @"UPDATE Users SET is_active = NOT is_active WHERE Id = @UserId";
            
            using var cmd = new NpgsqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@UserId", userId);
            
            cmd.ExecuteNonQuery();
        }
    }
}
