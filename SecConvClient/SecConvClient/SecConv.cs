using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecConvClient
{
    public partial class SecConv : Form
    {
        Thread commThread;
        public EndPoint callerEndPoint;
        public DateTime begin;
        public DateTime end;
        public bool isReceiver = false;

        void waitForCommuniques()
        {
            Thread.Sleep(200);
            string response = String.Empty;
            int numberOfComm = 0;
            while (numberOfComm<2)
            {
                try
                {
                    response = Program.client.Receive();
                    if (response.Length > 0)
                    {
                        Communique.commFromServer(response);
                        numberOfComm++;
                    }
                }
                catch (Exception)
                {  }
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
            timerIAM.Start();
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
                string[] historyDetails=new string[3];
                historyDetails[0] = listView1.SelectedItems[0].Text;
                historyDetails[1] = DateTime.Now.ToString();
                historyDetails[2] = "nieodebrane";
                listView2.Items.Insert(0,(new ListViewItem(historyDetails)));
                listView2.Refresh();
                MessageBox.Show("Znajomy nie jest dostępny! Wysłano powiadomienie o próbie nawiązania połączenia.", "Niedostępny znajomy!");
                Program.client.Disconnect();
            }
            else
            {
                LUserCallOut.Text = "z " + listView1.SelectedItems[0].Text.ToString();
                gBCallOut.Visible = true;
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
                try
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
                catch (Exception)
                {
                    MessageBox.Show("Problem z połączeniem z serwerem!", "Błąd!");
                }
            }
        }

        private void BAddFriend_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog();
            if (promptValue != "" && promptValue!=Program.userLogin)
            {
                try
                {
                    Program.client = new SynchronousClient(Program.serverAddress);
                    if (Communique.AddFriend(Program.userLogin, promptValue) == true)
                    {
                        MessageBox.Show("Pomyślnie dodano " + promptValue + " do znajomych!", "Sukces!");
                        string[] friendDetails = { promptValue, "0" };
                        ListViewItem friend = new ListViewItem(friendDetails, 0);
                        Program.secConv.listView1.Items.Add(friend);
                        listView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono użytkownika o podanym loginie lub masz już go w znajomych!", "Błąd!");
                    }
                    Program.client.Disconnect();
                }
                catch (Exception)
                {
                    MessageBox.Show("Problem z połączeniem z serwerem!", "Błąd!");
                }
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
                Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
                Match match = regex.Match(TPassword1.Text);
                if (match.Success)
                {
                    try
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
                    catch (Exception)
                    {
                        MessageBox.Show("Problem z połączeniem z serwerem!", "Błąd!");
                    }
                }
                else
                {
                    MessageBox.Show("Hasło nie spełnia kryteriów!", "Błąd!");
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
                try
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
                catch (Exception)
                {
                    MessageBox.Show("Problem z połączeniem z serwerem!", "Błąd!");
                }
            }
        }

        private void SecConv_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerIAM.Stop();
            if (commThread.IsAlive)
            {
                Program.client.Disconnect();
                commThread.Abort();
            }
            try
            {
                Program.client = new SynchronousClient(Program.serverAddress);
                Communique.LogOut(Program.userLogin);
                Program.client.Disconnect();               
            }
            catch (Exception)
            {
                MessageBox.Show("Problem z połączeniem z serwerem!", "Błąd!");
            }
            Program.userLogin = "";
            Program.serverAddress = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Program.client = new SynchronousClient(Program.serverAddress);
                Communique.Iam(Program.userLogin);
                Program.client.Disconnect();
            }
            catch (Exception)
            {  }
        }

        private void tSBContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                           "Monika Grądzka:\t https://github.com/gradzka \n" +
                           "Robert Kazimierczak:\t https://github.com/kazimierczak-robert",
                           "Autorzy projektu");
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Program.voice.CancelCall();
            Program.client = new SynchronousClient(Program.serverAddress);
            Communique.CallState(Program.userLogin, listView1.SelectedItems[0].Text, DateTime.Now, TimeSpan.Zero);
            string[] historyDetails = new string[3];
            historyDetails[0] = listView1.SelectedItems[0].Text;
            historyDetails[1] = DateTime.Now.ToString();
            historyDetails[2] = "nieodebrane";
            listView2.Items.Insert(0, (new ListViewItem(historyDetails)));
            listView2.Refresh();
            MessageBox.Show("Znajomy nie jest dostępny! Wysłano powiadomienie o próbie nawiązania połączenia.", "Niedostępny znajomy!");
            Program.client.Disconnect();
        }

        private void BAccept_Click(object sender, EventArgs e)
        {
            Program.voice.AcceptCall(callerEndPoint);
            isReceiver = true;
        }

        private void BDecline_Click(object sender, EventArgs e)
        {
            Program.voice.DeclineCall(callerEndPoint);
            gBCallIn.Visible = false;
        }

        private void BDisconnect_Click(object sender, EventArgs e)
        {
            end = DateTime.Now;
            timerConv.Stop();
            Program.voice.DropCall();
            //wyslij do serwera
            Program.client = new SynchronousClient(Program.serverAddress);
            if (isReceiver == true)
            {
                Communique.CallState(LUserConv.Text.Remove(0,2), Program.userLogin, begin, (end - begin)); 
            }
            else
            {
                Communique.CallState(Program.userLogin, LUserConv.Text.Remove(0, 2), begin, (end - begin));
            }
            Program.client.Disconnect();
            isReceiver = false;
        }

        private void timerConv_Tick(object sender, EventArgs e)
        {
            end = DateTime.Now;
            LTimeConv.Text = (end - begin).Hours.ToString().PadLeft(2, '0') + ":" + (end - begin).Minutes.ToString().PadLeft(2, '0') + ":" + (end - begin).Seconds.ToString().PadLeft(2, '0');
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
