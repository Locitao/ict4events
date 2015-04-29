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
        readonly Select select = new Select();        
        readonly Update update = new Update();
        readonly Delete delete = new Delete();       

        public AccessControlForm()
        {            
            InitializeComponent();
            Refresh("");
            tmrRFIDCheck.Start();
        }
        private void bttnRefresh_Click(object sender, EventArgs e)
        {              
            tbRFIDSearsh.Text = "";
            lblResult.Text = "";
            Refresh("");
        }

        public void Refresh(string RFID)
        {
            // Puts all the data in the listbox.
            lbRFIDCodes.Items.Clear();
            bttnCancel.Enabled = true;
            BttnPayed.Enabled = true;

            try
            {
                var reserves = select.Select_Reserves();

                if (RFID != "")
                {
                    reserves = select.Select_ReservesOnRFID(RFID);
                    lblRFID.Text = RFID;
                }
                else
                {
                    lblRFID.Text = "";
                }

                foreach (Dictionary<string, object> row in reserves)
                {
                    string present = Convert.ToString(row["EVENT_ID"]);
                    string paid = Convert.ToString(row["PAID"]);
                    int reserveID = Convert.ToInt32(row["RESERVE_CODE"]);
                    string reservationID = reserveID.ToString();

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

                    if (reserveID < 10)
                    {
                        reservationID = "00" + reserveID;
                    }
                    else if (reserveID < 100)
                    {
                        reservationID = "0" + reserveID;
                    }

                    lbRFIDCodes.Items.Add("Reserve ID: " + reservationID + ". RFID: " + row["RFID_CODE"] + ". Name: " + row["USER_NAME"] + ". Paid?: " + paid + ". Present?: " + present);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void changePresence(string RFID)
        {
            // Updates the Event_ID, 0 if the user leaves and 1 if the user enters.
            try
            {               
                bool gelukt = update.Update_CheckPresent(RFID);
                if (gelukt == true)
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "User can leave/enter";

                    Refresh(RFID);
                }
                else
                {
                    MessageBox.Show("Action failed");
                }
            }
            catch
            {
                MessageBox.Show("Error, contact a admin");
            }
        }
        
        
        private void BttnPayed_Click(object sender, EventArgs e)
        {
            try
            {  
                // Changes paid into 1 or 0, depending on the old status.               
                string RFID = lbRFIDCodes.SelectedItem.ToString().Substring(23, 10);

                update.Update_Paid(RFID);                
                Refresh(RFID);
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
                // Updates foreign key tables and deletes the reserve_ID in those.
                // Then deletes the main reservation table.
                string ReserveID = lbRFIDCodes.SelectedItem.ToString().Substring(12, 3);

                bool location = update.Update_location(ReserveID);
                bool material = update.Update_Material(ReserveID);
                bool user = update.Update_user(ReserveID);

                if (user == true)
                {
                    delete.Delete_Reservation(ReserveID);
                    MessageBox.Show("Reservation has been cancelled.");
                }
                else
                {
                    MessageBox.Show("Cancel of reservation has failed. ");
                }
            }
            catch
            {
                MessageBox.Show("No user selected");
            }
        }

        private void bttnPpleOnTerrain_Click(object sender, EventArgs e)
        {
            lbRFIDCodes.Items.Clear();
            lblRFID.Text = "";
            lblResult.Text = "";

            bttnCancel.Enabled = false;
            BttnPayed.Enabled = false;

            try
            {
                var people = select.Select_peopleOnTerrain();
                string amountOfPeople = select.Select_amountOfPeopleOnTerrain();

                lbRFIDCodes.Items.Add("Amount of people on terrain: " + amountOfPeople);
                lbRFIDCodes.Items.Add("");

                foreach (Dictionary<string, object> row in people)
                {
                    string present = Convert.ToString(row["EVENT_ID"]);
                   
                    if (present != "")
                    {
                        present = "Yes";
                    }
                    else
                    {
                        present = "No";
                    }                   

                    lbRFIDCodes.Items.Add("RFID: " + row["RFID_CODE"] + ". Name: " + row["USER_NAME"] + ". Present?: " + present);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void tmrRFIDCheck_Tick(object sender, EventArgs e)
        {
            // Checks if tbRFIDSearsh has 10 textLength, if so, it will read the rfid code and calls the method refreshOnRFID.
            if (tbRFIDSearsh.TextLength == 10)
            {
                int hasPaid;
                string RFID = tbRFIDSearsh.Text;
                tbRFIDSearsh.Text = "";

                bttnCancel.Enabled = true;
                BttnPayed.Enabled = true;

                try
                {
                    hasPaid = Convert.ToInt32(select.GetPaid(RFID));                    
                    lblRFID.Text = RFID;

                    if (hasPaid != 0)
                    {
                        changePresence(RFID);
                    }
                    else
                    {
                        lblResult.ForeColor = Color.Red;
                        lblResult.Text = "User has not paid yet";
                    }

                    Refresh(RFID);
                }
                catch
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "Invalid user : " + RFID; 
                }                
            }
        }
    }
}