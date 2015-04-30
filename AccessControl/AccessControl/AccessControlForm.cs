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
    /// <summary>
    /// This is the form where everything happens.
    /// </summary>
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

        /// <summary>
        /// Refresh refreshes the information that's currently shown on-screen.
        /// </summary>
        /// <param name="RFID"></param>
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

        /// <summary>
        /// Updates the event_ID, becomes 0 if the user leaves, 1 if he enters the terrain.
        /// </summary>
        /// <param name="RFID"></param>
        public void changePresence(string RFID)
        {
            
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
        
        /// <summary>
        /// Updates the paid status of the selected RFID account.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BttnPayed_Click(object sender, EventArgs e)
        {
            try
            {  
                       
                string RFID = lbRFIDCodes.SelectedItem.ToString().Substring(23, 10);

                update.Update_Paid(RFID);                
                Refresh(RFID);
            }
            catch
            {
                MessageBox.Show("No user selected");
            }
        }

        /// <summary>
        /// Updates foreign key tables and deletes the reserve_ID in those.
        /// Then it deletes the main reservation table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                
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

        /// <summary>
        /// Shows the amount of people on the terrain.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Checks if the rfid search box has 10 characters (length of an rfid code).
        /// If it does, it calls the method refreshOnRfid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tmrRFIDCheck_Tick(object sender, EventArgs e)
        {
            
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