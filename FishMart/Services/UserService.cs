
using FishMart.Repositories;
using FishMart.Models;
using BCrypt.Net;
using FishMart.Session;

namespace FishMart.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repo;

        public UserService()
        {
            _repo = new UserRepository();
        }

        public bool Create(string email, string password, string username, string noTelp)
        {
            if (_repo.GetUserByEmail(email) != null)
                return false;

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

        public User? Login(string email, string password)
        {
            var user = _repo.GetUserByEmail(email);
            if (user == null) return null;

            bool valid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            if (!valid) return null;

            UserSession.Id = user.Id;
            UserSession.Username = user.Username;
            UserSession.IsAdmin = user.IsAdmin;

            return user;
        }
    }
}
