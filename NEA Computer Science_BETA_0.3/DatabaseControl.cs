using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity.Core.Metadata.Edm;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.VisualStyles;

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
                            email TEXT NOT NULL, 
                            password TEXT NOT NULL
                        );";
                    string createFolderTableQuery = @"
                        CREATE TABLE IF NOT EXISTS folders (
                            userid INTEGER, 
                            cardid INTEGER,
                            tags_1 STRING,
                            tags_2 STRING,
                            tags_3 STRING,
                            tags_4 STRING,
                            tags_5 STRING,
                            tags_6 STRING,
                            tags_7 STRING,
                            tags_8 STRING,
                            tags_9 STRING,
                            tags_10 STRING,
                            folderid INTEGER PRIMARY KEY AUTOINCREMENT, 
                            foldername STRING NOT NULL,
                            foldertype STRING NOT NULL,
                            FOREIGN KEY (userid) REFERENCES logins(userid)
                            FOREIGN KEY (cardid) REFERENCES cards(cardid)
                        );";
                    string createCardTableQuery = @"
                        CREATE TABLE IF NOT EXISTS cards (
                            userid INTEGER, 
                            folderid INTEGER,
                            cardid INTEGER PRIMARY KEY AUTOINCREMENT,
                            question TEXT NOT NULL,
                            answer TEXT NOT NULL,
                            FOREIGN KEY (userid) REFERENCES logins(userid)
                            FOREIGN KEY (folderid) REFERENCES folders(folderid)
                        );";
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createLoginTableQuery;
                        command.ExecuteNonQuery();
                        command.CommandText = createFolderTableQuery;
                        command.ExecuteNonQuery();
                        command.CommandText = createCardTableQuery;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
        public static void AddUsers(string username, string email, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO logins (username, email, password)
                        VALUES (@username, @email, @password);";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }


            }
        }

        public static void CreateFolder(string userid, string foldername, string foldertype, string tags_1, string tags_2, string tags_3, string tags_4, string tags_5, string tags_6, string tags_7, string tags_8, string tags_9, string tags_10)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO folders (userid, foldername, foldertype, tags_1, tags_2, tags_3, tags_4, tags_5, tags_6, tags_7, tags_8, tags_9, tags_10)
                        VALUES (@userid, @foldername, @foldertype, @tags_1, @tags_2, @tags_3, @tags_4, @tags_5, @tags_6, @tags_7, @tags_8, @tags_9, @tags_10);";
                    command.Parameters.AddWithValue(@"userid", userid);
                    command.Parameters.AddWithValue("@foldername", foldername);
                    command.Parameters.AddWithValue("@foldertype", foldertype);
                    command.Parameters.AddWithValue("@tags_1", tags_1);
                    command.Parameters.AddWithValue("@tags_2", tags_2);
                    command.Parameters.AddWithValue("@tags_3", tags_3);
                    command.Parameters.AddWithValue("@tags_4", tags_4);
                    command.Parameters.AddWithValue("@tags_5", tags_5);
                    command.Parameters.AddWithValue("@tags_6", tags_6);
                    command.Parameters.AddWithValue("@tags_7", tags_7);
                    command.Parameters.AddWithValue("@tags_8", tags_8);
                    command.Parameters.AddWithValue("@tags_9", tags_9);
                    command.Parameters.AddWithValue("@tags_10", tags_10);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public static List<Folder> GetFolderList()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<List<string>> folderNames = new List<List<string>>();
                        List<Folder>folders = new List<Folder>();
                        while (reader.Read())
                        {
                            string userid_check = Convert.ToString(reader.GetInt32(reader.GetOrdinal("userid")));
                            string foldername = reader.GetString(reader.GetOrdinal("foldername"));
                            string foldertype = reader.GetString(reader.GetOrdinal("foldertype"));
                            string folderid = Convert.ToString(reader.GetInt32(reader.GetOrdinal("folderid")));
                            List<string> tags = new List<string>();
                            string[] user = DatabaseControl.GetUserFromEmail(Form1.email_login);
                            string userid = user[0];
                            if (userid_check == userid)
                            {
                                //chatgpt code
                                for (int i = 1; i <= 10; i++)
                                {
                                    string column = $"tags_{i}";
                                    int columnIndex = reader.GetOrdinal(column);

                                    if (!reader.IsDBNull(columnIndex))
                                    {
                                        string tag = reader.GetString(columnIndex);
                                        tags.Add(tag);
                                    }
                                }
                                // Concatenate tags with newline character
                                string concatenatedTags = string.Join("\n", tags);
                                List<string> folderRow = new List<string> { foldername, foldertype, concatenatedTags, folderid };
                                folders.Add(new Folder(Convert.ToInt32(application.userid), Convert.ToInt32(folderid), foldername, foldertype, tags));
                                folderNames.Add(folderRow);
                                //chatgpt code
                            }
                            
                        }
                        return folders;
                    }

                }
            }
        }
        public static List<string> GetFolderTypes()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<string> folderTypes = new List<string>();
                        while (reader.Read())
                        {
                            string foldertype = reader.GetString(reader.GetOrdinal("foldertype"));
                            folderTypes.Add(foldertype);
                        }
                        return folderTypes;
                    }
                }
            }
        }
        public static void CreateCards(int folderid, int userid, string question, string answer)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText =
                        @"INSERT INTO cards (userid, folderid, question, answer)
                        VALUES (@userid, @folderid, @question, @answer);";
                    command.Parameters.AddWithValue(@"userid", userid);
                    command.Parameters.AddWithValue("@folderid", folderid);
                    command.Parameters.AddWithValue("@question", question);
                    command.Parameters.AddWithValue("@answer", answer);
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public static void CheckUsers(string email, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM logins";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        bool login_suc = false;
                        while (reader.Read())
                        {
                            int userid_check = reader.GetInt32(reader.GetOrdinal("userid"));
                            string username_check = reader.GetString(reader.GetOrdinal("username"));
                            string email_check = reader.GetString(reader.GetOrdinal("email"));
                            string password_check = reader.GetString(reader.GetOrdinal("password"));


                            if (email_check == email & password_check == password)
                            {
                                MessageBox.Show("login successfull");
                                login_suc = true;
                                Form1.CreateAndDeleteForm();
                            }


                        }
                        if (login_suc == false)
                        {
                            MessageBox.Show("Incorrect Email or Password");
                        }


                    }
                }
            }
        }
        public static string[] GetUserFromEmail(string email)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM logins";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string[] users_array = new string[3];
                        while (reader.Read())
                        {
                            int userid_check = reader.GetInt32(reader.GetOrdinal("userid"));
                            string username_check = reader.GetString(reader.GetOrdinal("username"));
                            string email_check = reader.GetString(reader.GetOrdinal("email"));
                            string password_check = reader.GetString(reader.GetOrdinal("password"));
                            if (email_check == email)
                            {
                                users_array[0] = Convert.ToString(userid_check);
                                users_array[1] = username_check;
                                users_array[2] = email_check;
                                return users_array;
                            }

                        }
                        return null;

                    }
                }
            }
        }
        public static int GetFolderIDFromFolderName(string folderName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int folderid = 0;
                        while (reader.Read())
                        {
                            int folderid_check = reader.GetInt32(reader.GetOrdinal("folderid"));
                            string foldername_check = reader.GetString(reader.GetOrdinal("foldername"));
                            if (foldername_check == folderName)
                            {
                                folderid = folderid_check;
                            }
                        }
                        return folderid;
                    }
                }
            }
        }
        public static List<Cards> GetCardList(string folderid)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM cards";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int userid = Convert.ToInt32( application.userid);
                        List<Cards> Cards = new List<Cards>();
                        while (reader.Read())
                        {
                            string cardid = Convert.ToString( reader.GetInt32(reader.GetOrdinal("cardid")));
                            string folderid_check = Convert.ToString(reader.GetInt32(reader.GetOrdinal("folderid")));
                            string question = reader.GetString(reader.GetOrdinal("question"));
                            string answer = reader.GetString(reader.GetOrdinal("answer"));
                            if (folderid_check == folderid)
                            {
                                Cards.Add(new Cards(userid, Convert.ToInt32( cardid),Convert.ToInt32( folderid), question, answer));
                            }


                        }
                        return Cards;
                    }
                }
            }
        }
        public static string GetFolderidFromFoldername(string foldername)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open ();
                string query = "SELECT * FROM folders";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string folderid = "";
                        while (reader.Read())
                        {
                            int folderid_check = reader.GetInt32(reader.GetOrdinal("folderid"));
                            string foldername_check = reader.GetString(reader.GetOrdinal("foldername"));
                            if (foldername_check == foldername)
                            {
                                folderid = Convert.ToString(folderid_check);
                            }
                        }
                        return folderid;
                    }
                }
            }
        }
        public static Queue<string> GetCardsFromFolderID(string folderid)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open ();
                string query = "SELECT * FROM cards";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        Queue<string> cards = new Queue<string>();
                        while (reader.Read())
                        {
                            int folderid_check = reader.GetInt32(reader.GetOrdinal("folderid"));
                            string question = reader.GetString(reader.GetOrdinal("question"));
                            string answer = reader.GetString(reader.GetOrdinal("answer"));
                            if (folderid_check == Convert.ToInt32(folderid))
                            {
                                cards.Enqueue(question);
                                cards.Enqueue(answer);
                            }
                        }
                        return cards;
                    }
                }
            }
        }
    }
}


        
            