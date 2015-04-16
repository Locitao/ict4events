using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSharingGuest
{
    public partial class ViewReports : Form
    {
        public ViewReports()
        {
            InitializeComponent();
        }

        List<Report> Reports = new List<Report>();
        Connection connection = new Connection();
        Select select = new Select();

        private void lbReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void UpdateListBox()
        {
            List<List<string>> output = new List<List<string>>();
            List<Report> Reports = new List<Report>();

            connection.SQLQueryWithOutput(select.GetReports(), out output);

            foreach (List<string> stringList in output)
            {
                int reportId = Convert.ToInt32(stringList[0]);
                int categoryId = Convert.ToInt32(stringList[1]);
                int mediaId = Convert.ToInt32(stringList[2]);
                int reactionId = Convert.ToInt32(stringList[3]);
                string rfidCode = stringList[4];
                string description = stringList[5];
                int handled = Convert.ToInt32(stringList[6]);

                Report report = new Report(description, categoryId, mediaId, reactionId, rfidCode);

                foreach (Report reportt in Reports)
                {
                    lbReports.Items.Add(reportt);
                    lbReports.ValueMember = Convert.ToString(reportt.ReportId);
                    lbReports.DisplayMember = reportt.Content;
                }
            }

        }

        
    }
}
