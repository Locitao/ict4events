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
    /// This form will be used to create an account for users which also want to place a reservation immediately afterwards.
    /// </summary>
    public partial class Create_Account : Form
    {
        Insert insert = new Insert();
        public Create_Account()
        {
            InitializeComponent();
            
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text == null || tbCity.Text == null || tbName.Text == null || tbPhone.Text == null ||
               tbPostal.Text == null)
            {
                MessageBox.Show("You did not fill in all the required information!");
            }

            else
            {
                var name = tbName.Text;
                var phone = tbPhone.Text;
                var address = tbAddress.Text + ", " + tbCity.Text + ", " + tbCountry.Text;

                MessageBox.Show(insert.Insert_Account(name, address, phone));
                Hide();
                ReservationForm reserve = new ReservationForm(name, phone);
                reserve.Closed += (s, args) => Close();
                reserve.Show();

            }

            

        }

        private void Create_Account_Load(object sender, EventArgs e)
        {

        }
    }
}
