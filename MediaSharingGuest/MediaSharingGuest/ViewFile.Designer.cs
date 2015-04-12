namespace MediaSharingGuest
{
    partial class ViewFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReportFile = new System.Windows.Forms.Button();
            this.btnReportComment = new System.Windows.Forms.Button();
            this.btnLikeComment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnLikeThisFile = new System.Windows.Forms.Button();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblYourComment = new System.Windows.Forms.Label();
            this.tbYourComment = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbComments = new System.Windows.Forms.ListBox();
            this.lblUploadedBy = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportFile
            // 
            this.btnReportFile.Location = new System.Drawing.Point(336, 715);
            this.btnReportFile.Name = "btnReportFile";
            this.btnReportFile.Size = new System.Drawing.Size(116, 40);
            this.btnReportFile.TabIndex = 27;
            this.btnReportFile.Text = "Report this file";
            this.btnReportFile.UseVisualStyleBackColor = true;
            // 
            // btnReportComment
            // 
            this.btnReportComment.Location = new System.Drawing.Point(662, 715);
            this.btnReportComment.Name = "btnReportComment";
            this.btnReportComment.Size = new System.Drawing.Size(146, 40);
            this.btnReportComment.TabIndex = 26;
            this.btnReportComment.Text = "Report selected comment";
            this.btnReportComment.UseVisualStyleBackColor = true;
            // 
            // btnLikeComment
            // 
            this.btnLikeComment.Location = new System.Drawing.Point(469, 715);
            this.btnLikeComment.Name = "btnLikeComment";
            this.btnLikeComment.Size = new System.Drawing.Size(146, 40);
            this.btnLikeComment.TabIndex = 25;
            this.btnLikeComment.Text = "Like selected comment!";
            this.btnLikeComment.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(134, 715);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(12, 715);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(116, 40);
            this.btnAddComment.TabIndex = 23;
            this.btnAddComment.Text = "Add Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnLikeThisFile
            // 
            this.btnLikeThisFile.Location = new System.Drawing.Point(377, 556);
            this.btnLikeThisFile.Name = "btnLikeThisFile";
            this.btnLikeThisFile.Size = new System.Drawing.Size(75, 52);
            this.btnLikeThisFile.TabIndex = 22;
            this.btnLikeThisFile.Text = "Like this file!";
            this.btnLikeThisFile.UseVisualStyleBackColor = true;
            this.btnLikeThisFile.Click += new System.EventHandler(this.btnLikeThisFile_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(12, 566);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(35, 13);
            this.lblLikes.TabIndex = 21;
            this.lblLikes.Text = "Likes:";
            // 
            // lblYourComment
            // 
            this.lblYourComment.AutoSize = true;
            this.lblYourComment.Location = new System.Drawing.Point(12, 598);
            this.lblYourComment.Name = "lblYourComment";
            this.lblYourComment.Size = new System.Drawing.Size(78, 13);
            this.lblYourComment.TabIndex = 20;
            this.lblYourComment.Text = "Your comment:";
            // 
            // tbYourComment
            // 
            this.tbYourComment.Location = new System.Drawing.Point(12, 614);
            this.tbYourComment.Multiline = true;
            this.tbYourComment.Name = "tbYourComment";
            this.tbYourComment.Size = new System.Drawing.Size(440, 95);
            this.tbYourComment.TabIndex = 19;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(466, 82);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(59, 13);
            this.lblComments.TabIndex = 18;
            this.lblComments.Text = "Comments:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 432);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(443, 122);
            this.tbDescription.TabIndex = 16;
            this.tbDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 96);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(443, 330);
            this.pbImage.TabIndex = 14;
            this.pbImage.TabStop = false;
            // 
            // lbComments
            // 
            this.lbComments.FormattingEnabled = true;
            this.lbComments.Location = new System.Drawing.Point(469, 98);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(339, 615);
            this.lbComments.TabIndex = 28;
            // 
            // lblUploadedBy
            // 
            this.lblUploadedBy.AutoSize = true;
            this.lblUploadedBy.Location = new System.Drawing.Point(4, 9);
            this.lblUploadedBy.Name = "lblUploadedBy";
            this.lblUploadedBy.Size = new System.Drawing.Size(70, 13);
            this.lblUploadedBy.TabIndex = 29;
            this.lblUploadedBy.Text = "Uploaded by:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
            // 
            // ViewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 778);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUploadedBy);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.btnReportFile);
            this.Controls.Add(this.btnReportComment);
            this.Controls.Add(this.btnLikeComment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.btnLikeThisFile);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblYourComment);
            this.Controls.Add(this.tbYourComment);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbImage);
            this.Name = "ViewFile";
            this.Text = "ViewFile";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportFile;
        private System.Windows.Forms.Button btnReportComment;
        private System.Windows.Forms.Button btnLikeComment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnLikeThisFile;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblYourComment;
        private System.Windows.Forms.TextBox tbYourComment;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ListBox lbComments;
        private System.Windows.Forms.Label lblUploadedBy;
        private System.Windows.Forms.Label lblName;
    }
}