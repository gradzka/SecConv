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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BBack_BRegister_Click(object sender, EventArgs e)
        {
            if(TLogin.Text=="" || TPassword1.Text=="" || TPassword2.Text=="")
            {
                MessageBox.Show("Przynajmniej jedno z wymaganych pól jest nieuzupełnione!", "Błąd!");
            }
            else if(TPassword1.Text!= TPassword2.Text)
            {
                MessageBox.Show("Podane hasła nie są identyczne!", "Błąd!");
            }
            else
            {
                if (Communique.Register(TLogin.Text, TPassword1.Text) == true)
                {
                    MessageBox.Show("Rejestracja użytkownika " + TLogin.Text + "przebiegła pomyślnie!", "Sukces!");
                    this.DialogResult = DialogResult.No;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podany login jest już zajęty!", "Błąd!");
                }
            }
        }

    }
}
