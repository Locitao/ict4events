namespace MediaSharingGuest
{
    partial class LoginForm
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
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.gbLoginAs = new System.Windows.Forms.GroupBox();
            this.lblUserOrRFID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUserOrRFID = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbLoginAs.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Location = new System.Drawing.Point(8, 23);
            this.rbUser.Margin = new System.Windows.Forms.Padding(4);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(59, 21);
            this.rbUser.TabIndex = 0;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(8, 47);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(68, 21);
            this.rbAdmin.TabIndex = 1;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // gbLoginAs
            // 
            this.gbLoginAs.Controls.Add(this.rbUser);
            this.gbLoginAs.Controls.Add(this.rbAdmin);
            this.gbLoginAs.Location = new System.Drawing.Point(16, 15);
            this.gbLoginAs.Margin = new System.Windows.Forms.Padding(4);
            this.gbLoginAs.Name = "gbLoginAs";
            this.gbLoginAs.Padding = new System.Windows.Forms.Padding(4);
            this.gbLoginAs.Size = new System.Drawing.Size(97, 80);
            this.gbLoginAs.TabIndex = 2;
            this.gbLoginAs.TabStop = false;
            this.gbLoginAs.Text = "Log in as:";
            // 
            // lblUserOrRFID
            // 
            this.lblUserOrRFID.AutoSize = true;
            this.lblUserOrRFID.Location = new System.Drawing.Point(8, 20);
            this.lblUserOrRFID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserOrRFID.Name = "lblUserOrRFID";
            this.lblUserOrRFID.Size = new System.Drawing.Size(78, 17);
            this.lblUserOrRFID.TabIndex = 3;
            this.lblUserOrRFID.Text = "RFID code:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(8, 47);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // tbUserOrRFID
            // 
            this.tbUserOrRFID.Location = new System.Drawing.Point(99, 16);
            this.tbUserOrRFID.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserOrRFID.Name = "tbUserOrRFID";
            this.tbUserOrRFID.Size = new System.Drawing.Size(251, 22);
            this.tbUserOrRFID.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(99, 47);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(251, 22);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.Visible = false;
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblUserOrRFID);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.tbUserOrRFID);
            this.gbLogin.Location = new System.Drawing.Point(121, 15);
            this.gbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(4);
            this.gbLogin.Size = new System.Drawing.Size(371, 80);
            this.gbLogin.TabIndex = 7;
            this.gbLogin.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 102);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 28);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(115, 102);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 145);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.gbLoginAs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.gbLoginAs.ResumeLayout(false);
            this.gbLoginAs.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.GroupBox gbLoginAs;
        private System.Windows.Forms.Label lblUserOrRFID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUserOrRFID;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}