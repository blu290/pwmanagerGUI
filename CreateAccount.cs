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
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void mainLogin_Click(object sender, EventArgs e)
        {
            Gui.CA_mainLogin_Click();
        }

        private void mainPagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPageTitle_Click(object sender, EventArgs e)
        {

        }

        private void mainCreateAccount_Click(object sender, EventArgs e)
        {
            Gui.CAMainCreateAccountClick();
        }
    }
}
