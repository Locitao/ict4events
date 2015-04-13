﻿using System;
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