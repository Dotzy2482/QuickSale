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
            Application.Run(new frmLogin());
        }
    }
}