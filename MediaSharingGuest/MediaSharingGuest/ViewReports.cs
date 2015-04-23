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
    /// <summary>
    /// This Form gives an overview of all reports.
    /// </summary>
    public partial class ViewReports : Form
    {
        //Fields------------------------------------------------------
        List<List<string>> output = new List<List<string>>();
        List<Report> Reports = new List<Report>();
        List<Report> HotReports = new List<Report>();

        Connection connection = new Connection();
        Update update = new Update();
        Delete delete = new Delete();
        Select select = new Select();
        Protection protection = new Protection();

        Report selectedReport;

        int reportId = 0;
        int categoryId = 0;
        int mediaId = 0;
        int reactionId = 0;
        string rfidCode = "";
        string description = "";

        //Constructor--------------------------------------
        public ViewReports()
        {
            InitializeComponent();
            UpdateListBoxHotReports();
            UpdateListBoxReports();
            timerUpdate.Start();
        }

        //Methods------------------------------------------

        /// <summary>
        /// Updates the reports listbox
        /// </summary>
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

            foreach (Report report in Reports)
            {
                lbReports.ValueMember = "ReportId";
                lbReports.DisplayMember = "Content";
                lbReports.Items.Add(report);
            }

        }

        /// <summary>
        /// Updates the Hot report listbox.
        /// </summary>
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

            foreach (Report report in HotReports)
            {
                lbHotReports.ValueMember = "ReportId";
                lbHotReports.DisplayMember = "Content";
                lbHotReports.Items.Add(report);
            }

        }

        //Events--------------------------------------------

        /// <summary>
        /// Opens the reportdata form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReport = lbReports.SelectedItem as Report;

            if (selectedReport != null)
            {
                DialogResult dialogresult = new DialogResult();
                ReportData reportData = new ReportData(selectedReport);
                dialogresult = reportData.ShowDialog();

                if (dialogresult == DialogResult.OK)
                {
                    UpdateListBoxReports();
                    UpdateListBoxHotReports();
                }
            }
            lbHotReports.SelectedIndex = -1;
            lbReports.SelectedIndex = -1;
        }

        /// <summary>
        /// Opens the reportdata form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbHotReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReport = lbHotReports.SelectedItem as Report;

            if (selectedReport != null)
            {
                DialogResult dialogresult = new DialogResult();
                ReportData reportData = new ReportData(selectedReport);
                dialogresult = reportData.ShowDialog();

                if (dialogresult == DialogResult.OK)
                {
                    UpdateListBoxReports();
                    UpdateListBoxHotReports();
                } 
            }
            lbHotReports.SelectedIndex = -1;
            lbReports.SelectedIndex = -1;
        }

        /// <summary>
        /// Deletes all reports that are ''Hot'' and their respective media item or reaction.
        /// </summary>
        private void DeleteHotReportsAndTheirConnection()
        {
            foreach (Report report in HotReports)
            {
                if (report.MediaId != 0)
                {
                    connection.SQLQueryNoOutput(delete.DeleteMediaItem(report.MediaId));
                }
                else if (report.ReactionId != 0)
                {
                    connection.SQLQueryNoOutput(delete.DeleteReaction(report.ReactionId));
                }
                else if (report.CategoryId != 0)
                {
                    connection.SQLQueryNoOutput(update.EditCategoryName(report.CategoryId, "Category" + Convert.ToString(report.CategoryId)));
                }
                connection.SQLQueryNoOutput(delete.DeleteReportWithReportId(report.ReportId));
            }
        }
        /// <summary>
        /// Sets the threshold for when reports should be automatically deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudThreshold_ValueChanged(object sender, EventArgs e)
        {
            UpdateListBoxReports();
            UpdateListBoxHotReports();
        }

        /// <summary>
        /// Activates, or deactivates the AutoClean function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbAutoClean_CheckedChanged(object sender, EventArgs e)
        {
            DeleteHotReportsAndTheirConnection();
            UpdateListBoxHotReports();

            if (chbAutoClean.Checked == true)
            {
                timerDeleteReports.Start();
            }
            else timerDeleteReports.Stop();
        }

        /// <summary>
        /// Timer for autodelete function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDeleteReports_Tick(object sender, EventArgs e)
        {
            if (HotReports.Count > 0)
            {
                DeleteHotReportsAndTheirConnection();
            }
        }

        /// <summary>
        /// Update timer for both the report listboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateListBoxHotReports();
            UpdateListBoxReports();
        }

        /// <summary>
        /// closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Bans the user
        private void btnBan_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(update.BanUser(protection.ProtectAgainstSQLInjection(tbRfid.Text)));
        }

        private void btnUnban_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(update.UnbanUser(protection.ProtectAgainstSQLInjection(tbRfid.Text)));
        }   
    }
}
