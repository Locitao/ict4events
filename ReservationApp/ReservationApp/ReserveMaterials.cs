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
    public partial class ReserveMaterials : Form
    {
        Insert insert = new Insert();
        Select select = new Select();
        

        private string rfid;
        public ReserveMaterials()
        {
            InitializeComponent();

        }

        private void ReserveMaterials_Load(object sender, EventArgs e)
        {

        }
    }
}
