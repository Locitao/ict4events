using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class MaterialRentingForm : Form
    {
        DatabaseConnection connection;
        List<Material> materialList;
        public MaterialRentingForm()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
            materialList = new List<Material>();
        }


        public void RefreshMaterialList()
        {
            materialList.Clear();
            lbMaterials.Items.Clear();
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("", out output, out exception))
            {
                foreach (List<string> list in output)
                {
                    Material tempMaterial = new Material();
                    materialList.Add(tempMaterial);
                    lbMaterials.Items.Add(tempMaterial);
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            lbMaterials.SelectedIndex = 0;
        }
    }
}
