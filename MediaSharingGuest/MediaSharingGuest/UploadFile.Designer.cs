namespace MediaSharingGuest
{
    partial class UploadFile
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
            this.tbTitel = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.tbDesciption = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTitel
            // 
            this.tbTitel.Location = new System.Drawing.Point(259, 23);
            this.tbTitel.Name = "tbTitel";
            this.tbTitel.Size = new System.Drawing.Size(241, 20);
            this.tbTitel.TabIndex = 17;
            this.tbTitel.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(256, 7);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(154, 13);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Title, Description and Location:";
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Location = new System.Drawing.Point(12, 7);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(59, 13);
            this.lblThumbnail.TabIndex = 15;
            this.lblThumbnail.Text = "Thumbnail:";
            // 
            // tbDesciption
            // 
            this.tbDesciption.Location = new System.Drawing.Point(259, 49);
            this.tbDesciption.Multiline = true;
            this.tbDesciption.Name = "tbDesciption";
            this.tbDesciption.Size = new System.Drawing.Size(241, 118);
            this.tbDesciption.TabIndex = 14;
            this.tbDesciption.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(348, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 23);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(241, 144);
            this.pbImage.TabIndex = 12;
            this.pbImage.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(259, 199);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(83, 29);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(12, 173);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(241, 20);
            this.tbPath.TabIndex = 10;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 199);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 29);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(259, 173);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(241, 20);
            this.tbLocation.TabIndex = 18;
            this.tbLocation.Text = "Location";
            // 
            // UploadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 262);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbTitel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblThumbnail);
            this.Controls.Add(this.tbDesciption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "UploadFile";
            this.Text = "UploadFile";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTitel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.TextBox tbDesciption;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbLocation;
    }
}