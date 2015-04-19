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
        public ReserveItemForm(Material material)
        {

            InitializeComponent();
            saved = false;
            Mat = material;
            lblMaterialName.Text = material.Name;
            lblPrice.Text = material.Price.ToString();
            lblStatus.Text = material.Status.ToString();
        }

        private void btnLendItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
