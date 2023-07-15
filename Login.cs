using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pwmanagerGUI
{
    public partial class Login : UserControl
    {
        public int UID = -1;
        public byte[] key = new byte[0];
        public Login()
        {
            InitializeComponent();
            pwtxt.Visible = false;
        }


        private void UNLoginText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginToCreateAccount_Click(object sender, EventArgs e)
        {
            resetText();
            Gui.login_goBack_Click();
        }
        private void resetText()
        {
            pwtxt.Visible = false;
            LoginUsernameTB.Text = string.Empty;
            PWloginTextbox.Text = string.Empty;
        }

        private void PWloginTextbox_TextChanged(object sender, EventArgs e)
        {
            pwtxt.Visible = false;
        }

        private void LoginUsernameTB_TextChanged(object sender, EventArgs e)
        {
            pwtxt.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameTB.Text;
            string password = PWloginTextbox.Text;
            int loginStatus = DB.authenticate(username, password);
            if (loginStatus == -1)
            {
                pwtxt.Visible = true;
            }
            else { 
                this.UID =  loginStatus;
                this.key = CryptoHelper.generateDerivedKey(password, DB.getSalt(UID));
                resetText();
                Gui.LoginToDashBoard();
            }

        }

        private void ShowPW_Click(object sender, EventArgs e)
        {
            if (PWloginTextbox.PasswordChar == '*')
            {
                PWloginTextbox.PasswordChar = '\0';
                ShowPW.Text = "hide password";
            }
            else { PWloginTextbox.PasswordChar = '*'; ShowPW.Text = "show password"; }
        }

        private void pwtxt_Click(object sender, EventArgs e)
        {

        }
    }
}
