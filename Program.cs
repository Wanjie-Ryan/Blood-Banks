using Blood_Banks.UI;
using System;
using System.Windows.Forms; // Add this namespace for Application class

namespace Blood_Banks
{
    internal static class Program
    {
        // Define connection string variables
        private static string server = "localhost";
        private static string database = "bloodbanks";
        private static string username = "root";
        private static string password = "1234567890";

        // Method to get the connection string
        public static string GetConnectionString()
        {
            // Construct and return the connection string
            return $"server={server};database={database};uid={username};password={password};";
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Start the application by running the main form
            Application.Run(new Login());
            //Application.Run(new HomeForm());   

        }
    }
}
