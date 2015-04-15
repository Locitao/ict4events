namespace MediaSharingGuest
{
    partial class ViewReports
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
            this.lbReports = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbReports
            // 
            this.lbReports.FormattingEnabled = true;
            this.lbReports.Location = new System.Drawing.Point(12, 28);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(511, 524);
            this.lbReports.TabIndex = 0;
            this.lbReports.SelectedIndexChanged += new System.EventHandler(this.lbReports_SelectedIndexChanged);
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 580);
            this.Controls.Add(this.lbReports);
            this.Name = "ViewReports";
            this.Text = "ViewReports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbReports;
    }
}