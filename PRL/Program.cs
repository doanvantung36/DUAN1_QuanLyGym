using BUS.Service;
//using DAL.Context;
using DAL.Repositoies;
using PRL.View;
namespace PRL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DBContext gymDBContext = new DBContext();
            //UserRepository userRepository = new UserRepository(gymDBContext);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //UserService userService = new UserService(userRepository, gymDBContext);
            Application.Run(new DangNhap(/*userService*/));
        }
    }
}