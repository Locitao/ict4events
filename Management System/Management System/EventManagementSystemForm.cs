﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Management_System
{
    public partial class EventManagementSystemForm : Form
    {
        private DatabaseConnection connection = new DatabaseConnection();
        private List<Camping> campingList = new List<Camping>();
        private List<Location> locationList = new List<Location>();
        private List<Event> eventList = new List<Event>();
        private string saveFilePath = @"\\SERVER-S80\CampingMaps\";
        private string oldFilePath = "";

        /// <summary>
        /// Main form for the event management system
        /// </summary>
        public EventManagementSystemForm()
        {
            InitializeComponent();
            refreshCampingsData();
            cbType.Items.Add(LocationType.bungalow);
            cbType.Items.Add(LocationType.tent);
            cbType.Items.Add(LocationType.preplacedtent);
            cbType.Items.Add(LocationType.caravan);
            cbType.SelectedIndex = 0;
        }

        /// <summary>
        /// get the data from campings and refresh the campings listbox
        /// </summary>
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
            if (lbCampings.Items.Count > 0)
            {
                lbCampings.SelectedIndex = 0;
            }
            refreshLocationsData();
            refreshEventsData();
        }

        /// <summary>
        /// get the data from camping locations and refresh the locations listbox
        /// </summary>
        private void refreshLocationsData()
        {
            int MaxGuestsOnCamping = 0;
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
                    MaxGuestsOnCamping += tempLocation.MaxPeople;
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            tbMaxVisitors.Text = MaxGuestsOnCamping.ToString();
            if (lbLocations.Items.Count > 0)
            {
                lbLocations.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// get the data from events and refresh the events listbox
        /// </summary>
        private void refreshEventsData()
        {
            eventList.Clear();
            lbEvents.Items.Clear();
            Camping selectedCamping = (Camping)lbCampings.SelectedItem;
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT event_id, camping_id, event_name, event_descr, startdate, enddate FROM PT_EVENT WHERE camping_id = '" + selectedCamping.CampingID.ToString() + "'", out output, out exception))
            {
                foreach (List<string> list in output)
                {
                    Event tempEvent = new Event(Convert.ToInt32(list[1]), Convert.ToInt32(list[0]), list[2], list[3], Convert.ToDateTime(list[4]), Convert.ToDateTime(list[5]));
                    eventList.Add(tempEvent);
                    lbEvents.Items.Add(tempEvent);
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            if (lbEvents.Items.Count > 0)
            {
                lbEvents.SelectedIndex = 0;
            }
        }

        
        /// <summary>
        /// Refresh the locations data when another camping has been selected
        /// </summary>
        private void lbCampings_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshLocationsData();
            refreshEventsData();
        }

        /// <summary>
        /// Create a new camping with a name and a map
        /// </summary>
        private void btnNewCamping_Click(object sender, EventArgs e)
        {
            string campingName = tbCampingName.Text;
            string mapPath = tbMapPath.Text;
            if (mapPath != "" && campingName != "")
            {
                string query = "Insert into PT_CAMPING(camping_ID, camping_name, camping_map) VALUES(auto_inc_cam.nextval,'" + campingName + "', '" + mapPath + "')";
                Exception ex;
                if (connection.SQLQueryNoOutput(query, out ex))
                {
                    File.Copy(oldFilePath, saveFilePath);
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
            else
            {
                MessageBox.Show("Cannot add a camping with no map and/or no name");
            }
        }

        /// <summary>
        /// Deletes the selected camping
        /// </summary>
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

        /// <summary>
        /// Add a camping Location to the selected camping
        /// </summary>
        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            try
            {
                Camping tempCamping;
                if (lbCampings.SelectedItem != null)
                {
                    tempCamping = (Camping)lbCampings.SelectedItem;
                }
                else
                {
                    throw new Exception("No camping selected");
                }
                Location tempLocation = new Location(0, tempCamping.CampingID, 0, (LocationType)cbType.SelectedItem, Convert.ToInt32(numPrice.Value), Convert.ToInt32(numMaxGuests.Value));
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

        /// <summary>
        /// Delete teh selected camping location
        /// </summary>
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


        /// <summary>
        /// This creates an event and puts it in the database.
        /// WARNING, you computer language must be english, because the oracle database can't handle foreign languages.
        /// </summary>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            try{
            Camping tempCamping;
                if (lbCampings.SelectedItem != null)
                {
                    tempCamping = (Camping)lbCampings.SelectedItem;
                }
            else
                {
                    throw new Exception("No camping selected");
                }
            DateTime startDate = dateTimePickerStartingDate.Value;
            DateTime endDate = dateTimePickerEndingDate.Value;
            string selectedCamping = Convert.ToString(tempCamping.CampingID);
            string name = tbEventName.Text;
            string description = tbDescription.Text;
            string query = "Insert into PT_EVENT(event_ID, event_name, event_descr, camping_ID, startdate, enddate) "
                           + "Values(auto_inc_evt.nextval, ' " + name + "', '" + description + "', '" + selectedCamping + "', "
                 + "TO_DATE('" + startDate.ToString("dd-MMM-yyyy hh:mm:ss") + "', 'dd-mm-yyyy hh24:mi:ss')" + ", " + "TO_DATE('" + endDate.ToString("dd-MMM-yyyy hh:mm:ss") + "', 'dd-mm-yyyy hh24:mi:ss')" + ")";
                Exception ex;
                if (connection.SQLQueryNoOutput(query, out ex))
                {
                    MessageBox.Show("New event is succesfully added to our system.");
                    refreshCampingsData();
                }
                else
                {
                    MessageBox.Show("The following error has occured:" + Environment.NewLine + ex.ToString());
                }
            }
            catch
            {

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

        /// <summary>
        /// browse on the computer, let the user select his image/camping map
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = fDialog.FileName.ToString();
                tbMapPath.Text = filePath;
                string savePath = @"\\SERVER-S80\CampingMaps\";
                savePath += fDialog.SafeFileName;
                saveFilePath = savePath;
                oldFilePath = filePath;
            }
        }

        
    }
}
