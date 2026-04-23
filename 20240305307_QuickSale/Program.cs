using QuickSale.DAL;

namespace _20240305307_QuickSale
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DatabaseInitializer.Initialize();

            // Lifecycle loop: login → main → back to login on logout, exit on close
            while (true)
            {
                using var login = new frmLogin();
                if (login.ShowDialog() != DialogResult.OK) break;

                using var main = new frmMain();
                if (main.ShowDialog() != DialogResult.OK) break;   // X-close exits app

                Session.Clear();   // logout path — restart login
            }
        }
    }
}
