
using FishMart.Models;

namespace FishMart.Services
{
    public interface IUserService
    {
        bool Register(string username, string password);
        User Login(string username, string password);
    }
}
