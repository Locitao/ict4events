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
        /// <summary>
        /// Insert class, so we can insert the account into the database.
        /// </summary>
        readonly Insert insert = new Insert();
        public Create_Account()
        {
            InitializeComponent();
            
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This button creates a new account in the database, if certain conditions have been met.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text == "" || tbCity.Text == "" || tbName.Text == "" || tbPhone.Text == "" ||
               tbPostal.Text == "")
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
        /// <summary>
        /// Keypress events make sure that no unwanted text is entered in the textboxes.
        /// No letters in the phone number textbox, for example.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
