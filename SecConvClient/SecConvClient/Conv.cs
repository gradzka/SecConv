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
        public Conv()
        {
            InitializeComponent();
        }

        private void BDisconnect_Click(object sender, EventArgs e)
        {
            Voice.DropCall();
        }
    }
}
