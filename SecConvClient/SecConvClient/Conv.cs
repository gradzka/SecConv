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
    public partial class Conv : Form
    {
        DateTime begin;
        DateTime end = DateTime.Now;
        public Conv(string login)
        {
            InitializeComponent();
            begin = DateTime.Now;
            timer1.Start();
            LUser.Text = login;
        }

        private void BDisconnect_Click(object sender, EventArgs e)
        {
            end = DateTime.Now;
            timer1.Stop();
            this.DialogResult = DialogResult.No;
            Program.voice.DropCall();       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            end = DateTime.Now;
            LTime.Text = (end - begin).Hours.ToString().PadLeft(2,'0') + ":" + (end - begin).Minutes.ToString().PadLeft(2, '0') + ":" + (end - begin).Seconds.ToString().PadLeft(2, '0');
        }
    }
}
