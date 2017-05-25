using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
            string response = String.Empty;
            int numberOfComm = 0;
            while (numberOfComm<2)
            {
                response=Program.client.Receive();
                if (response.Length > 0)
                {
                    Communique.commFromServer(response);
                    numberOfComm++;
                }
            }
            Thread.Sleep(1000);
            Program.client.Disconnect();
        }

        public SecConv()
        {
            InitializeComponent();
            this.Text = Program.userLogin + " - SecConv";
            commThread = new Thread(waitForCommuniques);
            commThread.Start();
            timer1.Start();
        }

        private void BCall_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano żadnego znajomego!", "Błąd!");
            }
            else if (listView1.SelectedItems[0].ImageIndex==0)
            {
                Program.client = new SynchronousClient(Program.serverAddress);
                Communique.CallState(Program.userLogin, listView1.SelectedItems[0].Text, DateTime.Now, TimeSpan.Zero);
                MessageBox.Show("Znajomy nie jest dostępny! Wysłano powiadomienie o próbie nawiązania połączenia.", "Błąd!");
                Program.client.Disconnect();
            }
            else
            {
                Program.voice.Call();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
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
                Program.client = new SynchronousClient(Program.serverAddress);
                if (Communique.DelFriend(Program.userLogin, listView1.SelectedItems[0].Text) == true)
                {
                    MessageBox.Show("Pomyślnie usunięto " + listView1.SelectedItems[0].Text + " ze znajomych!", "Sukces!");
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    listView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Nastąpił błąd podczas usuwania znajomego!", "Błąd!");
                }
                Program.client.Disconnect();
            }
        }

        private void BAddFriend_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog();
            if (promptValue != "")
            {
                Program.client = new SynchronousClient(Program.serverAddress);
                if (Communique.AddFriend(Program.userLogin, promptValue)==true)
                {
                    MessageBox.Show("Pomyślnie dodano " + promptValue + " do znajomych!", "Sukces!");
                }
                else
                {
                    MessageBox.Show("Nie znaleziono użytkownika o podanym loginie lub masz już go w znajomych!", "Błąd!");
                }
                Program.client.Disconnect();
            }
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
                Program.client = new SynchronousClient(Program.serverAddress);
                if (Communique.PassChng(Program.userLogin, TPasswordOld.Text, TPassword1.Text) == true)
                {
                    MessageBox.Show("Zmiana hasła przebiegła pomyślnie!\nZaloguj się ponownie!", "Sukces!");
                    DialogResult = DialogResult.No;
                    Program.client.Disconnect(); 
                    this.Close();
                }
                else
                {
                    Program.client.Disconnect();
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
                Program.client = new SynchronousClient(Program.serverAddress);
                if (Communique.AccDel(Program.userLogin, TPassword.Text) == true)
                {
                    MessageBox.Show("Usunięcie konta użytkownika " + Program.userLogin + " przebiegła pomyślnie!", "Sukces!");
                    DialogResult = DialogResult.No;
                    Program.client.Disconnect();
                    this.Close();
                }
                else
                {
                    Program.client.Disconnect();
                    MessageBox.Show("Podane dane logowania są niepoprawne!", "Błąd!");
                }
            }
        }

        private void SecConv_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                timer1.Stop();
                if (commThread.IsAlive)
                {
                    Program.client.Disconnect();
                    commThread.Abort();
                }
                Program.client = new SynchronousClient(Program.serverAddress);
                Communique.LogOut(Program.userLogin);
                Program.userLogin = "";
                Program.serverAddress = "";
                Program.client.Disconnect();               
            }
            catch (SocketException)
            {
                MessageBox.Show("Problem z połączeniem z serwerem!", "Błąd!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.client = new SynchronousClient(Program.serverAddress);
            Communique.Iam(Program.userLogin);
            Program.client.Disconnect();
        }
    }

    public static class Prompt
    {
        public static string ShowDialog()
        {
            Form prompt = new Form()
            {
                Width = 260,
                Height = 145,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Dodaj znajomego",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 19, Top = 15, Width = 200, Text = "Podaj login znajomego:" };
            
            TextBox textBox = new TextBox() { Left = 20, Top = 35, Width = 200 };


            Button confirmation = new Button() { Text = "Dodaj", Left = 141, Width = 80, Height = 26, Top = 65,
                BackColor = System.Drawing.Color.Brown,
                ForeColor = System.Drawing.SystemColors.ControlLightLight, DialogResult = DialogResult.OK };

            confirmation.FlatAppearance.BorderSize = 0;
            confirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            confirmation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            confirmation.UseVisualStyleBackColor = false;

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
