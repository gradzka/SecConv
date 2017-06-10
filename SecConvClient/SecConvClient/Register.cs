using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SecConvClient
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BRegister_Click(object sender, EventArgs e)
        {
            if(TLogin.Text=="" || TPassword1.Text=="" || TPassword2.Text=="" || TServerIP.Text=="")
            {
                MessageBox.Show("Przynajmniej jedno z wymaganych pól jest nieuzupełnione!", "Błąd!");
            }
            else if(TPassword1.Text!= TPassword2.Text)
            {
                MessageBox.Show("Podane hasła nie są identyczne!", "Błąd!");
            }
            else
            {
                Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
                Match match = regex.Match(TPassword1.Text);
                if (match.Success)
                {
                    try
                    {
                        Program.client = new SynchronousClient(TServerIP.Text);
                        var serverKey = Communique.KeyExchange();
                        if (serverKey != null)
                        {
                            var sessKey = Program.security.SetSessionKey(serverKey);
                            if (Communique.Register(TLogin.Text, TPassword1.Text, sessKey) == true)
                            {
                                MessageBox.Show("Rejestracja użytkownika " + TLogin.Text + " przebiegła pomyślnie!", "Sukces!");
                                this.DialogResult = DialogResult.No;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Podany login jest już zajęty!", "Błąd!");
                                Program.client.Disconnect();
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
                else
                {
                    MessageBox.Show("Hasło nie spełnia kryteriów!", "Błąd!");
                }        
                
            }
        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }


        private void tSBContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                           "Monika Grądzka:\t https://github.com/gradzka \n" +
                           "Robert Kazimierczak:\t https://github.com/kazimierczak-robert",
                           "Autorzy projektu");
        }

        private void Textbox_Enter(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Name == "TServerIP" && ((TextBox)sender).Text == "Adres IP serwera") ||
                (((TextBox)sender).Name == "TLogin" && ((TextBox)sender).Text == "Login") ||
                (((TextBox)sender).Name == "TPassword1" && ((TextBox)sender).Text == "Hasło") ||
                (((TextBox)sender).Name == "TPassword2" && ((TextBox)sender).Text == "Hasło"))
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
                else if (((TextBox)sender).Name == "TPassword1")
                {
                    ((TextBox)sender).Text = "Hasło";
                    ((TextBox)sender).ForeColor = Color.Gray;
                }
                else if (((TextBox)sender).Name == "TPassword2")
                {
                    ((TextBox)sender).Text = "Hasło";
                    ((TextBox)sender).ForeColor = Color.Gray;
                }
            }
        }
    }
}
