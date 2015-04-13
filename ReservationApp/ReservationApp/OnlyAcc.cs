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
    public partial class OnlyAcc : Form
    {
        Select select = new Select();
        Insert insert = new Insert();
        public OnlyAcc()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (tbAddress.Text == null || tbCity.Text == null || tbName.Text == null || tbPhone.Text == null ||
               tbPostal.Text == null || tbReservePhone.Text == null)
            {
                MessageBox.Show("You did not fill in all the required information!");
            }

            else
            {
                string reservation = select.Find_ReservationId(tbReservePhone.Text);
                var name = tbName.Text;
                var address = tbAddress.Text + ", " + tbCity.Text + ", " + tbCountry.Text;

                MessageBox.Show(insert.Insert_Account(name, address, ))
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
