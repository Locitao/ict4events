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
        Media mediaitem;
        Reaction reaction;
        Category category;
        

        public SendReport(MediaSharingSystem medias, Media mediaitem, Reaction reaction, Category category)
        {
            InitializeComponent();
            this.medias = medias;
            this.mediaitem = mediaitem;
            this.category = category;
            this.reaction = reaction;
        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            if (mediaitem != null)
            {
                Report report = new Report(tbDescription.Text, 0, mediaitem.MediaID, 0, medias.MediaUser.RFIDcode);
            }
            else if (reaction != null)
            {
                Report report = new Report(tbDescription.Text, 0, 0, reaction.ReactionID, medias.MediaUser.RFIDcode);
            }
            else if (category != null)
            {
                Report report = new Report(tbDescription.Text, category.CategoryId, 0, 0, medias.MediaUser.RFIDcode);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
