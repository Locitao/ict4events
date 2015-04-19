namespace ReservationApp
{
    partial class Create_Account
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
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPostal = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPhone
            // 
            this.tbPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPhone.Location = new System.Drawing.Point(148, 162);
            this.tbPhone.MaxLength = 15;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(135, 20);
            this.tbPhone.TabIndex = 20;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(148, 127);
            this.tbCity.MaxLength = 50;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(135, 20);
            this.tbCity.TabIndex = 19;
            this.tbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCity_KeyPress);
            // 
            // tbPostal
            // 
            this.tbPostal.Location = new System.Drawing.Point(148, 93);
            this.tbPostal.MaxLength = 20;
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(135, 20);
            this.tbPostal.TabIndex = 18;
            this.tbPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostal_KeyPress);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(148, 38);
            this.tbAddress.MaxLength = 50;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(135, 20);
            this.tbAddress.TabIndex = 17;
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddress_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Postal Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Full name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(148, 12);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(135, 20);
            this.tbName.TabIndex = 11;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(88, 212);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 34);
            this.btnCreate.TabIndex = 21;
            this.btnCreate.Text = "Create your account!";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Country";
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(148, 67);
            this.tbCountry.MaxLength = 50;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(135, 20);
            this.tbCountry.TabIndex = 23;
            this.tbCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountry_KeyPress);
            // 
            // Create_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 258);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPostal);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "Create_Account";
            this.Text = "Create_Account";
            this.Load += new System.EventHandler(this.Create_Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPostal;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCountry;
    }
}