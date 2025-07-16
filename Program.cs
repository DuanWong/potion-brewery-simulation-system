using PotionBrewerySystem.Models;

namespace PotionBrewerySystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new BreweryContext())
            {
                context.Database.EnsureCreated(); // ← 创建表结构
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DashboardForm());
        }
    }
}