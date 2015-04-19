namespace Management_System
{
    partial class AdministrationLogInForm
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
            this.tbame = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLoginToManagementSystem = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogInMaterialRenting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbame
            // 
            this.tbame.Location = new System.Drawing.Point(98, 42);
            this.tbame.Name = "tbame";
            this.tbame.Size = new System.Drawing.Size(100, 20);
            this.tbame.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(98, 68);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // btnLoginToManagementSystem
            // 
            this.btnLoginToManagementSystem.Location = new System.Drawing.Point(12, 94);
            this.btnLoginToManagementSystem.Name = "btnLoginToManagementSystem";
            this.btnLoginToManagementSystem.Size = new System.Drawing.Size(88, 41);
            this.btnLoginToManagementSystem.TabIndex = 3;
            this.btnLoginToManagementSystem.Text = "Log in into management system";
            this.btnLoginToManagementSystem.UseVisualStyleBackColor = true;
            this.btnLoginToManagementSystem.Click += new System.EventHandler(this.btnLoginToManagementSystem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 71);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // btnLogInMaterialRenting
            // 
            this.btnLogInMaterialRenting.Location = new System.Drawing.Point(110, 94);
            this.btnLogInMaterialRenting.Name = "btnLogInMaterialRenting";
            this.btnLogInMaterialRenting.Size = new System.Drawing.Size(88, 41);
            this.btnLogInMaterialRenting.TabIndex = 6;
            this.btnLogInMaterialRenting.Text = "Log in into material renting";
            this.btnLogInMaterialRenting.UseVisualStyleBackColor = true;
            this.btnLogInMaterialRenting.Click += new System.EventHandler(this.btnLogInMaterialRenting_Click);
            // 
            // AdministrationLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.btnLogInMaterialRenting);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLoginToManagementSystem);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbame);
            this.Name = "AdministrationLogInForm";
            this.Text = "Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbame;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLoginToManagementSystem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogInMaterialRenting;
    }
}

