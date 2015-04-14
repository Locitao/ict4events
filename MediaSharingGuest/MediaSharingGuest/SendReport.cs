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
                Report report = new Report(tbDescription.Text, 0, MediaId, 0, medias.RfidCode);
            }
            else if (ReactionId != 0)
            {
                Report report = new Report(tbDescription.Text, 0, 0, ReactionId, medias.RfidCode);
            }
            else if (CategoryId!= 0)
            {
                Report report = new Report(tbDescription.Text, CategoryId, 0, 0, medias.RfidCode);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
