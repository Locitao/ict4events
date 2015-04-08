using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            try
            {
                var locations = select.Select_locations();

                foreach (Dictionary<string, object> row in locations)
                {
                    lbLocations.Items.Add("Type: "+row["LOC_TYPE"]+". "+"Maximum amount of people: "+row["MAX_PEOPLE"]+". "+"Price: "+row["PRICE"]+".");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
