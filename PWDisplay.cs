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
    public partial class PWDisplay : UserControl
    {
        DataTable PWSource = new DataTable();
        public PWDisplay()
        {
            InitializeComponent();
            TableSetup();
            PWTable.DataSource = PWSource;
        }
        private void TableSetup()
        {
            PWSource.Columns.Add("Service Name", typeof(string));
            PWSource.Columns.Add("username", typeof(string));
            PWSource.Columns.Add("password", typeof(string));
        }
        public void refreshTable()
        {
            PWSource.Rows.Clear();
            List<PWEntry> pWEntries = DB.retrieveAllPW(Gui.UID);
            foreach (var pw in pWEntries)
            {
                PWSource.Rows.Add(pw.getServiceName(), pw.getUserName(), pw.getDecryptedPassword(Gui.key));
            }
            PWTable.Refresh();

        }
        private void PWTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PWDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
