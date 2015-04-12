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
    public partial class ViewFile : Form
    {
        MediaSharingSystem medias;
        Media mediaitem;

        public ViewFile(MediaSharingSystem medias, Media mediaitem)
        {
            InitializeComponent();
            this.medias = medias;
            this.mediaitem = mediaitem;
        }

        public void ShowAllInformation()
        {
            //Shows the image.
            pbImage.ImageLocation = @mediaitem.Path;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Shows the comments.
            mediaitem.Update();
            
            foreach (Reaction comment in mediaitem.Comments)
            {
                lbComments.Items.Add(comment);
            }

            //shows the name of the uploader.

            //SELECT statement to select the name of the creator.
            string rfidCreator = mediaitem.RfidCreator;
            string creator;

            lblName.Text = "";

            //Shows the desciption.
            tbDescription.Text = mediaitem.Description;

            //Shows the Location where the image was taken.
            lblLocation.Text = mediaitem.Location;
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            string content = tbYourComment.Text;
            Reaction comment = new Reaction(content, mediaitem.MediaID);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLikeThisFile_Click(object sender, EventArgs e)
        {
            Like like = new Like(medias.MediaUser.RFIDcode, 0, mediaitem.MediaID);
        }

        private void btnReportFile_Click(object sender, EventArgs e)
        {
            SendReport sendreport = new SendReport(medias, mediaitem, null, null);
            sendreport.Show();
        }

        private void btnLikeComment_Click(object sender, EventArgs e)
        {
            object selectedobject = lbComments.SelectedItem;
            Reaction selectedReaction = selectedobject as Reaction;
            Like like = new Like(medias.MediaUser.RFIDcode, selectedReaction.ReactionID, 0);
        }

        private void btnReportComment_Click(object sender, EventArgs e)
        {
            object selectedobject = lbComments.SelectedItem;
            Reaction selectedReaction = selectedobject as Reaction;
            SendReport sendreport = new SendReport(medias, null, selectedReaction, null);
            sendreport.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
