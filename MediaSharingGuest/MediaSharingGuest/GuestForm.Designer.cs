namespace MediaSharingGuest
{
    partial class GuestForm
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timerNewsFeed = new System.Windows.Forms.Timer(this.components);
            this.gbNewsfeed = new System.Windows.Forms.GroupBox();
            this.lblNewsMessage = new System.Windows.Forms.Label();
            this.tbNewsFeed = new System.Windows.Forms.TextBox();
            this.lblNewsFeedMessage = new System.Windows.Forms.Label();
            this.btnAddNewsFeedMessage = new System.Windows.Forms.Button();
            this.lbFolders = new System.Windows.Forms.ListBox();
            this.lblParentFolder = new System.Windows.Forms.Label();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.gbFolders = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnReportCategory = new System.Windows.Forms.Button();
            this.lbMediaItems = new System.Windows.Forms.ListBox();
            this.gbNewsfeed.SuspendLayout();
            this.gbFiles.SuspendLayout();
            this.gbFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // timerNewsFeed
            // 
            this.timerNewsFeed.Interval = 1000;
            this.timerNewsFeed.Tick += new System.EventHandler(this.timerNewsFeed_Tick);
            // 
            // gbNewsfeed
            // 
            this.gbNewsfeed.Controls.Add(this.lblNewsMessage);
            this.gbNewsfeed.Location = new System.Drawing.Point(121, 12);
            this.gbNewsfeed.Name = "gbNewsfeed";
            this.gbNewsfeed.Size = new System.Drawing.Size(948, 135);
            this.gbNewsfeed.TabIndex = 1;
            this.gbNewsfeed.TabStop = false;
            this.gbNewsfeed.Text = "Newsfeed";
            // 
            // lblNewsMessage
            // 
            this.lblNewsMessage.AutoSize = true;
            this.lblNewsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsMessage.Location = new System.Drawing.Point(235, 49);
            this.lblNewsMessage.Name = "lblNewsMessage";
            this.lblNewsMessage.Size = new System.Drawing.Size(442, 42);
            this.lblNewsMessage.TabIndex = 0;
            this.lblNewsMessage.Text = "Jan: Newsfeed bericht!!!";
            // 
            // tbNewsFeed
            // 
            this.tbNewsFeed.Location = new System.Drawing.Point(227, 163);
            this.tbNewsFeed.Name = "tbNewsFeed";
            this.tbNewsFeed.Size = new System.Drawing.Size(744, 20);
            this.tbNewsFeed.TabIndex = 2;
            // 
            // lblNewsFeedMessage
            // 
            this.lblNewsFeedMessage.AutoSize = true;
            this.lblNewsFeedMessage.Location = new System.Drawing.Point(118, 166);
            this.lblNewsFeedMessage.Name = "lblNewsFeedMessage";
            this.lblNewsFeedMessage.Size = new System.Drawing.Size(103, 13);
            this.lblNewsFeedMessage.TabIndex = 1;
            this.lblNewsFeedMessage.Text = "Newsfeed message:";
            // 
            // btnAddNewsFeedMessage
            // 
            this.btnAddNewsFeedMessage.Location = new System.Drawing.Point(977, 160);
            this.btnAddNewsFeedMessage.Name = "btnAddNewsFeedMessage";
            this.btnAddNewsFeedMessage.Size = new System.Drawing.Size(92, 23);
            this.btnAddNewsFeedMessage.TabIndex = 3;
            this.btnAddNewsFeedMessage.Text = "Add Message";
            this.btnAddNewsFeedMessage.UseVisualStyleBackColor = true;
            this.btnAddNewsFeedMessage.Click += new System.EventHandler(this.btnAddNewsFeedMessage_Click);
            // 
            // lbFolders
            // 
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.Location = new System.Drawing.Point(9, 48);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(257, 407);
            this.lbFolders.TabIndex = 4;
            this.lbFolders.SelectedIndexChanged += new System.EventHandler(this.lbFolders_SelectedIndexChanged);
            // 
            // lblParentFolder
            // 
            this.lblParentFolder.AutoSize = true;
            this.lblParentFolder.Location = new System.Drawing.Point(6, 27);
            this.lblParentFolder.Name = "lblParentFolder";
            this.lblParentFolder.Size = new System.Drawing.Size(64, 13);
            this.lblParentFolder.TabIndex = 5;
            this.lblParentFolder.Text = "Parentfolder";
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.lbMediaItems);
            this.gbFiles.Location = new System.Drawing.Point(435, 193);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(634, 509);
            this.gbFiles.TabIndex = 6;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(9, 461);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(127, 37);
            this.btnAddFolder.TabIndex = 7;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(142, 461);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(124, 37);
            this.btnAddFile.TabIndex = 8;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click_1);
            // 
            // gbFolders
            // 
            this.gbFolders.Controls.Add(this.btnBack);
            this.gbFolders.Controls.Add(this.lblParentFolder);
            this.gbFolders.Controls.Add(this.btnAddFile);
            this.gbFolders.Controls.Add(this.lbFolders);
            this.gbFolders.Controls.Add(this.btnAddFolder);
            this.gbFolders.Location = new System.Drawing.Point(121, 193);
            this.gbFolders.Name = "gbFolders";
            this.gbFolders.Size = new System.Drawing.Size(297, 509);
            this.gbFolders.TabIndex = 9;
            this.gbFolders.TabStop = false;
            this.gbFolders.Text = "Folders";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(191, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1087, 679);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(125, 23);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Location = new System.Drawing.Point(1075, 22);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(71, 13);
            this.lblLoggedInAs.TabIndex = 11;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1075, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // btnReportCategory
            // 
            this.btnReportCategory.Location = new System.Drawing.Point(1087, 654);
            this.btnReportCategory.Name = "btnReportCategory";
            this.btnReportCategory.Size = new System.Drawing.Size(125, 23);
            this.btnReportCategory.TabIndex = 13;
            this.btnReportCategory.Text = "Report Category";
            this.btnReportCategory.UseVisualStyleBackColor = true;
            // 
            // lbMediaItems
            // 
            this.lbMediaItems.FormattingEnabled = true;
            this.lbMediaItems.Location = new System.Drawing.Point(6, 48);
            this.lbMediaItems.Name = "lbMediaItems";
            this.lbMediaItems.Size = new System.Drawing.Size(622, 407);
            this.lbMediaItems.TabIndex = 10;
            this.lbMediaItems.SelectedIndexChanged += new System.EventHandler(this.lbMediaItems_SelectedIndexChanged);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 806);
            this.Controls.Add(this.btnReportCategory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.gbFolders);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.btnAddNewsFeedMessage);
            this.Controls.Add(this.lblNewsFeedMessage);
            this.Controls.Add(this.tbNewsFeed);
            this.Controls.Add(this.gbNewsfeed);
            this.Controls.Add(this.btnConnect);
            this.Name = "GuestForm";
            this.Text = "Mediasharing";
            this.gbNewsfeed.ResumeLayout(false);
            this.gbNewsfeed.PerformLayout();
            this.gbFiles.ResumeLayout(false);
            this.gbFolders.ResumeLayout(false);
            this.gbFolders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timerNewsFeed;
        private System.Windows.Forms.GroupBox gbNewsfeed;
        private System.Windows.Forms.Label lblNewsMessage;
        private System.Windows.Forms.TextBox tbNewsFeed;
        private System.Windows.Forms.Label lblNewsFeedMessage;
        private System.Windows.Forms.Button btnAddNewsFeedMessage;
        private System.Windows.Forms.ListBox lbFolders;
        private System.Windows.Forms.Label lblParentFolder;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.GroupBox gbFolders;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReportCategory;
        private System.Windows.Forms.ListBox lbMediaItems;
    }
}

