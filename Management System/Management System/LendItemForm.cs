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
        public LendItemForm(Material material)
        {

            InitializeComponent();
            saved = false;
            Mat = material;
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
