using System;
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
        Category parentCategory;

        public CreateFolder(MediaSharingSystem medias, Category parentCategory)
        {
            InitializeComponent();
            this.medias = medias;
            this.parentCategory = parentCategory;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string foldername = tbFolderName.Text;
            int parentCategoryID = parentCategory.CategoryId;
            string RFIDcreator = medias.MediaUser.RFIDcode;

            //INSERT new folder foldername, parentID, creator. AUTO folderID
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
