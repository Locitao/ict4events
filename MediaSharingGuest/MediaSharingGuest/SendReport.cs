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
    public partial class SendReport : Form
    {
        MediaSharingSystem medias;

        public int MediaId { get; set; }
        public int CategoryId { get; set; }
        public int ReactionId { get; set; }
        public string WhatKindOfId { get; set; }

        Insert insert = new Insert();
        Connection connection = new Connection();

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

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text != "")
            {
                if (WhatKindOfId == "MediaItem")
                {
                    connection.SQLQueryNoOutput(insert.InsertReportMedia(MediaId, medias.RfidCode, "-" + tbDescription.Text));
                }
                else if (WhatKindOfId == "Category")
                {
                    connection.SQLQueryNoOutput(insert.InsertReportCategory(CategoryId, medias.RfidCode, "-" + tbDescription.Text));
                }
                else if (WhatKindOfId == "Reaction")
                {
                    connection.SQLQueryNoOutput(insert.InsertReportReaction(ReactionId, medias.RfidCode, "-" + tbDescription.Text));
                }
            }
            else MessageBox.Show("Please enter a message!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendReport_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
