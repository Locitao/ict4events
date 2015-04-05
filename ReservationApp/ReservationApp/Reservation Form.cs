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
    public partial class Form1 : Form
    {
        private OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new OracleConnection();
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
            const string user = "dbi320839";
            const string pw = "ioMMVpigPp";

            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" +
                                    "//192.168.15.50:1521/fhictora" + ";";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            btnConnect.Enabled = false;
            MessageBox.Show("Connection succeeded!");
        }
    }
}
