using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecConvClient
{
    public partial class SecConv : Form
    {
        Thread commThread;

        void waitForCommuniques()
        {
            while (true)
            {
                Program.client.Receive();
                Program.client.receiveDone.WaitOne();
                if (Program.client.response.Length > 0)
                {
                    Communique.commFromServer(Program.client.response);
                }
            }
        }

        public SecConv()
        {
            InitializeComponent();
            this.Text = Program.userLogin + " - SecConv";
            commThread = new Thread(waitForCommuniques);
            commThread.Start();
        }

        private void BCall_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego znajomego!", "Błąd!");
            }
            else if (listView1.SelectedItems[0].ImageIndex==0)
            {
                MessageBox.Show("Znajomy nie jest dostępny!", "Błąd!");
            }
            else
            {
                Program.voice.Call();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Communique.LogOut(Program.userLogin);
            if (commThread.IsAlive)
            {
                commThread.Abort();
            }
            Program.client.Disconnect();
            Program.client.disconnectDone.WaitOne();
            //Program.client.disconnectDone.Reset();
            Program.userLogin = "";
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void BDeleteFriend_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==0)
            {
                MessageBox.Show("Nie wybrano żadnego znajomego!", "Błąd!");
            }
            else
            {
                if (Communique.DelFriend(listView1.SelectedItems[0].Text) == true)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    listView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Nastąpił błąd podczas wylogowywania!", "Błąd!");
                }
            }
        }

        private void BAddFriend_Click(object sender, EventArgs e)
        {

        }

        private void BChangePassword_Click(object sender, EventArgs e)
        {
            if (TPasswordOld.Text == "" || TPassword1.Text == "" || TPassword2.Text == "")
            {
                MessageBox.Show("Przynajmniej jedno z wymaganych pól jest nieuzupełnione!", "Błąd!");
            }
            else if (TPassword1.Text != TPassword2.Text)
            {
                MessageBox.Show("Podane hasła nie są identyczne!", "Błąd!");
            }
            else
            {
                if (Communique.PassChng(Program.userLogin, TPasswordOld.Text, TPassword1.Text) == true)
                {
                    MessageBox.Show("Zmiana hasła przebiegła pomyślnie!\nZaloguj się ponownie!", "Sukces!");
                    Program.userLogin = "";
                    DialogResult = DialogResult.No;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Stare hasło jest niepoprawne!", "Błąd!");
                }
            }
        }

        private void BDeleteAccount_Click(object sender, EventArgs e)
        {
            if (TPassword.Text == "")
            {
                MessageBox.Show("Wymagane pole jest nieuzupełnione!", "Błąd!");
            }
            else
            {
                if (Communique.AccDel(Program.userLogin, TPassword.Text) == true)
                {
                    MessageBox.Show("Usunięcie konta użytkownika " + Program.userLogin + "przebiegła pomyślnie!", "Sukces!");
                    Program.userLogin = "";
                    DialogResult = DialogResult.No;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podane dane logowania są niepoprawne!", "Błąd!");
                }
            }
        }
    }
}
