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
    public partial class CreateAccountPage : UserControl
    {
        public CreateAccountPage()
        {
            InitializeComponent();
            UNTaken.Visible = false;
        }

        private void LoginTItle_Click(object sender, EventArgs e)
        {

        }

        private void ShowPW_Click(object sender, EventArgs e)
        {
            if (PWloginTextbox.PasswordChar == '*')
            {
                PWloginTextbox.PasswordChar = '\0';
                ShowPW.Text = "hide password";
            }
            else
            {
                PWloginTextbox.PasswordChar = '*';
                ShowPW.Text = "show password";
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            resetText();
            Gui.CreateAccountPageToCreateAccount();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameTB.Text;
            string password = PWloginTextbox.Text;
            if (DB.isUsernameUnique(username)&& username != "\0" && username != "")
            {
                DB.addAccount(username, password);
                var temptxt = UNTaken.Text;
                var tempcolor = UNTaken.ForeColor;
                UNTaken.ForeColor = Color.Green;
                UNTaken.Text = "Account Created";
                UNTaken.Visible = true;
                this.Update();
                Thread.Sleep(1000);
                UNTaken.ForeColor = tempcolor;
                UNTaken.Text = temptxt;
                resetText();
                Gui.CreateAccountPageToCreateAccount();
            }
            else {
                UNTaken.Visible = true;
            }
        }
        void resetText() {
            LoginUsernameTB.Text = string.Empty;
            PWloginTextbox.Text = string.Empty;
            UNTaken.Visible = false;
            PWloginTextbox.PasswordChar = '*';
            ShowPW.Text = "show password";

        }
        private void PWloginTextbox_TextChanged(object sender, EventArgs e)
        {
            UNTaken.Visible = false;
        }

        private void PWloginText_Click(object sender, EventArgs e)
        {

        }

        private void UNLoginText_Click(object sender, EventArgs e)
        {
        }

        private void LoginUsernameTB_TextChanged(object sender, EventArgs e)
        {
            UNTaken.Visible = false;
        }

        private void pwtxt_Click(object sender, EventArgs e)
        {
        }
    }
}
