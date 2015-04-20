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
    /// This form lets an administrator edit passed category name.
    /// </summary>
    public partial class EditCategoryName : Form
    {
        //Fields--------------------------------------
        Connection connection = new Connection();
        Update update = new Update();
        Delete delete = new Delete();
        Protection protection = new Protection();
        int categoryId = 0;

        //Constructor---------------------------------
        public EditCategoryName(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
        }

        //Events--------------------------------------

        //Closes the form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Changes the name of the folder into recieved data.
        private void btnChange_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(update.EditCategoryName(categoryId, protection.ProtectAgainstSQLInjection(tbName.Text)));
            connection.SQLQueryNoOutput(delete.DeleteReportsWithCategoryId(categoryId));
            MessageBox.Show("Category name changed.");
            this.Close();
        }
    }
}
