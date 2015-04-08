﻿using System;
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
    public partial class ReservationForm : Form
    {
        Connection connect = new Connection();
        Select select = new Select();
        Insert insert = new Insert();
        
        public ReservationForm()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void CreateAccount()
        {
            
        }

        private void Login()
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connect.NewConnection()
                ? "Connection with database succeeded."
                : "Check your settings, connection to database failed!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.CloseConnection();
        }

        private void Refresh()
        {
            lbLocations.Items.Clear();
            tbAddress.Clear();
            tbCity.Clear();
            tbName.Clear();
            tbPhone.Clear();
            tbPostal.Clear();
            nmLocId.Value = 0;

            try
            {
                var locations = select.Select_locations();

                foreach (Dictionary<string, object> row in locations)
                {
                    lbLocations.Items.Add("Location ID: "+row["LOCATION_ID"]+". Type: "+row["LOC_TYPE"]+". "+"Maximum amount of people: "+row["MAX_PEOPLE"]+". "+"Price: "+row["PRICE"]+".");
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
            /*
            try
            {
                var maxPeople = select.Select_Max_People(Convert.ToString(nmLocId));

                nmPeople.Maximum = Convert.ToInt32(maxPeople);
                nmPeople.Minimum = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            */
        }
        /// <summary>
        /// Button below creates a new reservation in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateRes_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text == null || tbCity.Text == null || tbName.Text == null || tbPhone.Text == null ||
                tbPostal.Text == null)
            {
                MessageBox.Show("You did not fill in all the required information!");
            }

            else
            {
                insert.Insert_Reservation("auto_inc_acc.nextval", "1", Convert.ToString(cbEvent.SelectedIndex + 2), Convert.ToString(nmPeople), "1");

                Refresh();
            }
            
        }

        private void nmLocId_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
