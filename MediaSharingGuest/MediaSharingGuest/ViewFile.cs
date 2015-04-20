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
        bool isLikedMedia = false;
        bool isLikedReaction = false;
        Reaction selectedReaction;
        Select select = new Select();
        Delete delete = new Delete();
        Insert insert = new Insert();
        Connection connection = new Connection();
        List<List<string>> output = new List<List<string>>();
        List<List<string>> output2 = new List<List<string>>();

        public int MediaId { get; set; }

        //CONSTRUCTOR-------------------------------------------------------------------------------------------------------------------------
        public ViewFile(MediaSharingSystem medias, int mediaId)
        {
            InitializeComponent();
            this.medias = medias;
            MediaId = mediaId;
            ShowStaticInformation();
            ShowDynamicInformation();
            btnReportComment.Enabled = false;
            btnLikeComment.Enabled = false;
        }

        //METHODS-----------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This method checks if the displayed media item is liked by the current user.
        /// </summary>
        /// <returns></returns>

        public bool IsReportedMedia()
        {
            return true;
        }

        public bool IsReportedComment()
        {
            return true;
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

        public bool LikedByUserMedia()
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

        public bool LikedByUserReaction()
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

        public bool ReportedByUserReaction()
        {
            foreach (Report report in selectedReaction.Reports)
            {
                if (report.RFIDCodeReporter == medias.RfidCode)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ReportedByUserMediaItem()
        {
            foreach (Report report in MediaItem[0].Reports)
            {
                if (report.RFIDCodeReporter == medias.RfidCode)
                {
                    return true;
                }
            }
            return false;
        }
        public void ShowDynamicInformation()
        {
            //This code updates the likes for the selected Media Item.
            MediaItem[0].Likes.Clear();

            connection.SQLQueryWithOutput(select.GetMediaLikes(MediaId), out output);
            {
                 foreach (List<string> stringList in output)
                 {
                     string likerRfidCode = stringList[0];
                     Like like = new Like(likerRfidCode, 0, MediaId);
                     MediaItem[0].Likes.Add(like);
                 }
                lblLikesNumber.Text = Convert.ToString(MediaItem[0].Likes.Count);

                if (LikedByUserMedia())
                {
                    btnLikeThisFile.Text = "Unlike this File!";
                    isLikedMedia = true;
                }
                else
                {
                    btnLikeThisFile.Text = "Like this File!";
                    isLikedMedia = false;
                }
            }

            //this code gets the report of the Media Item.
            connection.SQLQueryWithOutput(select.GetReportMediaItem(medias.RfidCode, MediaId), out output);
            {
                foreach (List<string> stringList in output)
                {
                    string reporterRfidCode = stringList[0];
                    int reportId = Convert.ToInt32(stringList[1]);
                    Report report = new Report(reportId, "", 0, MediaId, 0, reporterRfidCode);
                    MediaItem[0].Reports.Add(report);
                }
            }

            //This code gets all reactions for the selected Media Item.
            MediaItem[0].Reactions.Clear();
            lbComments.Items.Clear();
            connection.SQLQueryWithOutput(select.GetAllReactionsData(MediaId), out output);  
            foreach (List<string> stringList in output)
            {
                int reactionId = Convert.ToInt32(stringList[0]);
                string userName = stringList[1];
                string rfidCode = stringList[2];
                string content = stringList[3];

                Reaction reaction = new Reaction(content, MediaId, rfidCode);
                reaction.Name = userName;
                reaction.ReactionId = reactionId;
                MediaItem[0].Reactions.Add(reaction);

                //this code gets all the likes for the returned reactions.
                connection.SQLQueryWithOutput(select.GetReactionLikes(reactionId), out output2);
                foreach (List<string> stringList2 in output2)
                {
                    string likerRfidCode = stringList2[0];

                    Like like = new Like(likerRfidCode, reactionId, 0);
                    reaction.Likes.Add(like);
                }
                    reaction.UpdateAllInfoProperty();

                //this code gets gets the report of the user of the reactions.
                connection.SQLQueryWithOutput(select.GetReportComment(medias.RfidCode, reactionId), out output2);
                foreach (List<string> stringList2 in output2)
                {
                    string rfidCodeReporter = stringList2[0];
                    int reportId = Convert.ToInt32(stringList2[1]);

                    Report report = new Report(reportId, "", 0, 0, reactionId, rfidCodeReporter);
                    reaction.Reports.Add(report);
                }

                if (ReportedByUserMediaItem())
                {
                    btnReportFile.Enabled = false;
                }
                else btnReportFile.Enabled = true;

                    MediaItem[0].Reactions.Add(reaction);
                    lbComments.DisplayMember = "AllInfo";
                    lbComments.ValueMember = "ReactionId";
                    lbComments.Items.Add(reaction);
            }
        }

        //EVENTS-----------------------------------------------------------------------------------------------------------------------------

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            string content = tbYourComment.Text;
            connection.SQLQueryNoOutput(insert.InsertReaction(MediaId, medias.RfidCode, content));
            ShowDynamicInformation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLikeThisFile_Click(object sender, EventArgs e)
        {
            if (isLikedMedia == false)
            {
                connection.SQLQueryNoOutput(insert.InsertLikeMedia(MediaId, medias.RfidCode));
            }
            else
            {
                connection.SQLQueryNoOutput(delete.DeleteLikeMedia(MediaId));
            }
            ShowDynamicInformation();
        }

        private void btnReportFile_Click(object sender, EventArgs e)
        {
            SendReport sendreport = new SendReport(medias, MediaId, "MediaItem");

            DialogResult dialogresult = sendreport.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                ShowDynamicInformation();
            }
        }

        private void btnLikeComment_Click(object sender, EventArgs e)
        {
            if (isLikedReaction== false)
            {
                connection.SQLQueryNoOutput(insert.InsertLikeReaction(selectedReaction.ReactionId, medias.RfidCode));
            }
            else
            {
                connection.SQLQueryNoOutput(delete.DeleteLikeReaction(selectedReaction.ReactionId));
            }

            ShowDynamicInformation();
            lbComments.SelectedIndex = -1;
            selectedReaction = null;
            btnLikeComment.Enabled = false;
            btnReportComment.Enabled = false;
        }

        private void btnReportComment_Click(object sender, EventArgs e)
        {
            SendReport sendreport = new SendReport(medias, selectedReaction.ReactionId, "Reaction");
            DialogResult dialogresult = sendreport.ShowDialog();

            if (dialogresult == DialogResult.OK)
            {
                ShowDynamicInformation();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReaction = lbComments.SelectedItem as Reaction;

                if (selectedReaction != null)
                {
                    btnLikeComment.Enabled = true;
                    btnReportComment.Enabled = true;

                    if (LikedByUserReaction())
                    {
                        btnLikeComment.Text = "Unlike this comment!";
                        isLikedReaction = true;
                    }
                    else
                    {
                        btnLikeComment.Text = "Like this comment!";
                        isLikedReaction = false;
                    }

                    if (ReportedByUserReaction())
                    {
                        btnReportComment.Enabled = false;
                    }
                    else btnReportComment.Enabled = true;
                }
                else if (selectedReaction == null)
                {
                    btnLikeComment.Enabled = false;
                    btnReportComment.Enabled = false;
                }
            }


        }
    }
