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
    /// This form shows the data from the selected report.
    /// </summary>
    public partial class ReportData : Form
    {
        //Fields--------------------------------
        Report report;
        string kindOfReport = "";
        string rfidCodeReporter = "";
        string rfidCodeCreator = "";

        List<List<string>> output = new List<List<string>>();
       
        Connection connection = new Connection();
        Protection protection = new Protection();
        Select select = new Select();
        Delete delete = new Delete();
        Update update = new Update();

        //Constructor----------------------------
        public ReportData(Report report)
        {
            InitializeComponent();
            this.report = report;
            ShowStaticInformation();
        }

        //Methods--------------------------------

        /// <summary>
        /// Shows all the static information like who filed the report, and the data of the report itself.
        /// </summary>
        public void ShowStaticInformation()
        {
            if (report.CategoryId != 0)
            {
                kindOfReport = "Category";
                btnDeleteMedia.Enabled = false;
                btnDeleteReaction.Enabled = false;
                tbCategory.Visible = true;
                tbText.Visible = true;

                connection.SQLQueryWithOutput(select.GetCategoryNameWithID(report.CategoryId), out output);
                tbText.Text = output[0][0];
            }
            else if (report.MediaId != 0)
            {
                kindOfReport = "Media";
                tbReportContent.Visible = false;
                btnEditCategoryName.Enabled = false;
                btnDeleteReaction.Enabled = false;

                connection.SQLQueryWithOutput(select.GetMediaPath(report.MediaId), out output);

                if (output == null)
                {
                    return;
                }

                pbMedia.ImageLocation = @output[0][0];
            }
            else if (report.ReactionId != 0)
            {
                kindOfReport = "Reaction";
                btnEditCategoryName.Enabled = false;
                btnDeleteMedia.Enabled = false;
                pbMedia.Visible = false;

                connection.SQLQueryWithOutput(select.GetReactionContent(report.ReactionId), out output);

                if (output == null)
                {
                    return;
                }

                tbText.Text = output[0][0];
            }

            tbReportContent.Text = report.Content;

            connection.SQLQueryWithOutput(select.GetReporter(report.ReportId), out output);

            if (output == null)
            {
                return;
            }
            
            foreach (List<string> stringList in output)
            {
                rfidCodeReporter = stringList[0];
                lblUsername.Text = stringList[1];
            }

            if (kindOfReport == "Reaction")
            {
                connection.SQLQueryWithOutput(select.GetNameWithReactionId(report.ReactionId), out output);
                lblUserNameCreator.Text = output[0][0];
                rfidCodeCreator = output[0][1];
            }
            else if (kindOfReport == "Media")
            {
                connection.SQLQueryWithOutput(select.GetNameWithMediaId(report.MediaId), out output);
                lblUserNameCreator.Text = output[0][0];
                rfidCodeCreator = output[0][1];
            }
            else if (kindOfReport == "Category")
            {
                connection.SQLQueryWithOutput(select.GetNameWithCategoryId(report.CategoryId), out output);
                lblUserNameCreator.Text = output[0][0];
                rfidCodeCreator = output[0][1];
            }

            lblTypeContent.Text = kindOfReport;
        }

        //button to delete reported reaction
        private void btnDeleteReaction_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(delete.DeleteReaction(report.ReactionId));
            MessageBox.Show("Reaction Deleted.");
            this.Close();
        }

        //button to delete reported media item
        private void btnDeleteMedia_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(delete.DeleteMediaItem(report.MediaId));
            MessageBox.Show("Media item Deleted.");
            this.Close();
        }

        //button to edit the category name
        private void btnEditCategoryName_Click(object sender, EventArgs e)
        {
            if (tbCategory.Text == "")
            {
                tbCategory.Text = "Default";
            }
            else
            {
                connection.SQLQueryNoOutput(update.EditCategoryName(report.CategoryId, protection.ProtectAgainstSQLInjection(tbCategory.Text)));
                connection.SQLQueryNoOutput(delete.DeleteReportsWithCategoryId(report.CategoryId));
                MessageBox.Show("Category name changed.");
                this.Close();
            }
        }

        //Closes the window.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBanReporter_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(update.BanUser(rfidCodeReporter));
        }

        private void btnBanCreator_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(update.BanUser(rfidCodeCreator));
        }
    }
}
