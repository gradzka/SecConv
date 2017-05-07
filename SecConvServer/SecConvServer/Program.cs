using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;

namespace SecConvServer
{
    class Program
    {
        //dictionary of logged in people
        public static Dictionary<long, ConnectedClient> onlineUsers = new Dictionary<long, ConnectedClient>();
        static void Main(string[] args)
        {

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=SecConvDB.sqlite; Version=3;");
            m_dbConnection.Open();

            //create DataBase file if not exists
            DataBase.CreateDataBase(m_dbConnection);
            Communique.AddDelegateToDictionary();
            m_dbConnection.Close();

            //List<string> lista = new List<string>();
            //lista.Add("Monika");
            //lista.Add("Robert");
            //lista.Add("2017-12-06-23:00:00");
            //lista.Add("1:30:22");
            //Communique.DelFriend(lista);
            //Communique.CallState(lista);*/
            //Communique.CallState(lista);

            AsynchronousSocketListener.StartListening();

        }
    }
}
