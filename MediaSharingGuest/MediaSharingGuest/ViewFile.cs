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
        //FIELDS------------------------------------------------------------------------------------------------------------------------------
        MediaSharingSystem medias;
        Media[] MediaItem = new Media[1];
        Reaction selectedReaction;
        Select select = new Select();
        Delete delete = new Delete();
        Insert insert = new Insert();
        Connection connection = new Connection();
        List<List<string>> output = new List<List<string>>();
        List<List<string>> output2 = new List<List<string>>();

        public int MediaId { get; set; }
        public int SelectedReactionId { get; set; }
        public int SelectedCommentId { get; set; }

        //CONSTRUCTOR-------------------------------------------------------------------------------------------------------------------------
        public ViewFile(MediaSharingSystem medias, int mediaId)
        {
            InitializeComponent();
            this.medias = medias;
            MediaId = mediaId;
            ShowStaticInformation();
            ShowDynamicInformation();
        }

        //METHODS-----------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method checks if the displayed media item is liked by the current user.
        /// </summary>
        /// <returns></returns>
        public bool IsLikedMedia()
        {
            foreach (Like like in MediaItem[0].Likes)
            {
                if (like.RfidCode == medias.RfidCode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsReportedMedia()
        {
            return true;
        }

        public bool IsLikedComment()
        {
            if (selectedReaction != null)
            {
                foreach (Like like in selectedReaction.Likes)
                {
                    if (like.RfidCode == medias.RfidCode)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public bool IsReportedComment()
        {
            return true;
        }

        public void DeleteLike(int reactionId, int mediaId, string rfidCode)
        {
            //Query that deletes the users like.
            delete.DeleteLike(reactionId, mediaId, rfidCode);
        }

        public void ShowStaticInformation()
        {
            //Queries that get all the static information on the mediafile.
            connection.SQLQueryWithOutput(select.GetMediaItemInfo(MediaId), out output);

            foreach (List<string> stringList in output)
            {
                string mediaName = lblTitle.Text = stringList[0];
                string mediaLocation = lblLocation.Text = stringList[1];
                string mediaDescription = tbDescription.Text = stringList[2];
                string mediaPath = pbImage.ImageLocation = @stringList[3];
                lblName.Text = stringList[4];
                string rfidCreator = stringList[5];

                Media mediaItem = new Media(mediaName, mediaPath, mediaDescription, rfidCreator, mediaLocation, 0, MediaId);
                MediaItem[0] = mediaItem;
            }
        }

        public void ShowDynamicInformation()
        {
            List<Reaction> Reactions = new List<Reaction>();

            connection.SQLQueryWithOutput(select.GetMediaLikes(MediaId), out output);
            {
                 foreach (List<string> stringList in output)
                 {
                     string likerRfidCode = stringList[0];
                     Like like = new Like(likerRfidCode, 0, MediaId);
                     MediaItem[0].Likes.Add(like);
                 }
                lblLikesNumber.Text = Convert.ToString(MediaItem[0].Likes.Count);
            }

            connection.SQLQueryWithOutput(select.GetAllReactionsData(MediaId), out output);
            
            foreach (List<string> stringList in output)
            {
                int reactionId = Convert.ToInt32(stringList[0]);
                string userName = stringList[1];
                string rfidCode = stringList[2];
                string content = stringList[3];

                Reaction reaction = new Reaction(content, MediaId, rfidCode);
                reaction.Name = userName;

                connection.SQLQueryWithOutput(select.GetReactionLikes(reactionId), out output2);
                {
                    foreach (List<string> stringList2 in output2)
                    {
                        string likerRfidCode = stringList2[0];

                        Like like = new Like(likerRfidCode, reactionId, 0);
                        reaction.Likes.Add(like);
                        reaction.UpdateAllInfoProperty();
                    }
                }
                lbComments.DisplayMember = "AllInfo";
                lbComments.ValueMember = "MediaId";
                lbComments.Items.Add(reaction);
            }
        }

        //EVENTS-----------------------------------------------------------------------------------------------------------------------------

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            string content = tbYourComment.Text;
            Reaction comment = new Reaction(content, MediaId, medias.RfidCode);
            ShowDynamicInformation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLikeThisFile_Click(object sender, EventArgs e)
        {
            int removeIndex = 0;

            if (IsLikedMedia() == false)
            {
                Like like = new Like(medias.RfidCode, 0, MediaId);
                MediaItem[0].Likes.Add(like);

                insert.InsertLikeMedia(MediaId, medias.RfidCode);
            }
            else
            {
                for (int i = 0; i > MediaItem[0].Likes.Count; i++)
                {
                    if(MediaItem[0].Likes[1].RfidCode == medias.RfidCode)
                    {
                        removeIndex = i;
                    }
                }
                MediaItem[0].Likes.RemoveAt(removeIndex);
                DeleteLike(selectedReaction.ReactionId, MediaId, medias.RfidCode);
            }

            ShowDynamicInformation();
        }

        private void btnReportFile_Click(object sender, EventArgs e)
        {
            SendReport sendreport = new SendReport(medias, MediaId, "MediaItem");

            sendreport.Show();
        }

        private void btnLikeComment_Click(object sender, EventArgs e)
        {
            if (IsLikedComment() == false)
            {
            Reaction selectedReaction = lbComments.SelectedItem as Reaction;
            Like like = new Like(medias.RfidCode, selectedReaction.ReactionId, 0);
            }
            else
            {
                delete.DeleteLike(MediaId, selectedReaction.ReactionId, medias.RfidCode);
            }
            ShowDynamicInformation();
        }

        private void btnReportComment_Click(object sender, EventArgs e)
        {
            Reaction selectedReaction = lbComments.SelectedItem as Reaction;

            SendReport sendreport = new SendReport(medias, selectedReaction.ReactionId, "Reaction");
            sendreport.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbComments_SelectedIndexChanged(object sender, EventArgs e)
        {
                IsLikedComment();
                IsReportedComment();

                selectedReaction = lbComments.SelectedItem as Reaction;

                if (selectedReaction != null)
                {
                    btnLikeComment.Enabled = true;
                    btnReportComment.Enabled = true;
                }
            }
        }
    }
