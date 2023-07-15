//using System;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public static class DB
{
    public static string databasePath = "pw.db";
    public static string connectionString = "Data Source=" + databasePath + ";";

    public static bool isUsernameUnique(string username)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);

                int count = Convert.ToInt32(command.ExecuteScalar());
                return count == 0;
            }
        }
    }

    public static bool validPW(string password)
    {
        return password.Length != 0;
    }
    public static void makeDB()
    {
        if (!File.Exists(databasePath))
        {
            SQLiteConnection.CreateFile(databasePath);


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create tables or perform other database operations
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = @"CREATE TABLE Users (
                                            ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Username TEXT NOT NULL,
                                            Password TEXT NOT NULL,
                                            Salt TEXT NOT NULL
                                        );";
                    command.ExecuteNonQuery();
                    command.CommandText = @"CREATE TABLE Passwords (
                                                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                UserID INTEGER NOT NULL,
                                                ServiceName TEXT NOT NULL,
                                                Username TEXT NOT NULL,
                                                Password TEXT NOT NULL,
                                                FOREIGN KEY (UserID) REFERENCES Users(ID)
                                            );";
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }

    public static void addAccount(string accountName, string password)
    {
        byte[] salt = CryptoHelper.generateSalt(64);
        string hash = CryptoHelper.generatePWHash(password, salt);
        string b64salt = Convert.ToBase64String(salt);
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string insertQuery = @"INSERT INTO Users (Username, Password, Salt) 
                               VALUES (@Username, @Password, @Salt);";
            using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", accountName);
                command.Parameters.AddWithValue("@Password", hash);
                command.Parameters.AddWithValue("@Salt", b64salt);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public static int authenticate(string username, string password)
    {
        //-1 corresponds to an error code, saying the login failed
        //upon login success the ID of the logged in user is returned.
        string query = "SELECT ID,Password,Salt FROM Users WHERE Username = @username";
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        byte[] salt = Convert.FromBase64String(reader.GetString(2));
                        string hash = reader.GetString(1);
                        //System.Console.WriteLine(hash);
                        if (CryptoHelper.generatePWHash(password, salt) == hash)
                        {
                            return id;
                        }

                    }
                }
            }
        }
        return -1;
    }

    public static void changeMasterPassword(int UserID, string oldPW, string newPW)
    {
        byte[] salt = getSalt(UserID);
        byte[] oldKey = CryptoHelper.generateDerivedKey(oldPW, salt);
        byte[] newKey = CryptoHelper.generateDerivedKey(newPW, salt);
        string pwhash = CryptoHelper.generatePWHash(newPW, salt);
        List<PWEntry> passwords = new List<PWEntry>();
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Passwords WHERE UserID = @userID";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@userID", UserID);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        passwords.Add(new PWEntry(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));

                    }
                }
            }
            foreach (PWEntry password in passwords)
            {
                password.setPassword(CryptoHelper.encryptString((CryptoHelper.decryptString(password.getPassword(), oldKey)), newKey));
            }
            foreach (PWEntry password in passwords)
            {
                string query = "UPDATE Passwords SET Password = @newPassword WHERE ID = @pwID";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newPassword", password.getPassword());
                    command.Parameters.AddWithValue("@pwID", password.getID());
                    command.ExecuteNonQuery();

                }
            }
            string q = "UPDATE Users SET Password = @newPassword WHERE ID = @userID";
            using (SQLiteCommand command = new SQLiteCommand(q, connection))
            {
                command.Parameters.AddWithValue("@userID", UserID);
                command.Parameters.AddWithValue("@newPassword", pwhash);
                command.ExecuteNonQuery();
            }
        }

    }

    public static byte[] getSalt(int id)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT Salt FROM Users WHERE ID = @id";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return Convert.FromBase64String(reader.GetString(0));

                    }
                }

            }
        }
        return new byte[0]; //in case the id does not exist
    }

    public static void addPW(string service, string username, string password, int ID, byte[] key)
    {
        string pw = CryptoHelper.encryptString(password, key);
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string insertQuery = @"INSERT INTO Passwords (UserID,ServiceName,Username,Password) VALUES (@UserID,@ServiceName,@Username,@Password)";
            using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@UserID", ID);
                command.Parameters.AddWithValue("@ServiceName", service);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", pw);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public static bool PWExists(string service, string username)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string lookupQuery = "SELECT COUNT(*) FROM Passwords WHERE ServiceName = @ServiceName AND Username = @Username";
            using (SQLiteCommand command = new SQLiteCommand(lookupQuery, connection))
            {
                command.Parameters.AddWithValue("@ServiceName", service);
                command.Parameters.AddWithValue("@Username", username);
                int count = Convert.ToInt32(command.ExecuteScalar());  //if row 1 column 1 exists it is clear that match was found, ignore rest, returns an Object so we just int32 that.
                return (count > 0);
            }
        }
    }

    public static void deletePW(string service, string username)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM Passwords WHERE ServiceName = @ServiceName AND Username = @Username";
            using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ServiceName", service);
                command.Parameters.AddWithValue("@Username", username);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }

    public static PWEntry retrievePW(string service, string username, byte[] key)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Passwords WHERE ServiceName = @service AND Username = @username";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@service", service);
                command.Parameters.AddWithValue("@username", username);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32(0);
                        int userID = reader.GetInt32(1);
                        string serviceName = reader.GetString(2);
                        string uname = reader.GetString(3);
                        string pw = reader.GetString(4);
                        return new PWEntry(ID, userID, serviceName, uname, pw);
                    }
                }
            }
        }
        return new PWEntry();
    }

    public static List<PWEntry> retrieveAllPW(int UID)
    {
        List<PWEntry> passwords = new List<PWEntry>();
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM Passwords WHERE UserID = @UID";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UID", UID);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = reader.GetInt32(0);
                        int userID = reader.GetInt32(1);
                        string serviceName = reader.GetString(2);
                        string uname = reader.GetString(3);
                        string pw = reader.GetString(4);
                        passwords.Add(new PWEntry(ID, userID, serviceName, uname, pw));
                    }
                }
            }
        }
        return passwords;
    }
    public static string getUsername(int id)
    {
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Username FROM Users WHERE ID = @id;";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) { return reader.GetString(0); }
                }

            }

        }
        return "\0";
    }

}
