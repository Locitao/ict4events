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

namespace ReservationApp
{
    /// <summary>
    /// This form is used when a user wants to create a reservation. 
    /// </summary>
    public partial class ReservationForm : Form
    {
        readonly Connection connect = new Connection();
        readonly Select select = new Select();
        readonly Insert insert = new Insert();
        readonly Update update = new Update();

        private string name;
        private readonly string phone;
        private List<string> listlocations = new List<string>(); 
        
        public ReservationForm(string Name, string Phone)
        {
            InitializeComponent();
            Refresh();
            name = Name;
            phone = Phone;
            cbEvent.SelectedItem = "ICT4Events";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Refresh();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.CloseConnection();
        }
        /// <summary>
        /// Refresh is used to get a list of all locations that haven't been reserved yet, puts
        /// them in the listbox. It also shows for which events you can currently place a reservation.
        /// </summary>
        public override void Refresh()
        {
            lbLocations.Items.Clear();
            listlocations.Clear();
            nmLocId.Value = 0;

            try
            {
                var locations = select.Select_locations();

                foreach (Dictionary<string, object> row in locations)
                {
                    lbLocations.Items.Add("Location ID: "+row["LOCATION_ID"]+". Type: "+row["LOC_TYPE"]+". "+"Maximum amount of people: "+row["MAX_PEOPLE"]+". "+"Price: "+row["PRICE"]+".");
                    
                    Dictionary<string, string> locs = row.ToDictionary(k => k.Key,
                        k => k.Value == null ? "" : k.Value.ToString());
                    
                    
                }
                foreach (var s in locations)
                {
                    listlocations.Add(Convert.ToString(s["LOCATION_ID"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                var events = select.Select_Events();

                foreach (Dictionary<string, object> row in events)
                {
                    cbEvent.Items.Add(row["EVENT_NAME"]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// Button below creates a new reservation in the database.
        /// After which it opens the form to reserve materials.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateRes_Click(object sender, EventArgs e)
        {
            if (cbEvent.SelectedIndex == 1)
            {
                try
                {
                    var paid = "0";
                    if (cbPay.Checked)
                    {
                        paid = "1";
                    }

                    try
                    {
                        //if (cbEvent.SelectedText != "" && nmLocId.Text != "0")
                        //{

                        var rfid = select.Select_User(phone);
                        if (nmPeople.Text != "0" && CheckLocation(nmLocId.Text))
                        {


                            MessageBox.Show(insert.Insert_Reservation(rfid, "1", nmPeople.Text, paid));

                            var res = select.Find_Res_Id(rfid);
                            var loc = nmLocId.Text;

                            if (nmLoc2.Text != "0")
                            {
                                if (CheckLocation(nmLoc2.Text))
                                {
                                    update.Update_Location(nmLoc2.Text, res);
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "This location doesn't exist, or has been reserved already. Pick one from the list.");

                                }

                            }


                            if (nmLoc3.Text != "0")
                            {
                                if (CheckLocation(nmLoc3.Text))
                                {
                                    update.Update_Location(nmLoc3.Text, res);
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "This location doesn't exist, or has been reserved already. Pick one from the list.");

                                }
                            }


                            MessageBox.Show(update.Update_Location(loc, res));
                            connect.CloseConnection();

                            Hide();
                            ReserveMaterials reserve = new ReserveMaterials(rfid);
                            reserve.Closed += (s, args) => Close();
                            reserve.Show();

                        }

                        else
                        {
                            MessageBox.Show("Either you're trying to make a reservation for 0 people, or your location doesn't exist. Please check both.");
                        }

                    }
                    catch (Exception ex)
                    {
                        connect.CloseConnection();
                        MessageBox.Show(ex.Message);
                    }



                    Refresh();
                }
                catch (Exception ex)
                {
                    connect.CloseConnection();
                    MessageBox.Show(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Select an event!");
            }
            
       
                
            
            
        }

        /// <summary>
        /// Double mouse click on the map opens the map in the browser, so users can zoom.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbLocations_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowMap sm = new ShowMap();
            sm.Show();
        }

        private void lbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool CheckLocation(string s)
        {
            return listlocations.Any(x => s == x);
        }
    }
}
