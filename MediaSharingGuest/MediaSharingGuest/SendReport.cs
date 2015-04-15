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

        Insert insert = new Insert();

        public SendReport(MediaSharingSystem medias, int mediaId, int categoryId, int reactionId)
        {
            InitializeComponent();
            this.medias = medias;
            MediaId = mediaId;
            CategoryId = categoryId;
            ReactionId = reactionId;
        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            if (MediaId != 0)
            {
                insert.InsertReport(CategoryId, MediaId, ReactionId, medias.RfidCode, tbDescription.Text);
            }
            else if (ReactionId != 0)
            {
                insert.InsertReport(CategoryId, MediaId, ReactionId, medias.RfidCode, tbDescription.Text);
            }
            else if (CategoryId!= 0)
            {

                insert.InsertReport(CategoryId, MediaId, ReactionId, medias.RfidCode, tbDescription.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
