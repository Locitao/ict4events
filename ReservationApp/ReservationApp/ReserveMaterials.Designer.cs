namespace ReservationApp
{
    partial class ReserveMaterials
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
            this.lbMaterials = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatOne = new System.Windows.Forms.TextBox();
            this.tbMatTwo = new System.Windows.Forms.TextBox();
            this.tbMatThree = new System.Windows.Forms.TextBox();
            this.btnMat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMaterials
            // 
            this.lbMaterials.FormattingEnabled = true;
            this.lbMaterials.Location = new System.Drawing.Point(232, 12);
            this.lbMaterials.Name = "lbMaterials";
            this.lbMaterials.Size = new System.Drawing.Size(379, 251);
            this.lbMaterials.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here you can reserve materials. \r\nFill in 0, 1, 2 or three\r\ntextboxes with ID\'s o" +
    "f the items \r\nyou wish to reserve. Leave blank if\r\nyou don\'t wish to reserve equ" +
    "ipment.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number one:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "number two";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number three:";
            // 
            // tbMatOne
            // 
            this.tbMatOne.Location = new System.Drawing.Point(91, 87);
            this.tbMatOne.MaxLength = 3;
            this.tbMatOne.Name = "tbMatOne";
            this.tbMatOne.Size = new System.Drawing.Size(135, 20);
            this.tbMatOne.TabIndex = 5;
            this.tbMatOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatOne_KeyPress);
            // 
            // tbMatTwo
            // 
            this.tbMatTwo.Location = new System.Drawing.Point(91, 127);
            this.tbMatTwo.MaxLength = 3;
            this.tbMatTwo.Name = "tbMatTwo";
            this.tbMatTwo.Size = new System.Drawing.Size(135, 20);
            this.tbMatTwo.TabIndex = 6;
            this.tbMatTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatTwo_KeyPress);
            // 
            // tbMatThree
            // 
            this.tbMatThree.Location = new System.Drawing.Point(91, 166);
            this.tbMatThree.MaxLength = 3;
            this.tbMatThree.Name = "tbMatThree";
            this.tbMatThree.Size = new System.Drawing.Size(135, 20);
            this.tbMatThree.TabIndex = 7;
            this.tbMatThree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatThree_KeyPress);
            // 
            // btnMat
            // 
            this.btnMat.Location = new System.Drawing.Point(43, 192);
            this.btnMat.Name = "btnMat";
            this.btnMat.Size = new System.Drawing.Size(148, 75);
            this.btnMat.TabIndex = 8;
            this.btnMat.Text = "Finish your reservation. Once you\r\nclick here, your reservation will be\r\nfinalise" +
    "d.";
            this.btnMat.UseVisualStyleBackColor = true;
            this.btnMat.Click += new System.EventHandler(this.btnMat_Click);
            // 
            // ReserveMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 273);
            this.Controls.Add(this.btnMat);
            this.Controls.Add(this.tbMatThree);
            this.Controls.Add(this.tbMatTwo);
            this.Controls.Add(this.tbMatOne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMaterials);
            this.Name = "ReserveMaterials";
            this.Text = "ReserveMaterials";
            this.Load += new System.EventHandler(this.ReserveMaterials_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMaterials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatOne;
        private System.Windows.Forms.TextBox tbMatTwo;
        private System.Windows.Forms.TextBox tbMatThree;
        private System.Windows.Forms.Button btnMat;
    }
}