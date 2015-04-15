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
    public partial class EvenementManagementSystemForm : Form
    {
        private DatabaseConnection connection = new DatabaseConnection();
        private List<Camping> campingList = new List<Camping>();

        public EvenementManagementSystemForm()
        {
            InitializeComponent();
            getCampingsData();
        }

        private void getCampingsData()
        {
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT CAMPING_ID, CAMPING_NAME, CAMPING_MAP FROM PT_CAMPING", out output, out exception))
            {
                MessageBox.Show(output.Count.ToString());
                foreach(List<string> list in output)
                {
                    Camping tempCamping = new Camping(Convert.ToInt32(list[0]), list[1], list[2]);
                    campingList.Add(tempCamping);
                    lbCampings.Items.Add(tempCamping);
                    MessageBox.Show(list[0] + list[1] + list[2]);
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            
            
        }

        

        private void lbCampings_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNewCamping_Click(object sender, EventArgs e)
        {
            //string query = "Insert into PT_CAMPING(camping_ID, camping_name, camping_map) VALUES(auto_inc_cam.nextval, 'camping name', 'imgur link')";

        }

        

        
    }
}
