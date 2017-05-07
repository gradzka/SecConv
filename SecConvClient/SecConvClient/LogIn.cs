using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SecConvClient
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void BLogIn_Click(object sender, EventArgs e)
        {
            if (TLogin.Text == "" || TPassword.Text == "" || TServerIP.Text == "")
            {
                MessageBox.Show("Przynajmniej jedno z wymaganych pól jest nieuzupełnione!", "Błąd!");
            }
            else
            {
                try
                {
                    Program.client = new AsynchronousClient(TServerIP.Text);
                    if (Communique.LogIn(TLogin.Text, TPassword.Text) == true)
                    {
                        Program.userLogin = TLogin.Text;
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Podane dane logowania są niepoprawne!", "Błąd!");
                    }
                }
                catch (SocketException)
                {
                    MessageBox.Show("Problem z połączeniem z serwerem lub adres jest niepoprawny!", "Błąd!");
                }
            }
        }

        private void BRegister_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
