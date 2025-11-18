
using FishMart.Models;
using System.Collections.Generic;

namespace FishMart.Repositories
{
    public interface IUserRepository
    {
        User GetByEmail(string username);
        void Create(User user);
    }
}
