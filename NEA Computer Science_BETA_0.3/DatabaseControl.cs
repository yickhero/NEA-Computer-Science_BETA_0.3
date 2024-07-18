using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity.Core.Metadata.Edm;

namespace NEA_Computer_Science_BETA_0._3
{
    internal class DatabaseControl
    {
        private static string connectionString = @"Data Source=..\..\Files\Login.db;Version=3;";
        public static void InitializeDatabase()
        {
            if (!File.Exists(@"..\..\Files\Login.db"))
            {
                SQLiteConnection.CreateFile(@"..\..\Files\Login.db");

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                         
                    string createLoginTableQuery = @"
                        CREATE TABLE IF NOT EXISTS logins (
                            userid INTEGER PRIMARY KEY AUTOINCREMENT,
                            username TEXT NOT NULL,
                            password TEXT NOT NULL,
                            email TEXT NOT NULL
                        );";

                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createLoginTableQuery;
                        command.ExecuteNonQuery(); 
                    }
                }
            }
        }
        public static void AddUsers()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string[] usernames = 
                
            }
        }
    }
}
