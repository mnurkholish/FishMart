using FishMart.Models;

namespace FishMart.Repositories
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        User GetUserById(int id);
        void Create(User user);
        void Update(User user);
        List<User> GetAkunKasir();
        void ToggleStatus(int userId);
    }
}
