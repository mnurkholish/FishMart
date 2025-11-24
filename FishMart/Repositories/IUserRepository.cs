
using FishMart.Models;
using System.Collections.Generic;

namespace FishMart.Repositories
{
    public interface IUserRepository
    {
        User GetUserByEmail(string email);
        void Create(User user);
    }
}
