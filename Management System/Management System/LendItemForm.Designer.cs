namespace Management_System
{
    partial class LendItemForm
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
            this.tbRFIDCode = new System.Windows.Forms.TextBox();
            this.lblRFIDCode = new System.Windows.Forms.Label();
            this.btnLendItem = new System.Windows.Forms.Button();
            this.lblPriceConstant = new System.Windows.Forms.Label();
            this.lblStatusConstant = new System.Windows.Forms.Label();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMaterialNameConstant = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRFIDCode
            // 
            this.tbRFIDCode.Location = new System.Drawing.Point(115, 71);
            this.tbRFIDCode.Name = "tbRFIDCode";
            this.tbRFIDCode.Size = new System.Drawing.Size(100, 20);
            this.tbRFIDCode.TabIndex = 0;
            this.tbRFIDCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_LettersAndDigits);
            // 
            // lblRFIDCode
            // 
            this.lblRFIDCode.AutoSize = true;
            this.lblRFIDCode.Location = new System.Drawing.Point(27, 74);
            this.lblRFIDCode.Name = "lblRFIDCode";
            this.lblRFIDCode.Size = new System.Drawing.Size(63, 13);
            this.lblRFIDCode.TabIndex = 1;
            this.lblRFIDCode.Text = "RFID Code:";
            // 
            // btnLendItem
            // 
            this.btnLendItem.Location = new System.Drawing.Point(43, 122);
            this.btnLendItem.Name = "btnLendItem";
            this.btnLendItem.Size = new System.Drawing.Size(92, 23);
            this.btnLendItem.TabIndex = 2;
            this.btnLendItem.Text = "Lend Item";
            this.btnLendItem.UseVisualStyleBackColor = true;
            this.btnLendItem.Click += new System.EventHandler(this.btnLendItem_Click);
            // 
            // lblPriceConstant
            // 
            this.lblPriceConstant.AutoSize = true;
            this.lblPriceConstant.Location = new System.Drawing.Point(52, 42);
            this.lblPriceConstant.Name = "lblPriceConstant";
            this.lblPriceConstant.Size = new System.Drawing.Size(34, 13);
            this.lblPriceConstant.TabIndex = 14;
            this.lblPriceConstant.Text = "Price:";
            // 
            // lblStatusConstant
            // 
            this.lblStatusConstant.AutoSize = true;
            this.lblStatusConstant.Location = new System.Drawing.Point(52, 55);
            this.lblStatusConstant.Name = "lblStatusConstant";
            this.lblStatusConstant.Size = new System.Drawing.Size(40, 13);
            this.lblStatusConstant.TabIndex = 13;
            this.lblStatusConstant.Text = "Status:";
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Location = new System.Drawing.Point(112, 29);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(35, 13);
            this.lblMaterialName.TabIndex = 12;
            this.lblMaterialName.Text = "label4";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(112, 42);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "label3";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(112, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "label2";
            // 
            // lblMaterialNameConstant
            // 
            this.lblMaterialNameConstant.AutoSize = true;
            this.lblMaterialNameConstant.Location = new System.Drawing.Point(52, 29);
            this.lblMaterialNameConstant.Name = "lblMaterialNameConstant";
            this.lblMaterialNameConstant.Size = new System.Drawing.Size(38, 13);
            this.lblMaterialNameConstant.TabIndex = 9;
            this.lblMaterialNameConstant.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(141, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(115, 96);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReturnDate.TabIndex = 16;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(29, 102);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(66, 13);
            this.lblReturnDate.TabIndex = 17;
            this.lblReturnDate.Text = "Return date:";
            // 
            // LendItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 185);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPriceConstant);
            this.Controls.Add(this.lblStatusConstant);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMaterialNameConstant);
            this.Controls.Add(this.btnLendItem);
            this.Controls.Add(this.lblRFIDCode);
            this.Controls.Add(this.tbRFIDCode);
            this.Name = "LendItemForm";
            this.Text = "LendItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRFIDCode;
        private System.Windows.Forms.Label lblRFIDCode;
        private System.Windows.Forms.Button btnLendItem;
        private System.Windows.Forms.Label lblPriceConstant;
        private System.Windows.Forms.Label lblStatusConstant;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMaterialNameConstant;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
    }
}