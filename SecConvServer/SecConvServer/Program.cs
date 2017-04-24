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
        static Dictionary<int,Delegate> communiqueDictionary=new Dictionary<int, Delegate>(); //nalezy dodac do niego metody komunikatow

        static void addDelegateToDictionary()
        {
            communiqueDictionary[0]= new Action<List <string>>(Communique.Register);
            communiqueDictionary[1] = new Action<List<string>>(Communique.LogIn);
            communiqueDictionary[2] = new Action<List<string>>(Communique.LogOut);
            communiqueDictionary[3] = new Action<List<string>>(Communique.AccDel);
            communiqueDictionary[4] = new Action<List<string>>(Communique.PassChng);
            communiqueDictionary[8] = new Action<List<string>>(Communique.AddFriend);
            communiqueDictionary[9] = new Action<List<string>>(Communique.DelFriend);
            communiqueDictionary[11] = new Action<List<string>>(Communique.CallState);
            communiqueDictionary[15] = new Action<List<string>>(Communique.Iam);
        }
       
        void chooseCommunique(string message)
        {
           
            string decryptedMessage = "";

            string decryptedMessageBits = string.Empty; //message in binary form
            foreach (char ch in decryptedMessage)
            {
                decryptedMessageBits += Convert.ToString((int)ch, 2);
            }
            //take 8 bits to recognize the communique
            int bits8 = Convert.ToInt32(decryptedMessageBits.Substring(0, 8), 2);//decimal value

            //http://stackoverflow.com/a/4233539
            //wywolanie metody ze slownika
            //communiqueDictionary[bits8].DynamicInvoke();///);

        }
        static void Main(string[] args)
        {

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=SecConvDB.sqlite; Version=3;");
            m_dbConnection.Open();

            //create DataBase file if not exists
            DataBase.createDataBase(m_dbConnection);
            addDelegateToDictionary();


            m_dbConnection.Close();
        }
    }
}
