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
using System.Diagnostics;

namespace SecConvServer
{
    class Program
    {
        //dictionary of logged in people
        public static Dictionary<long, ConnectedClient> onlineUsers = new Dictionary<long, ConnectedClient>();
        public static Security security = new Security();
        static void Main(string[] args)
        {
            String thisprocessname = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
                return;

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

            security.CreatePublicKey();
            AsynchronousSocketListener.StartListening();

        }
    }
}
