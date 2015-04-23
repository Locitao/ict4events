namespace MediaSharingGuest
{
    partial class SearchWindow
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
            this.lbResults = new System.Windows.Forms.ListBox();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 16;
            this.lbResults.Location = new System.Drawing.Point(12, 29);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(439, 404);
            this.lbResults.TabIndex = 0;
            this.lbResults.SelectedIndexChanged += new System.EventHandler(this.lbResults_SelectedIndexChanged);
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(12, 9);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(103, 17);
            this.lblSearchResults.TabIndex = 1;
            this.lblSearchResults.Text = "Search results:";
            // 
            // lblOpen
            // 
            this.lblOpen.Location = new System.Drawing.Point(15, 439);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(137, 50);
            this.lblOpen.TabIndex = 2;
            this.lblOpen.Text = "Open";
            this.lblOpen.UseVisualStyleBackColor = true;
            this.lblOpen.Click += new System.EventHandler(this.lblOpen_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 501);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblSearchResults);
            this.Controls.Add(this.lbResults);
            this.Name = "SearchWindow";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.Button lblOpen;
    }
}