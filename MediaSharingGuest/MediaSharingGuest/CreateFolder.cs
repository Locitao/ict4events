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
    /// <summary>
    /// This form creates a folder and adds it to a certain category.
    /// </summary>
    public partial class CreateFolder : Form
    {
        //Fields------------------------------------
        MediaSharingSystem medias;
        Connection connection = new Connection();
        Protection protection = new Protection();
        Insert insert = new Insert();

        //Properties--------------------------------
        public int ParentCategory {get; set;}

        //Constructor---------------------------------
        public CreateFolder(MediaSharingSystem medias, int parentCategory)
        {
            InitializeComponent();
            this.medias = medias;
            ParentCategory = parentCategory;
        }

        //Events--------------------------------------

        //Create a folder with inserted data.
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string foldername = protection.ProtectAgainstSQLInjection(tbFolderName.Text);
            int parentCategoryID = ParentCategory;
            string RFIDcreator = medias.RfidCode;

            //Query that inserts the new folder.
            connection.SQLQueryNoOutput(insert.InsertCategory(foldername, parentCategoryID, RFIDcreator));
        }

        //Closes this window.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
