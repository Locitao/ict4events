namespace Management_System
{
    partial class MaterialRentingForm
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
            this.lblMaterials = new System.Windows.Forms.Label();
            this.lblMaterialNameConstant = new System.Windows.Forms.Label();
            this.lblStatusConstant = new System.Windows.Forms.Label();
            this.lblPriceConstant = new System.Windows.Forms.Label();
            this.btnLendItem = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.btnReturnItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnReserveItem = new System.Windows.Forms.Button();
            this.btnChangeCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMaterials
            // 
            this.lbMaterials.FormattingEnabled = true;
            this.lbMaterials.Location = new System.Drawing.Point(12, 29);
            this.lbMaterials.Name = "lbMaterials";
            this.lbMaterials.Size = new System.Drawing.Size(208, 329);
            this.lbMaterials.TabIndex = 0;
            this.lbMaterials.SelectedIndexChanged += new System.EventHandler(this.lbMaterials_SelectedIndexChanged);
            // 
            // lblMaterials
            // 
            this.lblMaterials.AutoSize = true;
            this.lblMaterials.Location = new System.Drawing.Point(13, 13);
            this.lblMaterials.Name = "lblMaterials";
            this.lblMaterials.Size = new System.Drawing.Size(52, 13);
            this.lblMaterials.TabIndex = 1;
            this.lblMaterials.Text = "Materials:";
            // 
            // lblMaterialNameConstant
            // 
            this.lblMaterialNameConstant.AutoSize = true;
            this.lblMaterialNameConstant.Location = new System.Drawing.Point(226, 29);
            this.lblMaterialNameConstant.Name = "lblMaterialNameConstant";
            this.lblMaterialNameConstant.Size = new System.Drawing.Size(38, 13);
            this.lblMaterialNameConstant.TabIndex = 2;
            this.lblMaterialNameConstant.Text = "Name:";
            // 
            // lblStatusConstant
            // 
            this.lblStatusConstant.AutoSize = true;
            this.lblStatusConstant.Location = new System.Drawing.Point(226, 55);
            this.lblStatusConstant.Name = "lblStatusConstant";
            this.lblStatusConstant.Size = new System.Drawing.Size(40, 13);
            this.lblStatusConstant.TabIndex = 7;
            this.lblStatusConstant.Text = "Status:";
            // 
            // lblPriceConstant
            // 
            this.lblPriceConstant.AutoSize = true;
            this.lblPriceConstant.Location = new System.Drawing.Point(226, 42);
            this.lblPriceConstant.Name = "lblPriceConstant";
            this.lblPriceConstant.Size = new System.Drawing.Size(34, 13);
            this.lblPriceConstant.TabIndex = 8;
            this.lblPriceConstant.Text = "Price:";
            // 
            // btnLendItem
            // 
            this.btnLendItem.Location = new System.Drawing.Point(226, 71);
            this.btnLendItem.Name = "btnLendItem";
            this.btnLendItem.Size = new System.Drawing.Size(143, 23);
            this.btnLendItem.TabIndex = 9;
            this.btnLendItem.Text = "Lend item";
            this.btnLendItem.UseVisualStyleBackColor = true;
            this.btnLendItem.Click += new System.EventHandler(this.btnLendItem_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(286, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "label2";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(286, 42);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "label3";
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Location = new System.Drawing.Point(286, 29);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(35, 13);
            this.lblMaterialName.TabIndex = 5;
            this.lblMaterialName.Text = "label4";
            // 
            // btnReturnItem
            // 
            this.btnReturnItem.Location = new System.Drawing.Point(226, 129);
            this.btnReturnItem.Name = "btnReturnItem";
            this.btnReturnItem.Size = new System.Drawing.Size(143, 23);
            this.btnReturnItem.TabIndex = 10;
            this.btnReturnItem.Text = "Return item";
            this.btnReturnItem.UseVisualStyleBackColor = true;
            this.btnReturnItem.Click += new System.EventHandler(this.btnReturnItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(226, 187);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(143, 23);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "Add new item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(226, 216);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(143, 23);
            this.btnAddCategory.TabIndex = 12;
            this.btnAddCategory.Text = "Add new category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnReserveItem
            // 
            this.btnReserveItem.Location = new System.Drawing.Point(226, 100);
            this.btnReserveItem.Name = "btnReserveItem";
            this.btnReserveItem.Size = new System.Drawing.Size(143, 23);
            this.btnReserveItem.TabIndex = 13;
            this.btnReserveItem.Text = "Reserve item";
            this.btnReserveItem.UseVisualStyleBackColor = true;
            this.btnReserveItem.Click += new System.EventHandler(this.btnReserveItem_Click);
            // 
            // btnChangeCategory
            // 
            this.btnChangeCategory.Location = new System.Drawing.Point(226, 158);
            this.btnChangeCategory.Name = "btnChangeCategory";
            this.btnChangeCategory.Size = new System.Drawing.Size(143, 23);
            this.btnChangeCategory.TabIndex = 14;
            this.btnChangeCategory.Text = "Change Category";
            this.btnChangeCategory.UseVisualStyleBackColor = true;
            this.btnChangeCategory.Click += new System.EventHandler(this.btnChangeCategory_Click);
            // 
            // MaterialRentingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 380);
            this.Controls.Add(this.btnChangeCategory);
            this.Controls.Add(this.btnReserveItem);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnReturnItem);
            this.Controls.Add(this.btnLendItem);
            this.Controls.Add(this.lblPriceConstant);
            this.Controls.Add(this.lblStatusConstant);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMaterialNameConstant);
            this.Controls.Add(this.lblMaterials);
            this.Controls.Add(this.lbMaterials);
            this.Name = "MaterialRentingForm";
            this.Text = "MaterialRentingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMaterials;
        private System.Windows.Forms.Label lblMaterials;
        private System.Windows.Forms.Label lblMaterialNameConstant;
        private System.Windows.Forms.Label lblStatusConstant;
        private System.Windows.Forms.Label lblPriceConstant;
        private System.Windows.Forms.Button btnLendItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.Button btnReturnItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnReserveItem;
        private System.Windows.Forms.Button btnChangeCategory;
    }
}