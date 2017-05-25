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
                        if (Communique.Register(TLogin.Text, TPassword1.Text) == true)
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
    }
}
