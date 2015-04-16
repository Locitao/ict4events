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
    public partial class EvenementManagementSystemForm : Form
    {
        private DatabaseConnection connection = new DatabaseConnection();
        private List<Camping> campingList = new List<Camping>();
        private List<Location> locationList = new List<Location>();

        public EvenementManagementSystemForm()
        {
            InitializeComponent();
            refreshCampingsData();
            refreshLocationsData();
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
        }

        private void refreshLocationsData()
        {
            locationList.Clear();
            lbLocations.Items.Clear();
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT LOCATION_ID, CAMPING_ID, RESERVATION_ID, LOC_TYPE, PRICE, MAX_PEOPLE FROM PT_EVENT_LOCATION", out output, out exception))
            {
                foreach (List<string> list in output)
                {
                    LocationType type;
                    Enum.TryParse(list[3], out type);
                    Location tempLocation = new Location(Convert.ToInt32(list[0]), Convert.ToInt32(list[1]), Convert.ToInt32(list[2])/*, type*/, Convert.ToInt32(list[4]), Convert.ToInt32(list[5]));
                    locationList.Add(tempLocation);
                    lbLocations.Items.Add(tempLocation);
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
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

        

        
    }
}
