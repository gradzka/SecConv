using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SecConvServer
{
    class DataBase
    {
        static void ExecuteCommand(string sql, SQLiteConnection m_dbConnection)
        {
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        static void DropTable(string TableName, SQLiteConnection m_dbConnection)
        {
            string sql = "DROP TABLE " + TableName;
            ExecuteCommand(sql, m_dbConnection);
        }
        static void createUsersTable(SQLiteConnection m_dbConnection)
        {
            string sql = "CREATE TABLE IF NOT EXISTS Users(" +
                                            "UserID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                            "Login VARCHAR(50) UNIQUE NOT NULL," +
                                            "Password CHAR(64) NOT NULL," +
                                            "Online BOOLEAN NOT NULL," +
                                            "LastLogoutDate DATETIME NOT NULL," +
                                            "RegistrationDate DATETIME NOT NULL);";

            ExecuteCommand(sql, m_dbConnection);
        }
        static void createHistoriesTable(SQLiteConnection m_dbConnection)
        {
            string sql = "CREATE TABLE IF NOT EXISTS Histories(" +
                                            "HistoryID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                            "UserSenderID INTEGER REFERENCES Users(UserID)," +
                                            "UserReceiverID INTEGER REFERENCES Users(UserID)," +
                                            "Start DATETIME NOT NULL," +
                                            "Duration TIME);";
            ExecuteCommand(sql, m_dbConnection);

        }
        static void createFriendsTable(SQLiteConnection m_dbConnection)
        {
            string sql = "CREATE TABLE IF NOT EXISTS Friends(" +
                                            "FirendID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                            "UserID1 INTEGER NOT NULL REFERENCES Users(UserID)," +
                                            "UserID2 INTEGER NOT NULL REFERENCES Users(UserID));";
            ExecuteCommand(sql, m_dbConnection);

        }
        public static void createDataBase(SQLiteConnection m_dbConnection)
        {
            if (!File.Exists("SecConvDB.sqlite"))
            {
                SQLiteConnection.CreateFile("SecConvDB.sqlite"); //utworzenie bazy danych

            }
            createUsersTable(m_dbConnection);
            createFriendsTable(m_dbConnection);
            createHistoriesTable(m_dbConnection);

            //DropTable("Users", m_dbConnection);
            //DropTable("Friends", m_dbConnection);
            //ropTable("Histories", m_dbConnection);
        }

    }
}
