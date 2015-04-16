﻿using System;
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
    public partial class EvenementManagementSystemForm : Form
    {
        private DatabaseConnection connection = new DatabaseConnection();
        private List<Camping> campingList = new List<Camping>();
        private List<Location> locationList = new List<Location>();

        public EvenementManagementSystemForm()
        {
            InitializeComponent();
            refreshCampingsData();
            cbType.Items.Add(LocationType.bungalow);
            cbType.Items.Add(LocationType.tent);
            cbType.Items.Add(LocationType.preplacedtent);
            cbType.Items.Add(LocationType.caravan);
        }

        private void refreshCampingsData()
        {
            campingList.Clear();
            lbCampings.Items.Clear();
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT CAMPING_ID, CAMPING_NAME, CAMPING_MAP FROM PT_CAMPING", out output, out exception))
            {
                foreach(List<string> list in output)
                {
                    Camping tempCamping = new Camping(Convert.ToInt32(list[0]), list[1], list[2]);
                    campingList.Add(tempCamping);
                    lbCampings.Items.Add(tempCamping);
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            lbCampings.SelectedIndex = 0;
            refreshLocationsData();
        }

        private void refreshLocationsData()
        {
            locationList.Clear();
            lbLocations.Items.Clear();
            Camping selectedCamping = (Camping)lbCampings.SelectedItem;
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT LOCATION_ID, CAMPING_ID, RESERVATION_ID, LOC_TYPE, PRICE, MAX_PEOPLE FROM PT_EVENT_LOCATION WHERE CAMPING_ID = '" + selectedCamping.CampingID.ToString() +"' ORDER BY location_ID", out output, out exception))
            {
                foreach (List<string> list in output)
                {
                    LocationType type;
                    Enum.TryParse(list[3], out type);
                    int tempInt = 0;
                    if (list[2] != "")
                    {
                        tempInt = Convert.ToInt32(list[2]);
                    }
                    Location tempLocation = new Location(Convert.ToInt32(list[0]), Convert.ToInt32(list[1]), tempInt, type, Convert.ToInt32(list[4]), Convert.ToInt32(list[5]));
                    locationList.Add(tempLocation);
                    lbLocations.Items.Add(tempLocation);
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            lbLocations.SelectedIndex = 0;
        }

        

        private void lbCampings_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNewCamping_Click(object sender, EventArgs e)
        {
            string campingName = tbCampingName.Text;
            string mapPath = tbMapPath.Text;
            string query = "Insert into PT_CAMPING(camping_ID, camping_name, camping_map) VALUES(auto_inc_cam.nextval,'" + campingName + "', '" + mapPath + "')";
            Exception ex;
            if (connection.SQLQueryNoOutput(query, out ex))
            {
                MessageBox.Show("New camping is succesfully added to our system.");
                refreshCampingsData();
                tbCampingName.Text = "";
                tbMapPath.Text = "";
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + ex.ToString());
            }

        }

        private void btnDeleteCamping_Click(object sender, EventArgs e)
        {
            if (lbCampings.SelectedItem != null)
            {
                Camping selectedCamping = (Camping)lbCampings.SelectedItem;
                string query = "DELETE FROM PT_CAMPING WHERE camping_ID = " + selectedCamping.CampingID.ToString();

                Exception ex;
                if (connection.SQLQueryNoOutput(query, out ex))
                {
                    MessageBox.Show("Selected camping is succesfully removed from our  system.");
                    refreshCampingsData();
                }
                else
                {
                    MessageBox.Show("The following error has occured:" + Environment.NewLine + Environment.NewLine + ex.ToString());
                }
            }
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Location l in locationList)
                {
                    if (numLocation.Value == l.CampingID)
                    {
                        throw new Exception("Location ID is already in use");
                    }
                }
                Camping tempCamping;
                if (lbCampings.SelectedItem != null)
                {
                    tempCamping = (Camping)lbCampings.SelectedItem;
                }
                else
                {
                    throw new Exception("No camping selected");
                }
                Location tempLocation = new Location(Convert.ToInt32(numLocation.Value), tempCamping.CampingID, 0, (LocationType)cbType.SelectedItem, Convert.ToInt32(numPrice.Value), Convert.ToInt32(numMaxGuests.Value));
                string query = "Insert into PT_EVENT_LOCATION(location_ID, camping_id, loc_type, price, max_people) Values(auto_inc_loc.nextval, '" + tempLocation.CampingID + "', '" + tempLocation.Type.ToString() + "', '" + tempLocation.Price.ToString() + "', '" + tempLocation.MaxPeople.ToString() + "')";
                Exception ex;
                if (connection.SQLQueryNoOutput(query, out ex))
                {
                    MessageBox.Show("New location is succesfully added to our system.");
                    refreshCampingsData();
                }
                else
                {
                    MessageBox.Show("The following error has occured:" + Environment.NewLine + ex.ToString());
                } 
            }
            catch(Exception ex)
            {
                if (ex.Message == "Location ID is already in use")
                {
                    MessageBox.Show("The location ID you selected is already in use.");
                }
                else if (ex.Message == "No camping selected")
                {
                    MessageBox.Show("There is no camping selected in the camping list");
                }
            }
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            if (lbCampings.SelectedItem != null)
            {
                Location selectedLocation = (Location)lbLocations.SelectedItem;
                string query = "DELETE FROM PT_EVENT_LOCATION WHERE location_ID = " + selectedLocation.LocationID.ToString();

                Exception ex;
                if (connection.SQLQueryNoOutput(query, out ex))
                {
                    MessageBox.Show("Selected location is succesfully removed from our  system.");
                    refreshCampingsData();
                }
                else
                {
                    MessageBox.Show("The following error has occured:" + Environment.NewLine + Environment.NewLine + ex.ToString());
                }
            }
        }

        

        
    }
}
