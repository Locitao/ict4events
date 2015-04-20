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
            connection.SQLQueryNoOutput(update.EditCategoryName(categoryId, tbName.Text));
            connection.
            this.Close();
        }
    }
}
