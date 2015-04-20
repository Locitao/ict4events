﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSharingGuest
{
    public partial class CreateFolder : Form
    {
        MediaSharingSystem medias;
        Protection protection = new Protection();
        public int ParentCategory {get; set;}

        Insert insert = new Insert();

        public CreateFolder(MediaSharingSystem medias, int parentCategory)
        {
            InitializeComponent();
            this.medias = medias;
            ParentCategory = parentCategory;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string foldername = protection.ProtectAgainstSQLInjection(tbFolderName.Text);
            int parentCategoryID = ParentCategory;
            string RFIDcreator = medias.RfidCode;

            //Query that inserts the new folder.
            insert.InsertCategory(foldername, parentCategoryID, RFIDcreator);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
