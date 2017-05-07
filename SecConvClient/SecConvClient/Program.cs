using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecConvClient
{
    static class Program
    {
        public static string userLogin;
        public static AsynchronousClient client;
        public static SecConv secConv;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SecConv());

            userLogin = "";

            LogIn logIn;
            Register register;

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
