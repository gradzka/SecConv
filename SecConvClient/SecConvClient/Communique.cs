using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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

        public static bool Register(string login, string password)
        {
            char comm = (char)0;
            string message = comm + " " + login + " " + password + " <EOF>";

            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static bool LogIn(string login, string password)
        {
            char comm = (char)1;
            string message = comm + " " + login + " " + password + " <EOF>";

            Program.client.Send(message);
   
            return Response(Program.client.Receive()[0]);
        }
        public static void LogOut(string login)
        {
            char comm = (char)2;
            string message = comm + " " + login + " <EOF>";

            Program.client.Send(message);
            return;
        }
        public static bool AccDel(string login, string password)
        {
            char comm = (char)3;
            string message = comm + " " + login + " " + password + " <EOF>";
            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static bool PassChng(string login, string oldPassword, string newPassword)
        {
            char comm = (char)4;
            string message = comm + " " + login + " " + oldPassword + " " + newPassword + " <EOF>";
            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static bool AddFriend(string login, string friendLogin)
        {
            char comm = (char)8;
            string message = comm + " " + login + " " + friendLogin + " <EOF>";
            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static bool DelFriend(string login, string friendLogin)
        {
            char comm = (char)9;
            string message = comm + " " + login + " " + friendLogin + " <EOF>";
            Program.client.Send(message);
            return Response(Program.client.Receive()[0]);
        }
        public static void CallState(string callerLogin, string receiverLogin, DateTime date, TimeSpan callTime)
        {
            char comm = (char)11;
            string dateString = date.ToString("yyyy-MM-dd-HH:mm:ss", CultureInfo.InvariantCulture);
            string callTimeString = string.Format("{0:D2}:{1:D2}:{2:D2}", callTime.Hours, callTime.Minutes, callTime.Seconds);
            string message = comm + " " + callerLogin + " " + receiverLogin + " " + dateString + " " + callTimeString + " <EOF>";
            Program.client.Send(message);
        }
        public static void Iam(string login)
        {
            char comm = (char)15;
            string message = comm + " " + login + " <EOF>";
            Program.client.Send(message);
            commFromServer(Program.client.Receive());
        }

        public static void commFromServer(string messageFromServer)
        {
            //odszyfruj
            int comm = (int)messageFromServer[0];
            switch (comm)
            {
                case 7:
                    LogIP(messageFromServer.Remove(0, 2));
                    break;
                case 13:
                    History(messageFromServer.Remove(0, 2));
                    break;
                case 14:
                    StateChng(messageFromServer.Remove(0, 2));
                    break;
                default:
                    break;
            }
        }

        static void LogIP(string messageFromServer)
        {
            string[] friends = messageFromServer.Split(' ');
            ListViewItem friend;
            for (int i = 0; i < friends.Length/3; i+=3)
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
            for (int i = 0; i < history.Length / 5; i++)
            {
                string[] historyDetails = { history[i], history[i + 1] + " " + history[i + 2],  history[i + 4] };
                Program.secConv.listView2.Items.Add(new ListViewItem(historyDetails));
            }
        }
        static void StateChng(string messageFromServer)
        {
            string[] friends = messageFromServer.Split(' ');
            for (int i = 0; i < friends.Length / 2; i += 2)
            {
                Program.secConv.listView1.Items[Program.secConv.listView1.Items.IndexOfKey(friends[i])].SubItems[1].Text = friends[i + 1];
                if (friends[i + 1] == "0")
                {
                    Program.secConv.listView1.Items[Program.secConv.listView1.Items.IndexOfKey(friends[i])].ImageIndex = 0;
                }
                else
                {
                    Program.secConv.listView1.Items[Program.secConv.listView1.Items.IndexOfKey(friends[i])].ImageIndex = 1;
                }
            }
            Program.secConv.listView1.Refresh();
            //friend[i] login
            //friend[i+1] IP

        }
    }
}
