using System;
using System.Configuration;
using MySql.Data.MySqlClient;



namespace Blood_Banks
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());

            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;

            try
            {
                // Create a MySqlConnection object
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // If no exception is thrown, the connection is successful
                    Console.WriteLine("Connection successful!");
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, print the error message
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}