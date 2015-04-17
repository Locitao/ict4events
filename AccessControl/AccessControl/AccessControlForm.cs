using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

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
            tmrRFIDCheck.Start();
        }
        private void bttnRefresh_Click(object sender, EventArgs e)
        {           
            tbRFIDSearsh.Text = "";
            Refresh();
        }

        public override void Refresh()
        {
            lbRFIDCodes.Items.Clear();
            lblRFID.Text = "";

            try
            {
                var reserves = select.Select_Reserves();

                foreach (Dictionary<string, object> row in reserves)
                {
                    string present = Convert.ToString(row["EVENT_ID"]);
                    string paid = Convert.ToString(row["PAID"]);
                    if (present != "")
                    {
                        present = "Yes";
                    }
                    else
                    {
                        present = "No";
                    }
                    if (paid == "1")
                    {
                        paid = "Yes";
                    }
                    else
                    {
                        paid = "no";
                    }

                    lbRFIDCodes.Items.Add("Reserve ID: " + row["RESERVE_CODE"] + ". RFID: " + row["RFID_CODE"] + ". Name: " + row["USER_NAME"] + ". Amount of people: " + row["PERSON_AMOUNT"] + ". " + "Paid?: " + paid + ". Present?: " + present);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefreshOnRFID(string rfid)
        {
            lbRFIDCodes.Items.Clear();

            try
            {
                var reserves = select.Select_ReservesOnRFID(rfid);

                foreach (Dictionary<string, object> row in reserves)
                {
                    string present = Convert.ToString(row["EVENT_ID"]);
                    string paid = Convert.ToString(row["PAID"]);

                    if (present != "")
                    {
                        present = "Yes";
                    }
                    else
                    {
                        present = "No";
                    }
                    if (paid == "1")
                    {
                        paid = "Yes";
                    }
                    else
                    {
                        paid = "no";
                    }

                    lbRFIDCodes.Items.Add("Reserve ID: " + row["RESERVE_CODE"] + ". RFID: " + row["RFID_CODE"] + ". Name: " + row["USER_NAME"] + ". Amount of people: " + row["PERSON_AMOUNT"] + ". " + "Paid?: " + paid + ". Present?: " + present);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void BttnPayed_Click(object sender, EventArgs e)
        {
            try
            {            
                string ReserveID = lbRFIDCodes.SelectedItem.ToString().Substring(12, 1);
                string RFID = lbRFIDCodes.SelectedItem.ToString().Substring(21, 1);

                update.Update_Paid(ReserveID);
                RefreshOnRFID(RFID);
            }
            catch
            {
                MessageBox.Show("No user selected");
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string ReserveID = lbRFIDCodes.SelectedItem.ToString().Substring(12, 1);

                bool location = update.Update_location(ReserveID);
                bool material = update.Update_Material(ReserveID);
                bool user = update.Update_user(ReserveID);

                if (user == true)
                {
                    delete.Delete_Reservation(ReserveID);
                }
                else
                {
                    MessageBox.Show("Cancel of reservation has failed. " + ReserveID + user);
                }
            }
            catch
            {
                MessageBox.Show("No user selected");
            }
        }

        private void bttnPresence_Click(object sender, EventArgs e)
        {
            try
            {
                string RFID = lbRFIDCodes.SelectedItem.ToString().Substring(21, 1);
                bool gelukt = update.Update_CheckPresent(RFID);
                if (gelukt == true)
                {
                    MessageBox.Show("User can leave/enter event");
                    RefreshOnRFID(RFID);
                }
                else
                {
                    MessageBox.Show("Action failed");
                }
            }
            catch
            {
                MessageBox.Show("No user selected");
            }
        }

        private void tmrRFIDCheck_Tick(object sender, EventArgs e)
        {
            if (tbRFIDSearsh.TextLength == 10)
            {
                string RFID = tbRFIDSearsh.Text;
                RefreshOnRFID(RFID);
                lblRFID.Text = RFID;
                
                tbRFIDSearsh.Text = "";
            }
        }
    }
}
