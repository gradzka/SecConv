using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SecConvClient
{
    static class Program
    {
        public static string userLogin;
        public static string serverAddress;
        public static SynchronousClient client;
        public static SecConv secConv;
        public static Voice voice;
        public static Security security = new Security();

        public static byte[] sessionKeyWithServer = null;
        public static byte[] sessionKeyWithClient = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String thisprocessname = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
                return;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SecConv());

            userLogin = "";
            serverAddress = "";

            LogIn logIn;
            Register register;
            security.CreatePublicKey();

            DialogResult dialogResult = DialogResult.No;

            while (dialogResult != DialogResult.Cancel)
            {
                if (dialogResult==DialogResult.No) //user isn't logIn
                {
                    logIn = new LogIn();
                    dialogResult = logIn.ShowDialog();
                }
                if (dialogResult==DialogResult.Yes) //user is logIn
                {
                    secConv = new SecConv();
                    voice = new Voice();
                    dialogResult = secConv.ShowDialog();
                }
                if(dialogResult==DialogResult.OK) //user want to register
                {
                    register = new Register();
                    dialogResult = register.ShowDialog();
                }
            }
            
        }
    }
}
