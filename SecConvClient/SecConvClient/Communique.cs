using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecConvClient
{
    class Communique
    {
        static bool Response(char answer)
        {
            if (answer==(char)5)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool Register(string login, string password, byte[] key)
        {
            char comm = (char)0;
            string message = comm + " " + Convert.ToBase64String(Program.security.EncryptMessage(key, login + " " + password)) + " <EOF>";

            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static bool LogIn(string login, string password, byte[] key)
        {
            char comm = (char)1;
            string message = comm + " " + Convert.ToBase64String(Program.security.EncryptMessage(key, login + " " + password)) + " <EOF>";

            Program.client.Send(message);
   
            return Response(Program.client.Receive()[0]);
        }
        public static void LogOut(string login)
        {
            char comm = (char)2;
            string message = comm + " " + Convert.ToBase64String(Program.security.EncryptMessage(Program.sessionKeyWithServer, login)) + " <EOF>";

            Program.client.Send(message);
            return;
        }
        public static bool AccDel(string login, string password)
        {
            char comm = (char)3;
            string message = comm + " " + Convert.ToBase64String(Program.security.EncryptMessage(Program.sessionKeyWithServer, login + " " + password)) + " <EOF>";
            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static bool PassChng(string login, string oldPassword, string newPassword)
        {
            char comm = (char)4;
            string message = comm + " " + Convert.ToBase64String(Program.security.EncryptMessage(Program.sessionKeyWithServer, login + " " + oldPassword + " " + newPassword)) + " <EOF>";
            Program.client.Send(message);
            var ans = Program.client.Receive();
            return Response(ans[0]);
        }
        public static bool AddFriend(string login, string friendLogin)
        {
            char comm = (char)8;
            string message = comm + " " + Convert.ToBase64String(Program.security.EncryptMessage(Program.sessionKeyWithServer, login + " " + friendLogin)) + " <EOF>";
            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static bool DelFriend(string login, string friendLogin)
        {
            char comm = (char)9;
            string message = comm + " " + Convert.ToBase64String(Program.security.EncryptMessage(Program.sessionKeyWithServer, login + " " + friendLogin)) + " <EOF>";
            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static void CallState(string callerLogin, string receiverLogin, DateTime date, TimeSpan callTime)
        {
            char comm = (char)11;
            string dateString = date.ToString("yyyy-MM-dd-HH:mm:ss", CultureInfo.InvariantCulture);
            string callTimeString = string.Format("{0:D2}:{1:D2}:{2:D2}", callTime.Hours, callTime.Minutes, callTime.Seconds);
            string message = Convert.ToBase64String(Program.security.EncryptMessage(Program.sessionKeyWithServer, callerLogin + " " + receiverLogin + " " + dateString + " " + callTimeString));
            message = comm + " " + message + " <EOF>";
            Program.client.Send(message);
        }
        public static void Iam(string login)
        {
            char comm = (char)15;
            string message = comm + " " + Convert.ToBase64String(Program.security.EncryptMessage(Program.sessionKeyWithServer, login)) + " <EOF>";

            Program.client.Send(message);
            message = Program.client.Receive();
            commFromServer(message.Substring(0,message.Length-6));
        }

        public static byte[] KeyExchange()
        {
            var byteArray = Program.security.GetOwnerPublicKey().ToByteArray();
            
            string message = (char)17 + " " + Convert.ToBase64String(byteArray) + " <EOF>";
            Program.client.Send(message);
            message = Program.client.Receive();
            return Convert.FromBase64String(message.Substring(2, message.Length-8 ));
        }

        public static void commFromServer(string messageFromServer)
        {
            //odszyfruj
            int comm = (int)messageFromServer[0];
            string message = Program.security.DecryptMessage(Convert.FromBase64String(messageFromServer.Substring(2)), Program.sessionKeyWithServer);
            switch (comm)
            {
                case 7:
                    LogIP(message);
                    break;
                case 13:
                    History(message);
                    break;
                case 14:
                    StateChng(message);
                    break;
                default:
                    break;
            }
        }

        static void LogIP(string messageFromServer)
        {
            string[] friends = messageFromServer.Split(' ');
            ListViewItem friend;
            for (int i = 0; i < friends.Length-1; i+=3)
            {
                //friends[i] login
                //friends[i+1] status
                //friends[i+2] IP
                string[] friendDetails = { friends[i], friends[i + 2] };
                if (friends[i + 1] == "0") //unavailable
                {

                    friend = new ListViewItem(friendDetails, 0);
                }
                else
                {
                    friend = new ListViewItem(friendDetails, 1);
                }
                Program.secConv.listView1.Items.Add(friend);

            }
        }

        static void History(string messageFromServer)
        {
            string[] history = messageFromServer.Split(' ');
            string[] historyDetails;
            for (int i = 0; i < history.Length-1; i+=5)
            {
                historyDetails = new string[3];
                historyDetails[0] = history[i];
                historyDetails[1] = history[i + 1] + " " + history[i + 2];
                historyDetails[2] = history[i + 4] == "00:00:00"? "nieodebrane": history[i + 4];                 
                Program.secConv.listView2.Items.Insert(0,new ListViewItem(historyDetails));
            }
        }
        static void StateChng(string messageFromServer)
        {
            string[] friends = messageFromServer.Split(' ');
            for (int i = 0; i < friends.Length-1; i += 2)
            {
                int index = Program.secConv.listView1.FindItemWithText(friends[i]).Index;
                Program.secConv.listView1.Items[index].SubItems[1].Text = friends[i + 1];
                if (friends[i + 1] == "0")
                {
                    Program.secConv.listView1.Items[index].ImageIndex = 0;
                }
                else
                {
                    Program.secConv.listView1.Items[index].ImageIndex = 1;
                }
            }
            Program.secConv.listView1.Refresh();
            //friend[i] login
            //friend[i+1] IP
        }
    }
}
