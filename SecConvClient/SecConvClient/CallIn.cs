using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecConvClient
{
    public partial class CallIn : Form
    {
        public CallIn(string login)
        {
            InitializeComponent();
            LUser.Text = login;
        }

        private void BAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BDecline_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        /*private void CallIn_Shown(object sender, EventArgs e)
        {
            //https://www.autoitscript.com/forum/topic/40848-beep-music-mario-bros-theme/
            while (true)
            {
                Console.Beep(480, 200);
                Console.Beep(1568, 200);
                Console.Beep(1568, 200);
                Console.Beep(1568, 200);


                Console.Beep(740, 200);
                Console.Beep(784, 200);
                Console.Beep(784, 200);
                Console.Beep(784, 200);

                Console.Beep(370, 200);
                Console.Beep(392, 200);
                Console.Beep(370, 200);
                Console.Beep(392, 200);
                Console.Beep(392, 400);
            }
        }*/
    }
}
