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

        public void Refresh()
        {
            tbAddress.Clear();
            tbCity.Clear();
            tbPhone.Clear();
            tbCountry.Clear();
            tbName.Clear();
            tbReservePhone.Clear();
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
                var reservation = select.Find_ReservationId(tbReservePhone.Text);
                var name = tbName.Text;
                var address = tbAddress.Text + ", " + tbCity.Text + ", " + tbCountry.Text;
                var phone = tbPhone.Text;

                MessageBox.Show(insert.Insert_Acc_Res(name, address, phone, reservation));
                Refresh();
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
