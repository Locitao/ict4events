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
    /// This form is used if users only want to create an account, when a friend has already
    /// made a reservation for them.
    /// </summary>
    public partial class OnlyAcc : Form
    {
        readonly Select select = new Select();
        readonly Insert insert = new Insert();
        public OnlyAcc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Users click on this button, their account will be created for them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (tbAddress.Text == "" || tbCity.Text == "" || tbName.Text == "" || tbPhone.Text == "" ||
               tbPostal.Text == "" || tbReservePhone.Text == "" || tbAddress.TextLength < 6 || tbCity.TextLength < 4 || tbPhone.TextLength < 8 || tbPostal.TextLength < 4)
            {
                MessageBox.Show("You did not fill in all the required information!");
            }

            else 
            {
                try
                {
                    var reservation = select.Find_ReservationId(tbReservePhone.Text);
                    var name = tbName.Text;
                    var address = tbAddress.Text + ", " + tbCity.Text + ", " + tbCountry.Text;
                    var phone = tbPhone.Text;

                    MessageBox.Show(insert.Insert_Acc_Res(name, address, phone, reservation));

                    Hide();
                    Startup start = new Startup();
                    start.Closed += (s, args) => Close();
                    start.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void tbReservePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
