using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;

namespace SecConvServer
{
    class Program
    {      
        static void Main(string[] args)
        {

            /*SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=SecConvDB.sqlite; Version=3;");
            m_dbConnection.Open();

            //create DataBase file if not exists
            DataBase.createDataBase(m_dbConnection);
            addDelegateToDictionary();

            m_dbConnection.Close();*/
            List<string> lista = new List<string>();
            lista.Add("Karol");
            lista.Add("Ala");
            //lista.Add("2017-12-06-02:20:22");
            //lista.Add("20:30:22");
            Communique.AddFriend(lista);

        }
    }
}
