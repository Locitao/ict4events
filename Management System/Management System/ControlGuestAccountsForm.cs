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
        /// <summary>
        /// manage all guests' accounts here
        /// </summary>
        public ControlGuestAccountsForm()
        {
            InitializeComponent();
            RefreshGuestsListbox();
        }

        /// <summary>
        /// retreive all guest information from the database and put it in the listbox
        /// </summary>
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

        /// <summary>
        /// refresh the textboxes with the selected guest's info
        /// </summary>
        private void RefreshTextboxes()
        {
            Guest tempGuest  = (Guest)lbUserAccounts.SelectedItem;
            tbUserName.Text = tempGuest.UserName;
            tbRFIDCode.Text = tempGuest.RFIDCode;
            tbAdress.Text = tempGuest.Adress;
        }

        /// <summary>
        /// refresh the textboxes when another guest has been selected
        /// </summary>
        private void lbUserAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTextboxes();
        }

        /// <summary>
        /// Save the changes that were made to the selected user
        /// </summary>
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

        /// <summary>
        /// Delete the selected guest account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Close this form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Makes sure the user can only type letters, digits and spaces.
        /// </summary>
        private void tb_KeyPress_LettersDigitsAndSpaces(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Makes sure the user can only type letters and digits.
        /// </summary>
        private void tb_KeyPress_LettersAndDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
