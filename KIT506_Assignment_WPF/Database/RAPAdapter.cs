using System;
using MySql.Data.MySqlClient;

namespace KIT506_Assignment_WPF.Database
{
    // Database connection class for RAP system
    public class RAPAdapter
    {
        public MySqlConnection connection;

        public RAPAdapter()
        {
            string conn = String.Format("Database={0};Data Source={1};" +
            "User Id={2};Password={3}; SslMode = none",
            "kit206", "alacritas.cis.utas.edu.au", "kit206", "kit206");

            Console.WriteLine(conn);

            connection = new MySqlConnection(conn);

            connection.Open();

            // Success message
            Console.WriteLine("Connection Success!!");
        }
    }
}

