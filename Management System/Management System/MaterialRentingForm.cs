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
            //lbMaterials.SelectedIndex = 0;
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
            Material material = null;
            if (lbMaterials.SelectedItem != null)
            {
                LendItemForm form = new LendItemForm((Material)lbMaterials.SelectedItem);
                form.ShowDialog();
                if (form.saved)
                {
                    material = form.Mat;
                }
            }
            Exception exception;
            string query = "UPDATE PT_MATERIAL SET RFID_CODE = '" + material.RFID_CODE + "', DATE_TAKEN = TO_DATE('" + material.LendTime.ToString() + "', 'dd-mm-yyyy hh24:mi:ss'), RETURN_DATE = TO_DATE('" + material.ReturnTime.ToString() + "', 'dd-mm-yyyy hh24:mi:ss') WHERE MATERIAL_ID = '" + material.MaterialID + "'";
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show("Item" + material.Name + "is succesfully lend out to RFID_CODE: " + material.RFID_CODE + "," + Environment.NewLine +"until: " + material.ReturnTime.ToString());
            }
            else
            {
                 MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshMaterialList();

        }

        private void btnReserveItem_Click(object sender, EventArgs e)
        {
            Material material = null;
            if (lbMaterials.SelectedItem != null)
            {
                ReserveItemForm form = new ReserveItemForm((Material)lbMaterials.SelectedItem);
                form.ShowDialog();
                if (form.saved)
                {
                    material = form.Mat;
                }
            }
            Exception exception;
            string query = "UPDATE PT_MATERIAL SET RFID_CODE = '" + material.RFID_CODE + "', DATE_TAKEN = TO_DATE('" + material.LendTime.ToString() + "', 'dd-mm-yyyy hh24:mi:ss'), RETURN_DATE = TO_DATE('" + material.ReturnTime.ToString() + "', 'dd-mm-yyyy hh24:mi:ss') WHERE MATERIAL_ID = '" + material.MaterialID + "'";
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show("Item: " + material.Name + "  is succesfully reserved to RFID_CODE: " + material.RFID_CODE + "," + Environment.NewLine + "from: " + material.LendTime.ToString() + Environment.NewLine + "until: " + material.ReturnTime.ToString());
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshMaterialList();
        }

        private void btnReturnItem_Click(object sender, EventArgs e)
        {
            Material material = (Material)lbMaterials.SelectedItem;
            Exception exception;
            string query = "UPDATE PT_MATERIAL SET RFID_CODE = null, DATE_TAKEN = null, RETURN_DATE = null WHERE MATERIAL_ID = '" + material.MaterialID + "'";
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show("Item: " + material.Name + "  is succesfully returned");
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshMaterialList();
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            Material material = null;
            if (lbMaterials.SelectedItem != null)
            {
                ChangeCategoryForm form = new ChangeCategoryForm((Material)lbMaterials.SelectedItem);
                form.ShowDialog();
                if (form.saved)
                {
                    material = form.Mat;
                }
            }
            Exception exception;
            string query = "UPDATE PT_MAT_CATEGORY SET MAT_NAME = ' " + material.Name + "', PRICE = '" + material.Price.ToString() + "' WHERE MAT_CATEGORY_ID = '" + material.MaterialCategoryID + "'";
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show("Item: " + material.Name + "  is succesfully returned");
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshMaterialList();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string query = "";
            AddCategoryForm form = new AddCategoryForm();
            form.ShowDialog();
            if (form.saved)
            {
                query = "INSERT INTO PT_MAT_CATEGORY(MAT_CATEGORY_ID, MAT_NAME, PRICE) VALUES(auto_inc_mct.nextval,'" + form.Name+ "','" + form.Price +"')";
            }
            Exception exception;
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show("Category: " + form.Name + "  is succesfully returned");
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
        }

    }
}
