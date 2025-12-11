using FishMart.Models;

namespace FishMart.Services
{
    public interface IUserService
    {
        User? GetUserById(int id);
        bool Create(string email, string password, string username, string noTelp);
        bool UpdateUser(int id, string username, string noTelp, string password);
        User Login(string email, string password);
        List<User> GetAllKasir();
        void FillWithAkunKasir(DataGridView dgv);
        void ToggleUserStatus(int userId);
    }
}
