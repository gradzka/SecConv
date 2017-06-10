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
                    Program.client = new SynchronousClient(TServerIP.Text);
                    var serverKey = Communique.KeyExchange();
                    if (serverKey != null)
                    {
                        var sessKey = Program.security.SetSessionKey(serverKey);
                        if (Communique.LogIn(TLogin.Text, TPassword.Text, sessKey) == true)
                        {
                            Program.userLogin = TLogin.Text;
                            Program.serverAddress = TServerIP.Text;
                            this.DialogResult = DialogResult.Yes;
                            Program.sessionKeyWithServer = sessKey;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Podane dane logowania są niepoprawne lub użytkownik jest już zalogowany!", "Błąd!");
                        }
                    }
                    else
                    {
                        Program.client.Disconnect();
                        MessageBox.Show("Problem z połączeniem z serwerem!", "Błąd!");
                    }
                }
                catch (Exception)
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

        private void tSBContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                           "Monika Grądzka:\t https://github.com/gradzka \n" +
                           "Robert Kazimierczak:\t https://github.com/kazimierczak-robert",
                           "Autorzy projektu");
        }

        private void TServerIP_Leave(object sender, EventArgs e)
        {
            //if (String.IsNullOrWhiteSpace(myTxtbx.Text)) { myTxtbx.Text = "Enter text here..."; }
        }

        private void Textbox_Enter(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Name== "TServerIP" && ((TextBox)sender).Text == "Adres IP serwera") ||
                (((TextBox)sender).Name == "TLogin" && ((TextBox)sender).Text == "Login") ||
                (((TextBox)sender).Name == "TPassword" && ((TextBox)sender).Text == "Hasło"))
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = SystemColors.WindowText;
            }
        }

        private void Textbox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                if (((TextBox)sender).Name == "TServerIP")
                {
                    ((TextBox)sender).Text = "Adres IP serwera";
                    ((TextBox)sender).ForeColor = Color.Gray;
                }
                else if (((TextBox)sender).Name == "TLogin")
                {
                    ((TextBox)sender).Text = "Login";
                    ((TextBox)sender).ForeColor = Color.Gray;
                }
                else if (((TextBox)sender).Name == "TPassword")
                {
                    ((TextBox)sender).Text = "Hasło";
                    ((TextBox)sender).ForeColor = Color.Gray;
                }
            }
        }
    }
}
