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
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gui.Logout();
        }
        public void UpdateUsername(string text)
        {
            UserNameText.Text = text;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Gui.ChangeWindowLoggedIn(ScreenType.PWDisplay);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Gui.ChangeWindowLoggedIn(ScreenType.ChangeUserPW);
        }

        private void CreateEntry_Click(object sender, EventArgs e)
        {
            Gui.ChangeWindowLoggedIn(ScreenType.makeNewPW);
        }
    }
}
