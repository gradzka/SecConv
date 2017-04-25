using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecConvClient
{
    class Communique
    {
        public static bool Register(string login, string password)
        {
            char comm = (char)0;
            string message = comm + " " + login + " " + password;
            //szyfruj
            //wyślij do serwera
            //sprawdz odpowiedz
            return true;
        }
        public static bool LogIn(string login, string password)
        {
            char comm = (char)1;
            string message = comm + " " + login + " " + password;
            //szyfruj
            //wyślij do serwera
            //sprawdz odpowiedz
            return true;
        }
        public static bool LogOut(string login)
        {
            char comm = (char)2;
            string message = comm + " " + login;
            //szyfruj
            //wyślij do serwera
            //sprawdz odpowiedz
            return true;
        }
        public static bool AccDel(string login, string password)
        {
            char comm = (char)3;
            string message = comm + " " + login + " " + password;
            //szyfruj
            //wyślij do serwera
            //sprawdz odpowiedz
            return true;
        }
        public static bool PassChng(string login, string oldPassword, string newPassword)
        {
            char comm = (char)4;
            string message = comm + " " + login + " " + oldPassword + " " + newPassword;
            //szyfruj
            //wyślij do serwera
            //sprawdz odpowiedz
            return true;
        }
        public static bool AddFriend(string friendLogin)
        {
            char comm = (char)8;
            string message = comm + " " + friendLogin;
            //szyfruj
            //wyślij do serwera
            //sprawdz odpowiedz
            return true;
        }
        public static bool DelFriend(string friendLogin)
        {
            char comm = (char)9;
            string message = comm + " " + friendLogin;
            //szyfruj
            //wyślij do serwera
            //sprawdz odpowiedz
            return true;
        }
        public static void CallState(string callerLogin, string receiverLogin, DateTime date, TimeSpan callTime)
        {
            char comm = (char)11;
            string dateString = date.ToString("yyyy-MM-dd-HH:mm:ss", CultureInfo.InvariantCulture);
            string callTimeString = string.Format("{0:D2}:{1:D2}:{2:D2}", callTime.Hours, callTime.Minutes, callTime.Seconds);
            string message = comm + " " + callerLogin + " " + receiverLogin + " " + dateString + " " + callTimeString;
            //szyfruj
            //wyślij do serwera
        }
        static void Iam(string login)
        {
            char comm = (char)15;
            string message = comm + " " + login;
            //szyfruj
            //wyślij do serwera
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
        static void Bye()
        {

        }

    }
}
