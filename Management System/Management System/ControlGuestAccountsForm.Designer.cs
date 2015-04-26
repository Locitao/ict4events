namespace Management_System
{
    partial class ControlGuestAccountsForm
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
            this.lbUserAccounts = new System.Windows.Forms.ListBox();
            this.lblNameConst = new System.Windows.Forms.Label();
            this.lblRFIDCodeConst = new System.Windows.Forms.Label();
            this.lblAdressConst = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRFIDCode = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserAccounts
            // 
            this.lbUserAccounts.FormattingEnabled = true;
            this.lbUserAccounts.Location = new System.Drawing.Point(13, 13);
            this.lbUserAccounts.Name = "lbUserAccounts";
            this.lbUserAccounts.Size = new System.Drawing.Size(123, 160);
            this.lbUserAccounts.TabIndex = 0;
            // 
            // lblNameConst
            // 
            this.lblNameConst.AutoSize = true;
            this.lblNameConst.Location = new System.Drawing.Point(142, 16);
            this.lblNameConst.Name = "lblNameConst";
            this.lblNameConst.Size = new System.Drawing.Size(38, 13);
            this.lblNameConst.TabIndex = 1;
            this.lblNameConst.Text = "Name:";
            // 
            // lblRFIDCodeConst
            // 
            this.lblRFIDCodeConst.AutoSize = true;
            this.lblRFIDCodeConst.Location = new System.Drawing.Point(142, 42);
            this.lblRFIDCodeConst.Name = "lblRFIDCodeConst";
            this.lblRFIDCodeConst.Size = new System.Drawing.Size(63, 13);
            this.lblRFIDCodeConst.TabIndex = 2;
            this.lblRFIDCodeConst.Text = "RFID Code:";
            // 
            // lblAdressConst
            // 
            this.lblAdressConst.AutoSize = true;
            this.lblAdressConst.Location = new System.Drawing.Point(143, 68);
            this.lblAdressConst.Name = "lblAdressConst";
            this.lblAdressConst.Size = new System.Drawing.Size(42, 13);
            this.lblAdressConst.TabIndex = 3;
            this.lblAdressConst.Text = "Adress:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(206, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "label4";
            // 
            // lblRFIDCode
            // 
            this.lblRFIDCode.AutoSize = true;
            this.lblRFIDCode.Location = new System.Drawing.Point(206, 42);
            this.lblRFIDCode.Name = "lblRFIDCode";
            this.lblRFIDCode.Size = new System.Drawing.Size(35, 13);
            this.lblRFIDCode.TabIndex = 5;
            this.lblRFIDCode.Text = "label5";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(206, 68);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(35, 13);
            this.lblAdress.TabIndex = 6;
            this.lblAdress.Text = "label6";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(145, 95);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(96, 23);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(146, 124);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(95, 23);
            this.btnChangeInfo.TabIndex = 8;
            this.btnChangeInfo.Text = "Change info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(145, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // ControlGuestAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblRFIDCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAdressConst);
            this.Controls.Add(this.lblRFIDCodeConst);
            this.Controls.Add(this.lblNameConst);
            this.Controls.Add(this.lbUserAccounts);
            this.Name = "ControlGuestAccountsForm";
            this.Text = "ControlGuestAccountsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUserAccounts;
        private System.Windows.Forms.Label lblNameConst;
        private System.Windows.Forms.Label lblRFIDCodeConst;
        private System.Windows.Forms.Label lblAdressConst;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRFIDCode;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnExit;
    }
}