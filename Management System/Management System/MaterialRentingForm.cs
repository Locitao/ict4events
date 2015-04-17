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
            RefreshMaterialList();
        }


        public void RefreshMaterialList()
        {
            materialList.Clear();
            lbMaterials.Items.Clear();
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT MATERIAL_ID, RESERVATION_ID, RFID_CODE, DATE_TAKEN, RETURN_DATE, MAT_CATEGORY_ID, MAT_NAME, PRICE FROM PT_MATERIAL m, PT_MAT_CATEGORY ca WHERE m.MAT_CATEGORY = ca.MAT_CATEGORY_ID", out output, out exception))
            {
                
                foreach (List<string> list in output)
                {
                    int tempReservationID;
                    DateTime tempStartDate;
                    DateTime tempEndDate;
                    if (list[1] == "")
                    {
                        tempReservationID = 0;
                    }
                    else
                    {
                        tempReservationID = Convert.ToInt32(list[1]);
                    }
                    if (list[3] == "")
                    {
                        tempStartDate = DateTime.MinValue;
                    }
                    else
                    {
                        tempStartDate = Convert.ToDateTime(list[3]);
                    }
                    if (list[4] == "")
                    {
                        tempEndDate = DateTime.MinValue;
                    }
                    else
                    {
                        tempEndDate = Convert.ToDateTime(list[4]);
                    }
                    Material tempMaterial = new Material(Convert.ToInt32(list[0]), tempReservationID, list[2], tempStartDate, tempEndDate, Convert.ToInt32(5), list[6], Convert.ToInt32(list[7]));
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

        private void lbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material m = (Material)lbMaterials.SelectedItem;
            lblMaterialName.Text = m.Name;
            lblPrice.Text = m.Price.ToString();
            lblStatus.Text = m.Status.ToString();
        }

        private void btnLendItem_Click(object sender, EventArgs e)
        {
            LendItemForm form = new LendItemForm((Material)lbMaterials.SelectedItem);
            form.ShowDialog();
            if (form.saved)
            {
                Material material = form.Mat;
            }

        }

    }
}
