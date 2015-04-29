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
    public partial class LendItemForm : Form
    {
        public bool saved;
        public Material Mat;

        /// <summary>
        /// Gives a pop up where the user can put in data for the guest who lends the material
        /// </summary>
        /// <param name="material">the material that will be lend</param>
        public LendItemForm(Material material)
        {

            InitializeComponent();
            saved = false;
            Mat = material;
            lblMaterialName.Text = material.Name;
            lblPrice.Text = material.Price.ToString();
            lblStatus.Text = material.Status.ToString();
        }

        /// <summary>
        /// Change the item status in the database to lent
        /// </summary>
        private void btnLendItem_Click(object sender, EventArgs e)
        {
            if (dateTimePickerReturnDate.Value > DateTime.Now)
            {
                Mat.LendTime = DateTime.Now;
                Mat.ReturnTime = dateTimePickerReturnDate.Value;
                Mat.RFID_CODE = tbRFIDCode.Text;
            }
            saved = true;
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
        /// closes this form
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
