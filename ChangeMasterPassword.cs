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
    public partial class ChangeMasterPassword : UserControl
    {
        public ChangeMasterPassword()
        {
            InitializeComponent();
            resetFailText();
        }
        private void resetFailText()
        {
            FailText.Visible = false;
        }
        private void showFailText()
        {
            FailText.Visible = true;
        }
        private void MasterPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            resetFailText();
        }

        private void LoginTItle_Click(object sender, EventArgs e)
        {

        }

        private void NewPWTextbox_TextChanged(object sender, EventArgs e)
        {
            resetFailText();
        }
        public void cleanup()
        {
            MasterPasswordTextbox.PasswordChar = '*';
            NewPWTextbox.PasswordChar = '*';
            NewPWTextbox.Text = "";
            MasterPasswordTextbox.Text = "";
            ShowNewMasterPassword.Text = "show";
            ShowMasterPassword.Text = "show";
            resetFailText();
        }

        private void ShowMasterPassword_Click(object sender, EventArgs e)
        {
            resetFailText();
            MasterPasswordTextbox.PasswordChar = MasterPasswordTextbox.PasswordChar == '*' ? '\0' : '*';
            ShowMasterPassword.Text = ShowMasterPassword.Text == "show" ? "hide" : "show";
        }

        private void ShowNewMasterPassword_Click(object sender, EventArgs e)
        {
            resetFailText();
            NewPWTextbox.PasswordChar = NewPWTextbox.PasswordChar == '*' ? '\0' : '*';
            ShowNewMasterPassword.Text = ShowNewMasterPassword.Text == "show" ? "hide" : "show";
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string username = DB.getUsername(Gui.UID);
            string oldPW = MasterPasswordTextbox.Text;
            string newPW = NewPWTextbox.Text;
            int user = DB.authenticate(username, oldPW);
            if (user != -1)
            {
                DB.changeMasterPassword(user, oldPW, newPW);
                Gui.key = CryptoHelper.generateDerivedKey(newPW,DB.getSalt(Gui.UID));
                Gui.ChangeWindowLoggedIn(ScreenType.PWDisplay);
            }
            else
            {
                showFailText();
            }
        }
    }
}
