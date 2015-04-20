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
    public partial class EditCategoryName : Form
    {
        Connection connection = new Connection();
        Update update = new Update();
        Delete delete = new Delete();
        Protection protection = new Protection();

        int categoryId = 0;
        public EditCategoryName(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(update.EditCategoryName(categoryId, protection.ProtectAgainstSQLInjection(tbName.Text)));
            connection.SQLQueryNoOutput(delete.DeleteReportsWithCategoryId(categoryId));
            MessageBox.Show("Category name changed.");
            this.Close();
        }
    }
}
