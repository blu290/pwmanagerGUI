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
    public partial class MakeNewPW : UserControl
    {
        public MakeNewPW()
        {
            InitializeComponent();
        }

        public void cleanup()
        {
            PWTextbox.Text = "";
            UNTextbox.Text = "";
            SNTextBox.Text = "";
            PWTextbox.PasswordChar = '*';
            OverwriteExisting.Checked = false;

        }
        private void LoginTItle_Click(object sender, EventArgs e)
        {

        }

        private void MakeNewPW_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void generateRandomPWButton_Click(object sender, EventArgs e)
        {
            PWTextbox.Text = CryptoHelper.generatePW(20);
        }

        private void ShowPW_Click(object sender, EventArgs e)
        {
            if (PWTextbox.PasswordChar == '*')
            {
                PWTextbox.PasswordChar = '\0';
            }
            else
                PWTextbox.PasswordChar = '*';
        }

        private void CreateEntryButton_Click(object sender, EventArgs e)
        {
            string serviceName, username, password;
            password = PWTextbox.Text;
            username = UNTextbox.Text;
            serviceName = SNTextBox.Text;
            if (DB.PWExists(serviceName, username))
            {
                if (OverwriteExisting.Checked)
                {
                    DB.deletePW(serviceName, username);
                    DB.addPW(serviceName, username, password, Gui.UID, Gui.key);
                    cleanup();
                }
            }
            else
            {
                DB.addPW(serviceName, username, password, Gui.UID, Gui.key);
                cleanup();
            }
        }
    }
}
