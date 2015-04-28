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
            if (connection.SQLQueryWithOutput("SELECT RFID_CODE, USER_NAME, USER_ADDRESS, USER_PHONE, USER_BANK_ACC, USER_BAN_STATE FROM PT_USER_ACC", out output, out exception))
            {
                foreach (List<string> list in output)
                {
                    bool tempBool;
                    if (list[5] == "1")
                    {
                        tempBool = true;
                    }
                    else
                    {
                        tempBool = false;
                    }
                    Guest tempGuest = new Guest(list[0], list[1], list[2], list[3], list[4], tempBool);
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
            RefreshTextboxes();
        }

        private void RefreshTextboxes()
        {
            Guest tempGuest  = (Guest)lbUserAccounts.SelectedItem;
            tbUserName.Text = tempGuest.UserName;
            tbRFIDCode.Text = tempGuest.RFIDCode;
            tbAdress.Text = tempGuest.Adress;
        }

        private void lbUserAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTextboxes();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            Guest tempGuest = (Guest)lbUserAccounts.SelectedItem;
            string query = "UPDATE PT_USER_ACC SET RFID_CODE = '" + tbRFIDCode.Text + "', USER_NAME = '" + tbUserName.Text + "', USER_ADDRESS = '" + tbAdress.Text + "' WHERE RFID_CODE = '" + tempGuest.RFIDCode + "'";
            Exception exception;
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show("Changes to " + tempGuest.UserName + " are succesfully processed");
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshGuestsListbox();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Guest tempGuest = (Guest)lbUserAccounts.SelectedItem;
            string query = "DELETE FROM PT_USER_ACC WHERE RFID_CODE = '" + tempGuest.RFIDCode + "'";
            Exception exception;
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show(tempGuest.UserName + " is sucessfully deleted");
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshGuestsListbox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
