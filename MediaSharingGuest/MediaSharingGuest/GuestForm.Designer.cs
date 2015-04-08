﻿namespace MediaSharingGuest
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNewsFeedMessage = new System.Windows.Forms.Label();
            this.btnAddNewsFeedMessage = new System.Windows.Forms.Button();
            this.lbFolders = new System.Windows.Forms.ListBox();
            this.lblParentFolder = new System.Windows.Forms.Label();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.gbFolders = new System.Windows.Forms.GroupBox();
            this.gbNewsfeed.SuspendLayout();
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
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbNewsfeed
            // 
            this.gbNewsfeed.Controls.Add(this.label1);
            this.gbNewsfeed.Location = new System.Drawing.Point(121, 12);
            this.gbNewsfeed.Name = "gbNewsfeed";
            this.gbNewsfeed.Size = new System.Drawing.Size(948, 135);
            this.gbNewsfeed.TabIndex = 1;
            this.gbNewsfeed.TabStop = false;
            this.gbNewsfeed.Text = "Newsfeed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jan: Newsfeed bericht!!!";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(744, 20);
            this.textBox1.TabIndex = 2;
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
            // 
            // lbFolders
            // 
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.Location = new System.Drawing.Point(9, 48);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(257, 407);
            this.lbFolders.TabIndex = 4;
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
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(142, 461);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(124, 37);
            this.btnAddFile.TabIndex = 8;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            // 
            // gbFolders
            // 
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
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 806);
            this.Controls.Add(this.gbFolders);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.btnAddNewsFeedMessage);
            this.Controls.Add(this.lblNewsFeedMessage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbNewsfeed);
            this.Controls.Add(this.btnConnect);
            this.Name = "GuestForm";
            this.Text = "Mediasharing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GuestForm_FormClosing);
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.gbNewsfeed.ResumeLayout(false);
            this.gbNewsfeed.PerformLayout();
            this.gbFolders.ResumeLayout(false);
            this.gbFolders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timerNewsFeed;
        private System.Windows.Forms.GroupBox gbNewsfeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNewsFeedMessage;
        private System.Windows.Forms.Button btnAddNewsFeedMessage;
        private System.Windows.Forms.ListBox lbFolders;
        private System.Windows.Forms.Label lblParentFolder;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.GroupBox gbFolders;
    }
}

