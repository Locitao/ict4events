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
    /// This form enables you to send a report.
    /// </summary>
    public partial class SendReport : Form
    {
        //Fields------------------------------------
        MediaSharingSystem medias;
        Protection protection = new Protection();

        Insert insert = new Insert();
        Connection connection = new Connection();

        //Properties--------------------------------
        public int MediaId { get; set; }
        public int CategoryId { get; set; }
        public int ReactionId { get; set; }
        public string WhatKindOfId { get; set; }

        //Constructor-------------------------------
        public SendReport(MediaSharingSystem medias, int Id, string whatKindOfId)
        {
            InitializeComponent();
            this.medias = medias;
            WhatKindOfId = whatKindOfId;

            if (whatKindOfId == "MediaItem")
            {
                MediaId = Id;
            }
            else if (whatKindOfId == "Category")
            {
                CategoryId = Id;
            }
            else if (whatKindOfId == "Reaction")
            {
                ReactionId = Id;
            }
        }

        //Events-------------------------------------

        //This event inserts a report into the database.
        private void btnSendReport_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text != "")
            {
                if (WhatKindOfId == "MediaItem")
                {
                    connection.SQLQueryNoOutput(insert.InsertReportMedia(MediaId, medias.RfidCode, "-" + protection.ProtectAgainstSQLInjection(tbDescription.Text)));
                }
                else if (WhatKindOfId == "Category")
                {
                    connection.SQLQueryNoOutput(insert.InsertReportCategory(CategoryId, medias.RfidCode, "-" + protection.ProtectAgainstSQLInjection(tbDescription.Text)));
                }
                else if (WhatKindOfId == "Reaction")
                {
                    connection.SQLQueryNoOutput(insert.InsertReportReaction(ReactionId, medias.RfidCode, "-" + protection.ProtectAgainstSQLInjection(tbDescription.Text)));
                }
            }
            else MessageBox.Show("Please enter a message!");

            this.Close();
        }

        //This event closes the form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
