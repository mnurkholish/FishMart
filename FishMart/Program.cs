using DotNetEnv;
using FishMart.Controler;
using FishMart.Repositories;
using FishMart.Services;
using FishMart.View;

namespace FishMart
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Env.Load();
            UserRepository userRepository = new UserRepository();
            UserService userService = new UserService(userRepository);
            AuthController authController = new AuthController(userService);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new V_Produk(authController));
        }
    }
}