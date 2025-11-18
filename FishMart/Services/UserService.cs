
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

        public bool Register(string username, string password)
        {
            if (_repo.GetByEmail(username) != null)
                return false;

            string hash = BCrypt.Net.BCrypt.HashPassword(password);

            _repo.Create(new User
            {
                Username = username,
                PasswordHash = hash
            });

            return true;
        }

        public User? Login(string email, string password)
        {
            var user = _repo.GetByEmail(email);
            if (user == null) return null;

            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash) ? user : null;
        }
    }
}
