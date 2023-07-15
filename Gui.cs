using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace pwmanagerGUI
{
    public partial class Gui : Form
    {
        public static ScreenType selectedScreen;
        public static int UID = -1;
        public static byte[] key = new byte[0];

        static HomeScreen createAccount = new HomeScreen();
        static Login login = new Login();
        static CreateAccountPage createAccountPage = new CreateAccountPage();
        static PWDisplay pwDisplay = new PWDisplay();
        static MakeNewPW makenewPWScreen = new MakeNewPW();
        static Sidebar sidebar = new Sidebar();
        static ChangeMasterPassword changeMasterPassword = new ChangeMasterPassword();
        public static Dictionary<ScreenType, UserControl> screenMap = new Dictionary<ScreenType, UserControl>()
        {
            {ScreenType.PWDisplay,pwDisplay},
            {ScreenType.makeNewPW,makenewPWScreen},
            {ScreenType.ChangeUserPW,changeMasterPassword}
        };
        public Gui()
        {
            InitializeComponent();
            sidebarPanel.Controls.Add(sidebar);
            sidebarPanel.Visible = true;
            mainPanel.Controls.Add(makenewPWScreen);
            mainPanel.Controls.Add(login);
            mainPanel.Controls.Add(createAccount);
            mainPanel.Controls.Add(createAccountPage);
            mainPanel.Controls.Add(pwDisplay);
            mainPanel.Controls.Add(changeMasterPassword);
            createAccount.Dock = DockStyle.Fill;
            login.Dock = DockStyle.Fill;
            changeMasterPassword.Dock = DockStyle.Fill;
            createAccountPage.Dock = DockStyle.Fill;
            pwDisplay.Dock = DockStyle.Fill;
            sidebar.Dock = DockStyle.Fill;
            makenewPWScreen.Dock = DockStyle.Fill;
            makenewPWScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            changeMasterPassword.Visible = false;
            login.Visible = false;
            createAccount.Visible = true;
            createAccountPage.Visible = false;
            sidebar.Visible = false;
            pwDisplay.Visible = false;
            makenewPWScreen.Visible = false;
        }
        public static void togglePanelVisibility(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }
        public static void ChangeWindowLoggedIn(ScreenType desired)
        {
            screenMap[selectedScreen].Visible = false;
            screenMap[desired].Visible = true;
            if (desired == ScreenType.PWDisplay)
            {
                pwDisplay.refreshTable();
            }
            selectedScreen = desired;
        }
        public static void disableLoginView()
        {
            screenMap[selectedScreen].Visible = false;
        }
        public static void CAMainCreateAccountClick()
        {
            createAccount.Visible = false;
            createAccountPage.Visible = true;
        }
        public static void CA_mainLogin_Click()
        {
            createAccount.Visible = false;
            login.Visible = true;
        }
        public static void login_goBack_Click()
        {
            login.Visible = false;
            createAccount.Visible = true;
        }
        public static void CreateAccountPageToCreateAccount()
        {
            createAccountPage.Visible = false;
            createAccount.Visible = true;
        }
        public static void LoginToDashBoard()
        {
            login.Visible = false;
            UID = login.UID;
            key = login.key;
            sidebar.UpdateUsername(DB.getUsername(UID));
            pwDisplay.refreshTable();
            sidebar.Visible = true;
            pwDisplay.Visible = true;
            selectedScreen = ScreenType.PWDisplay;
        }
        public static void Logout()
        {
            sidebar.Visible = false;
            pwDisplay.refreshTable();
            UID = -1;
            key = new byte[0];
            createAccount.Visible = true;
            disableLoginView();
            makenewPWScreen.cleanup();
            changeMasterPassword.cleanup();
        }
        private void Gui_Load(object sender, EventArgs e)
        {

        }

        public static List<PWEntry> GetPWEntries(int UID)
        {
            return new List<PWEntry>();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
