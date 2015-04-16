using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AccessControl
{
    public partial class AccessControlForm : Form
    {
        readonly Connection connect = new Connection();
        readonly Select select = new Select();
        readonly Update update = new Update();
        readonly Delete delete = new Delete();

        public AccessControlForm()
        {
            InitializeComponent();
            Refresh();
        }

        public override void Refresh()
        {
            lbRFIDCodes.Items.Clear();

            try
            {
                var locations = select.Select_reserves();

                foreach (Dictionary<string, object> row in locations)
                {
                    lbRFIDCodes.Items.Add("Reserve_Code: " + row["RFID_CODE"] + ". RFID_Code: " + row["USER_CODE"] + ". Name: " + row["USER_NAME"] + ". Amount of people: " + row["PERSON_AMOUNT"] + ". Paid: " + row["PAID"] + ".");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RefreshOnRFID(string rfidCode)
        {
            lbRFIDCodes.Items.Clear();
            try
            {
                var locations = select.Select_reservesOnRFID(rfidCode);

                foreach (Dictionary<string, object> row in locations)
                {
                    lbRFIDCodes.Items.Add("Reserve_Code: " + row["RFID_CODE"] + ". RFID_Code: " + row["USER_CODE"]+ ". Name: " + row["USER_NAME"] + ". Amount of people: " + row["PERSON_AMOUNT"] + ". Paid: " + row["PAID"] + ".");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        private void bttnSearsh_Click(object sender, EventArgs e)
        {
            string rfidCode = tbRFIDSearsh.Text;
            RefreshOnRFID(rfidCode);
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            tbRFIDSearsh.Text = "";
            Refresh();
        }

        private void BttnPayed_Click(object sender, EventArgs e)
        {
            string selectedReserveCode = lbRFIDCodes.SelectedItem.ToString().Substring(14, 1);
            string selectedRFIDCode = lbRFIDCodes.SelectedItem.ToString().Substring(28, 1);

            string updating = update.Update_Paid(selectedReserveCode);
            
            MessageBox.Show(updating);

            RefreshOnRFID(selectedRFIDCode);
            tbRFIDSearsh.Text = selectedRFIDCode;
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            string selectedReserveCode = lbRFIDCodes.SelectedItem.ToString().Substring(14, 1);

            bool location = update.Update_location(selectedReserveCode);
            bool user = update.Update_user(selectedReserveCode);
            bool material = update.Update_Material(selectedReserveCode);

            if (location == true | user == true | material == true)
            {
                bool removeReservation = delete.Delete_Reservation(selectedReserveCode);
                if (removeReservation == true)
                {
                    MessageBox.Show("Reservation has been deleted from the system");
                }
                else
                {
                    MessageBox.Show("Failed to delete reservation");
                }
            }
            else
            {
                MessageBox.Show("Failed to update Foreign tables");
            }
        }
    }
}
