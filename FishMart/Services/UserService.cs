
using FishMart.Repositories;
using FishMart.Models;
using BCrypt.Net;

namespace FishMart.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
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

            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash) ? user : null;
        }
    }
}
