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
            if (WhatKindOfId == "MediaItem")
            {
                insert.InsertReportMedia(MediaId, medias.RfidCode, lblDescription.Text);
            }
            else if (WhatKindOfId == "Category")
            {
                insert.InsertReportCategory(MediaId, medias.RfidCode, lblDescription.Text);
            }
            else if (WhatKindOfId == "Reaction")
            {
                insert.InsertReportReaction(MediaId, medias.RfidCode, lblDescription.Text);
            }

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
