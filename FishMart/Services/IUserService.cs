using FishMart.Models;
using System.Data;

namespace FishMart.Services
{
    public interface IUserService
    {
        bool Create(string email, string password, string username, string noTelp);
        User Login(string email, string password);
        void FillWithAkunKasir(DataGridView dgv);
        void ToggleUserStatus(int userId);
    }
}
