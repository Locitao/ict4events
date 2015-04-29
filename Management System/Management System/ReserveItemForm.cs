using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Management_System
{
    public partial class ReserveItemForm : Form
    {
        public bool saved;
        public Material Mat;

        /// <summary>
        /// this form is used to reserve materials to a guest
        /// </summary>
        /// <param name="material">the material that is not yet lend or reserved</param>
        public ReserveItemForm(Material material)
        {

            InitializeComponent();
            saved = false;
            Mat = material;
            lblMaterialName.Text = material.Name;
            lblPrice.Text = material.Price.ToString();
            lblStatus.Text = material.Status.ToString();
        }

        /// <summary>
        /// Close this form
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Makes sure the user can only type letters and digits.
        /// </summary>
        private void tb_KeyPress_LettersAndDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Reserve the item that was selected, from and until the selected dates
        /// </summary>
        private void btnReserveItem_Click(object sender, EventArgs e)
        {
            if (dateTimePickerReturnDate.Value >= dateTimePickerLendDate.Value
                && dateTimePickerLendDate.Value >= DateTime.Now)
            {
                Mat.LendTime = dateTimePickerLendDate.Value;
                Mat.ReturnTime = dateTimePickerReturnDate.Value;
                Mat.RFID_CODE = tbRFIDCode.Text;
                saved = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Input wasnt correct. Please fill in correct info and try again.");
            }
        }
    }
}
