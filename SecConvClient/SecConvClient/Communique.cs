using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecConvClient
{
    class Communique
    {
        public static bool Register(string login, string password)
        {
            string message = "";
            return true;
        }
        public static bool LogIn(string login, string password)
        {
            string message = "";
            return true;
        }
        public static bool LogOut(string login)
        {
            string message = "";
            return true;
        }
        public static bool AccDel(string login, string password)
        {
            string message = "";
            return true;
        }
        public static bool PassChng(string oldPassword, string newPassword)
        {
            string message = "";
            return true;
        }
        static void AddFriend(List<string> param)
        {
        }
        public static bool DelFriend(string friendLogin)
        {
            string message = "";
            return true;
        }
        static void CallState(List<string> param)
        {
        }
        static void Iam(List<string> param)
        {
        }

        static void OK()
        {
        }
        static void Fail()
        {
        }
        static void LogIP()
        {
        }

        static void History()
        {
        }
        static void StateChng()
        {
        }
        static void Bye(List<string> param)
        {
        }

    }
}
