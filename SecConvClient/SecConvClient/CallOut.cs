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
    public partial class CallOut : Form
    {
        //int callOutState = 0; //0 - ringing | 1 - OK    | 2 - FAIL
        public CallOut(string receiver)
        {
            //callOutState = 0;
            InitializeComponent();
            LUser.Text = receiver;
        }

        private void BDecline_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
