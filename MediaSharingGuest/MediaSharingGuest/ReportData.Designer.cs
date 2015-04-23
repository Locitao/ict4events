namespace MediaSharingGuest
{
    partial class ReportData
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
            this.tbReportContent = new System.Windows.Forms.TextBox();
            this.lblReporter = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.pbMedia = new System.Windows.Forms.PictureBox();
            this.lblTypeContent = new System.Windows.Forms.Label();
            this.btnDeleteReaction = new System.Windows.Forms.Button();
            this.btnDeleteMedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEditCategoryName = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUserNameCreator = new System.Windows.Forms.Label();
            this.lblContentCreator = new System.Windows.Forms.Label();
            this.btnBanReporter = new System.Windows.Forms.Button();
            this.gbReporterData = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedia)).BeginInit();
            this.gbReporterData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbReportContent
            // 
            this.tbReportContent.Location = new System.Drawing.Point(9, 38);
            this.tbReportContent.Multiline = true;
            this.tbReportContent.Name = "tbReportContent";
            this.tbReportContent.Size = new System.Drawing.Size(298, 164);
            this.tbReportContent.TabIndex = 0;
            // 
            // lblReporter
            // 
            this.lblReporter.AutoSize = true;
            this.lblReporter.Location = new System.Drawing.Point(6, 18);
            this.lblReporter.Name = "lblReporter";
            this.lblReporter.Size = new System.Drawing.Size(68, 17);
            this.lblReporter.TabIndex = 1;
            this.lblReporter.Text = "Reporter:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(80, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.pbMedia);
            this.gbData.Controls.Add(this.lblTypeContent);
            this.gbData.Controls.Add(this.btnDeleteReaction);
            this.gbData.Controls.Add(this.btnDeleteMedia);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.textBox1);
            this.gbData.Controls.Add(this.btnEditCategoryName);
            this.gbData.Controls.Add(this.button1);
            this.gbData.Controls.Add(this.lblUserNameCreator);
            this.gbData.Controls.Add(this.lblContentCreator);
            this.gbData.Location = new System.Drawing.Point(415, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(460, 267);
            this.gbData.TabIndex = 3;
            this.gbData.TabStop = false;
            this.gbData.Text = "Reported Item Data";
            // 
            // pbMedia
            // 
            this.pbMedia.Location = new System.Drawing.Point(20, 66);
            this.pbMedia.Name = "pbMedia";
            this.pbMedia.Size = new System.Drawing.Size(196, 136);
            this.pbMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMedia.TabIndex = 11;
            this.pbMedia.TabStop = false;
            // 
            // lblTypeContent
            // 
            this.lblTypeContent.AutoSize = true;
            this.lblTypeContent.Location = new System.Drawing.Point(82, 46);
            this.lblTypeContent.Name = "lblTypeContent";
            this.lblTypeContent.Size = new System.Drawing.Size(103, 17);
            this.lblTypeContent.TabIndex = 10;
            this.lblTypeContent.Text = "Type of Report";
            // 
            // btnDeleteReaction
            // 
            this.btnDeleteReaction.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteReaction.Location = new System.Drawing.Point(222, 142);
            this.btnDeleteReaction.Name = "btnDeleteReaction";
            this.btnDeleteReaction.Size = new System.Drawing.Size(144, 32);
            this.btnDeleteReaction.TabIndex = 9;
            this.btnDeleteReaction.Text = "Delete Reaction";
            this.btnDeleteReaction.UseVisualStyleBackColor = true;
            this.btnDeleteReaction.Click += new System.EventHandler(this.btnDeleteReaction_Click);
            // 
            // btnDeleteMedia
            // 
            this.btnDeleteMedia.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeleteMedia.Location = new System.Drawing.Point(222, 104);
            this.btnDeleteMedia.Name = "btnDeleteMedia";
            this.btnDeleteMedia.Size = new System.Drawing.Size(144, 32);
            this.btnDeleteMedia.TabIndex = 8;
            this.btnDeleteMedia.Text = "Delete Media";
            this.btnDeleteMedia.UseVisualStyleBackColor = true;
            this.btnDeleteMedia.Click += new System.EventHandler(this.btnDeleteMedia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Content:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 136);
            this.textBox1.TabIndex = 6;
            // 
            // btnEditCategoryName
            // 
            this.btnEditCategoryName.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditCategoryName.Location = new System.Drawing.Point(222, 66);
            this.btnEditCategoryName.Name = "btnEditCategoryName";
            this.btnEditCategoryName.Size = new System.Drawing.Size(144, 32);
            this.btnEditCategoryName.TabIndex = 5;
            this.btnEditCategoryName.Text = "Edit Category Name";
            this.btnEditCategoryName.UseVisualStyleBackColor = true;
            this.btnEditCategoryName.Click += new System.EventHandler(this.btnEditCategoryName_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ban Creator";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblUserNameCreator
            // 
            this.lblUserNameCreator.AutoSize = true;
            this.lblUserNameCreator.Location = new System.Drawing.Point(82, 29);
            this.lblUserNameCreator.Name = "lblUserNameCreator";
            this.lblUserNameCreator.Size = new System.Drawing.Size(73, 17);
            this.lblUserNameCreator.TabIndex = 1;
            this.lblUserNameCreator.Text = "Username";
            // 
            // lblContentCreator
            // 
            this.lblContentCreator.AutoSize = true;
            this.lblContentCreator.Location = new System.Drawing.Point(17, 29);
            this.lblContentCreator.Name = "lblContentCreator";
            this.lblContentCreator.Size = new System.Drawing.Size(59, 17);
            this.lblContentCreator.TabIndex = 0;
            this.lblContentCreator.Text = "Creator:";
            // 
            // btnBanReporter
            // 
            this.btnBanReporter.Location = new System.Drawing.Point(9, 214);
            this.btnBanReporter.Name = "btnBanReporter";
            this.btnBanReporter.Size = new System.Drawing.Size(144, 32);
            this.btnBanReporter.TabIndex = 2;
            this.btnBanReporter.Text = "Ban Reporter";
            this.btnBanReporter.UseVisualStyleBackColor = true;
            // 
            // gbReporterData
            // 
            this.gbReporterData.Controls.Add(this.btnCancel);
            this.gbReporterData.Controls.Add(this.lblReporter);
            this.gbReporterData.Controls.Add(this.btnBanReporter);
            this.gbReporterData.Controls.Add(this.tbReportContent);
            this.gbReporterData.Controls.Add(this.lblUsername);
            this.gbReporterData.Location = new System.Drawing.Point(11, 12);
            this.gbReporterData.Name = "gbReporterData";
            this.gbReporterData.Size = new System.Drawing.Size(398, 267);
            this.gbReporterData.TabIndex = 4;
            this.gbReporterData.TabStop = false;
            this.gbReporterData.Text = "Reporter Data";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 288);
            this.Controls.Add(this.gbReporterData);
            this.Controls.Add(this.gbData);
            this.Name = "ReportData";
            this.Text = "ReportData";
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedia)).EndInit();
            this.gbReporterData.ResumeLayout(false);
            this.gbReporterData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbReportContent;
        private System.Windows.Forms.Label lblReporter;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lblTypeContent;
        private System.Windows.Forms.Button btnDeleteReaction;
        private System.Windows.Forms.Button btnDeleteMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEditCategoryName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUserNameCreator;
        private System.Windows.Forms.Label lblContentCreator;
        private System.Windows.Forms.Button btnBanReporter;
        private System.Windows.Forms.GroupBox gbReporterData;
        private System.Windows.Forms.PictureBox pbMedia;
        private System.Windows.Forms.Button btnCancel;
    }
}