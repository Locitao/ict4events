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
            this.lbHotReports = new System.Windows.Forms.ListBox();
            this.lblHotReports = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.chbAutoClean = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReports
            // 
            this.lbReports.FormattingEnabled = true;
            this.lbReports.ItemHeight = 16;
            this.lbReports.Location = new System.Drawing.Point(601, 30);
            this.lbReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(232, 260);
            this.lbReports.TabIndex = 0;
            this.lbReports.SelectedIndexChanged += new System.EventHandler(this.lbReports_SelectedIndexChanged);
            // 
            // lbHotReports
            // 
            this.lbHotReports.FormattingEnabled = true;
            this.lbHotReports.ItemHeight = 16;
            this.lbHotReports.Location = new System.Drawing.Point(841, 30);
            this.lbHotReports.Margin = new System.Windows.Forms.Padding(4);
            this.lbHotReports.Name = "lbHotReports";
            this.lbHotReports.Size = new System.Drawing.Size(232, 260);
            this.lbHotReports.TabIndex = 1;
            this.lbHotReports.SelectedIndexChanged += new System.EventHandler(this.lbHotReports_SelectedIndexChanged);
            // 
            // lblHotReports
            // 
            this.lblHotReports.AutoSize = true;
            this.lblHotReports.Location = new System.Drawing.Point(838, 9);
            this.lblHotReports.Name = "lblHotReports";
            this.lblHotReports.Size = new System.Drawing.Size(84, 17);
            this.lblHotReports.TabIndex = 2;
            this.lblHotReports.Text = "Hot Reports";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(598, 9);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(58, 17);
            this.lblReports.TabIndex = 3;
            this.lblReports.Text = "Reports";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(954, 297);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(838, 302);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(76, 17);
            this.lblThreshold.TabIndex = 5;
            this.lblThreshold.Text = "Threshold:";
            // 
            // chbAutoClean
            // 
            this.chbAutoClean.AutoSize = true;
            this.chbAutoClean.Location = new System.Drawing.Point(841, 322);
            this.chbAutoClean.Name = "chbAutoClean";
            this.chbAutoClean.Size = new System.Drawing.Size(95, 21);
            this.chbAutoClean.TabIndex = 7;
            this.chbAutoClean.Text = "AutoClean";
            this.chbAutoClean.UseVisualStyleBackColor = true;
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 580);
            this.Controls.Add(this.chbAutoClean);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.lblHotReports);
            this.Controls.Add(this.lbHotReports);
            this.Controls.Add(this.lbReports);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewReports";
            this.Text = "ViewReports";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReports;
        private System.Windows.Forms.ListBox lbHotReports;
        private System.Windows.Forms.Label lblHotReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.CheckBox chbAutoClean;
    }
}