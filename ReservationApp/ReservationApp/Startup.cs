using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationApp
{
    /// <summary>
    /// This is the first form that shows when users start the application. They can either create an
    /// account, when one of their friends has already reserved, or they can create an account
    /// and a reservation at the same time.
    /// </summary>
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void btnOnlyAcc_Click(object sender, EventArgs e)
        {
            Hide();
            OnlyAcc createAccount = new OnlyAcc();
            createAccount.Closed += (s, args) => Close();
            createAccount.Show();
        }

        private void btnAccReserve_Click(object sender, EventArgs e)
        {
            Hide();
            Create_Account createAcc = new Create_Account();
            createAcc.Closed += (s, args) => Close();
            createAcc.Show();
        }
    }
}
