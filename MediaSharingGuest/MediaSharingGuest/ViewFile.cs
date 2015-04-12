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
            //Shows the image
            pbImage.ImageLocation = @mediaitem.Path;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Shows the comments
            mediaitem.Update();
            
            foreach (Reaction comment in mediaitem.Comments)
            {
                lbComments.Items.Add(comment);
            }

            //shows the name of the uploader

            //SELECT statement to select the name of the creator.
            string rfidCreator = mediaitem.RfidCreator;
            string creator;

            lblName.Text = "";
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLikeThisFile_Click(object sender, EventArgs e)
        {
            object selectedobject = lbComments.SelectedItem;
            Reaction selectedReaction = selectedobject as Reaction;
            Like like = new Like(medias.MediaUser.RFIDcode, 0, mediaitem.MediaID);
        }
    }
}
