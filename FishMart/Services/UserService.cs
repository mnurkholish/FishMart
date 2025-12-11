using FishMart.Models;
using FishMart.Repositories;
using FishMart.Session;
using System.Data;

namespace FishMart.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repo;

        public UserService()
        {
            _repo = new UserRepository();
        }

        public User? GetUserById(int id)
        {
            return _repo.GetUserById(id);
        }

        public bool Create(string email, string password, string username, string noTelp)
        {
            

            // --- VALIDASI EMAIL ---
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email Tidak Valid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // --- VALIDASI PASSWORD ---
            if (password.Length < 6)
            {
                MessageBox.Show("Password harus lebih dari 6 karakter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // --- VALIDASI USERNAME ---
            if (username.Length < 3)
            {
                MessageBox.Show("Username harus lebih dari 3 karakter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // --- VALIDASI NO TELEP ---
            if (noTelp.Length < 10 || noTelp.Length > 15 || !noTelp.All(char.IsDigit))
            {
                MessageBox.Show("Nomor telepon tidak valid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_repo.GetUserByEmail(email) != null)
            {
                MessageBox.Show("Email sudah terpakai. Silahkan gunakan email lain!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(password);

            _repo.Create(new User
            {
                Email = email,
                PasswordHash = hash,
                Username = username,
                NoTelp = noTelp
            });

            return true;
        }

        public bool UpdateUser(int id, string username, string noTelp, string password)
        {
            User user = _repo.GetUserById(id);
            if (user == null) return false;

            // --- VALIDASI USERNAME ---
            if (username.Length < 3)
            {
                MessageBox.Show("Username harus lebih dari 3 karakter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            user.Username = username;

            // --- VALIDASI NO TELEP ---
            if (noTelp.Length < 10 || noTelp.Length > 15 || !noTelp.All(char.IsDigit))
            {
                MessageBox.Show("Nomor telepon tidak valid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            user.NoTelp = noTelp;

            // --- VALIDASI PASSWORD ---
            if (!string.IsNullOrWhiteSpace(password))
            {
                if (password.Length < 6)
                {
                    MessageBox.Show("Password harus lebih dari 6 karakter!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(password);
            }

            _repo.Update(user);

            return true;
        }

        public User? Login(string email, string password)
        {
            var user = _repo.GetUserByEmail(email);
            if (user == null) return null;

            if (!user.IsActive) return null;

            bool valid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            if (!valid) return null;

            UserSession.Id = user.Id;
            UserSession.Username = user.Username;
            UserSession.Email = user.Email;
            UserSession.IsAdmin = user.IsAdmin;

            return user;
        }

        public List<User> GetAllKasir()
        {
            return _repo.GetAkunKasir();
        }

        public void FillWithAkunKasir(DataGridView dgv)
        {
            List<User> listKasir = _repo.GetAkunKasir().OrderBy(u => u.Id).ToList();
            dgv.DataSource = listKasir;
        }

        public void ToggleUserStatus(int userId)
        {
            _repo.ToggleStatus(userId);
        }
    }
}
