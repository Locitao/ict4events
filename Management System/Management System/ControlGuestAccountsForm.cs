using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class ControlGuestAccountsForm : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        public ControlGuestAccountsForm()
        {
            InitializeComponent();
            RefreshGuestsListbox();
        }

        private void RefreshGuestsListbox()
        {
            lbUserAccounts.Items.Clear();
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT  FROM PT_USER_ACC", out output, out exception))
            {
                foreach (List<string> list in output)
                {
                    Guest tempGuest = new Guest();
                    lbUserAccounts.Items.Add(tempGuest);
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            if (lbUserAccounts.Items.Count > 0)
            {
                lbUserAccounts.SelectedIndex = 0;
            }
        }
    }
}
