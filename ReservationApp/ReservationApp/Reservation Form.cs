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
        
        public ReservationForm()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
