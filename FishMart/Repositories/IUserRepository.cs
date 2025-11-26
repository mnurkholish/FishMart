
using FishMart.Models;
using System.Collections.Generic;
using System.Data;

namespace FishMart.Repositories
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        void Create(User user);
        List<User> GetAkunKasir();
        void ToggleStatus(int userId);
    }
}
