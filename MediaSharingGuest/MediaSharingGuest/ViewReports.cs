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
            UpdateListBoxReports();
        }

        List<Report> Reports = new List<Report>();
        List<Report> HotReports = new List<Report>();
        Connection connection = new Connection();
        List<List<string>> output = new List<List<string>>();
        Select select = new Select();
        Report selectedReport;

        int reportId = 0;
        int categoryId = 0;
        int mediaId = 0;
        int reactionId = 0;
        string rfidCode = "";
        string description = "";
        string kindOfReport = "";

        private void lbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReport = lbReports.SelectedItem as Report;

            if (selectedReport != null)
            {
                ReportData reportData = new ReportData(selectedReport);
                reportData.Show();
            }

            lbReports.SelectedIndex = -1;
        }

        public void UpdateListBoxReports()
        {
            Reports.Clear();
            lbReports.Items.Clear();

            connection.SQLQueryWithOutput(select.GetAllReportsUnderThreshHold(Convert.ToInt32(nudThreshold.Value)), out output);

            foreach (List<string> stringList in output)
            {
                reportId = Convert.ToInt32(stringList[0]);

                if (stringList[1] == "")
                {
                    categoryId = 0;
                }
                else categoryId = Convert.ToInt32(stringList[1]);

                if (stringList[2] == "")
                {
                    mediaId = 0;
                }
                else mediaId = Convert.ToInt32(stringList[2]);

                if (stringList[3] == "")
                {
                    reactionId = 0;
                }
                else reactionId = Convert.ToInt32(stringList[3]);

                rfidCode = stringList[4];
                description = stringList[5];

                Report report = new Report(reportId, description, categoryId, mediaId, reactionId, rfidCode);

                Reports.Add(report);
            }

            foreach (Report reportt in Reports)
            {
                lbReports.ValueMember = "ReportId";
                lbReports.DisplayMember = "Content";
                lbReports.Items.Add(reportt);
            }

        }

        public void UpdateListBoxHotReports()
        {
            HotReports.Clear();
            lbHotReports.Items.Clear();

            connection.SQLQueryWithOutput(select.GetAllReportsAboveThreshHold(Convert.ToInt32(nudThreshold.Value)), out output);

            foreach (List<string> stringList in output)
            {
                reportId = Convert.ToInt32(stringList[0]);

                if (stringList[1] == "")
                {
                    categoryId = 0;
                }
                else categoryId = Convert.ToInt32(stringList[1]);

                if (stringList[2] == "")
                {
                    mediaId = 0;
                }
                else mediaId = Convert.ToInt32(stringList[2]);

                if (stringList[3] == "")
                {
                    reactionId = 0;
                }
                else reactionId = Convert.ToInt32(stringList[3]);

                rfidCode = stringList[4];
                description = stringList[5];

                Report report = new Report(reportId, description, categoryId, mediaId, reactionId, rfidCode);

                HotReports.Add(report);
            }

            foreach (Report reportt in HotReports)
            {
                lbReports.ValueMember = "ReportId";
                lbReports.DisplayMember = "Content";
                lbHotReports.Items.Add(reportt);
            }
        }

        private void lbHotReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudThreshold_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chbAutoClean_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAutoClean.Checked == true)
            {
                timerDeleteReports.Start();
            }
            else timerDeleteReports.Stop();
        }

        private void timerDeleteReports_Tick(object sender, EventArgs e)
        {
            foreach (Report report in HotReports)
            {
                
            }
        }

        
    }
}
