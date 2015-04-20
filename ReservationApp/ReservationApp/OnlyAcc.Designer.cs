namespace ReservationApp
{
    partial class OnlyAcc
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
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
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
            this.label7 = new System.Windows.Forms.Label();
            this.tbReservePhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(143, 68);
            this.tbCountry.MaxLength = 40;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(135, 20);
            this.tbCountry.TabIndex = 2;
            this.tbCountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCountry_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Country";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(83, 213);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(116, 34);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create your account!";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPhone.Location = new System.Drawing.Point(143, 146);
            this.tbPhone.MaxLength = 15;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(135, 20);
            this.tbPhone.TabIndex = 5;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(143, 120);
            this.tbCity.MaxLength = 40;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(135, 20);
            this.tbCity.TabIndex = 4;
            this.tbCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCity_KeyPress);
            // 
            // tbPostal
            // 
            this.tbPostal.Location = new System.Drawing.Point(143, 94);
            this.tbPostal.MaxLength = 15;
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(135, 20);
            this.tbPostal.TabIndex = 3;
            this.tbPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostal_KeyPress);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(143, 39);
            this.tbAddress.MaxLength = 50;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(135, 20);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddress_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Your phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Postal Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Full name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 13);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(135, 20);
            this.tbName.TabIndex = 0;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Phone number of the";
            // 
            // tbReservePhone
            // 
            this.tbReservePhone.Location = new System.Drawing.Point(143, 176);
            this.tbReservePhone.MaxLength = 15;
            this.tbReservePhone.Name = "tbReservePhone";
            this.tbReservePhone.Size = new System.Drawing.Size(135, 20);
            this.tbReservePhone.TabIndex = 6;
            this.tbReservePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbReservePhone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "person who reserved.";
            // 
            // OnlyAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbReservePhone);
            this.Controls.Add(this.label7);
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
            this.Name = "OnlyAcc";
            this.Text = "Only Account";
            this.Load += new System.EventHandler(this.OnlyAcc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreate;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbReservePhone;
        private System.Windows.Forms.Label label8;
    }
}