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
        string reportOf;

        public SendReport(MediaSharingSystem medias, Media mediaitem, string reportOf)
        {
            InitializeComponent();
            this.medias = medias;
            this.mediaitem = mediaitem;
            this.reportOf = reportOf;
        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            if (reportOf == "File")
            {
                Report report = new Report(tbDescription.Text, 0, mediaitem.MediaID, 0, medias.MediaUser.RFIDcode);
            }
            else if (reportOf == "Reaction")
            {

            }
            else if (reportOf == "Category")
            {

            }
        }
    }
}
