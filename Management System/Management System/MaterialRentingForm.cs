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

        /// <summary>
        /// The main form for material renting
        /// </summary>
        public MaterialRentingForm()
        {
            InitializeComponent();
            connection = new DatabaseConnection();
            materialList = new List<Material>();
            RefreshMaterialList();
        }

        /// <summary>
        /// refresh all the materials in the listbox
        /// </summary>
        public void RefreshMaterialList()
        {
            materialList.Clear();
            lbMaterials.Items.Clear();
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT MATERIAL_ID, RESERVATION_ID, RFID_CODE, DATE_TAKEN, RETURN_DATE, MAT_CATEGORY_ID, MAT_NAME, PRICE FROM PT_MATERIAL m, PT_MAT_CATEGORY ca WHERE m.MAT_CATEGORY = ca.MAT_CATEGORY_ID ORDER BY m.MATERIAL_ID", out output, out exception))
            {
                try
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

                        if (tempMaterial.Status == MaterialStatus.free && cbFree.Checked)
                        {
                            materialList.Add(tempMaterial);
                            lbMaterials.Items.Add(tempMaterial);
                        }
                        else if (tempMaterial.Status == MaterialStatus.reserved && cbReserved.Checked)
                        {
                            materialList.Add(tempMaterial);
                            lbMaterials.Items.Add(tempMaterial);
                        }
                        else if (tempMaterial.Status == MaterialStatus.lent && cbLent.Checked)
                        {
                            materialList.Add(tempMaterial);
                            lbMaterials.Items.Add(tempMaterial);
                        }
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("This error occured:" + Environment.NewLine + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            if (lbMaterials.Items.Count > 0)
            {
                lbMaterials.SelectedIndex = 0;
            }
            else
            {
                lblMaterialName.Text = "--";
                lblPrice.Text = "--";
                lblStatus.Text = "--";
            }
        }

        /// <summary>
        /// Refresh the label text when another material has been selected
        /// </summary>
        private void lbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material m = (Material)lbMaterials.SelectedItem;
            lblMaterialName.Text = m.Name;
            lblPrice.Text = m.Price.ToString();
            lblStatus.Text = m.Status.ToString();
        }

        /// <summary>
        /// creates a form where the user can put in info about lending the selected item
        /// </summary>
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
                    Exception exception;
                    string query = "UPDATE PT_MATERIAL SET RFID_CODE = '" + material.RFID_CODE + "', DATE_TAKEN = TO_DATE('" + material.LendTime.ToString() + "', 'dd-mm-yyyy hh24:mi:ss'), RETURN_DATE = TO_DATE('" + material.ReturnTime.ToString() + "', 'dd-mm-yyyy hh24:mi:ss') WHERE MATERIAL_ID = '" + material.MaterialID + "'";
                    if (connection.SQLQueryNoOutput(query, out exception))
                    {
                        MessageBox.Show("Item" + material.Name + "is succesfully lend out to RFID_CODE: " + material.RFID_CODE + "," + Environment.NewLine + "until: " + material.ReturnTime.ToString());
                    }
                    else
                    {
                        MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
                    }
                    RefreshMaterialList();
                }
            }
            

        }

        /// <summary>
        /// Reserves an item to a guest
        /// </summary>
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
                    Exception exception;
                    if (material != null)
                    {
                        string query = "UPDATE PT_MATERIAL SET RFID_CODE = '" + material.RFID_CODE + "', DATE_TAKEN = TO_DATE('" + material.LendTime.ToString() + "', 'dd-mm-yyyy hh24:mi:ss'), RETURN_DATE = TO_DATE('" + material.ReturnTime.ToString() + "', 'dd-mm-yyyy hh24:mi:ss') WHERE MATERIAL_ID = '" + material.MaterialID + "'";
                        if (connection.SQLQueryNoOutput(query, out exception))
                        {
                            MessageBox.Show("Item: " + material.Name + "  is succesfully reserved to RFID_CODE: " + material.RFID_CODE + "," + Environment.NewLine + "from: " + material.LendTime.ToString() + Environment.NewLine + "until: " + material.ReturnTime.ToString());
                        }
                        else
                        {
                            MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
                        }
                    }
                    RefreshMaterialList();
                }
            }
            
        }

        /// <summary>
        /// Returns an item status into free, from reserved or lend
        /// </summary>
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

        /// <summary>
        /// Save the changes made to a item category
        /// </summary>
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
            }
            
        }

        /// <summary>
        /// Add an instance from the selected item category
        /// </summary>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            List<List<string>> output;
            Exception exception;
            string query = "SELECT MAT_CATEGORY_ID, MAT_NAME FROM PT_MAT_CATEGORY";
            if (connection.SQLQueryWithOutput(query, out output, out exception))
            {
                AddItemForm form = new AddItemForm(output);
                form.ShowDialog();
                if (form.saved)
                {
                    string queryAddItem = "INSERT INTO PT_MATERIAL(MATERIAL_ID, MAT_CATEGORY) VALUES(auto_inc_mat.nextval, '" + form.selectedItem + "')";
                    if (connection.SQLQueryNoOutput(queryAddItem, out exception))
                    {
                        MessageBox.Show("Item is succesfully added");
                    }
                    else
                    {
                        MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshMaterialList();
        }

        /// <summary>
        /// Add a new item category
        /// </summary>
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string query = "";
            AddCategoryForm form = new AddCategoryForm();
            form.ShowDialog();
            if (form.saved)
            {
                query = "INSERT INTO PT_MAT_CATEGORY(MAT_CATEGORY_ID, MAT_NAME, PRICE) VALUES(auto_inc_mct.nextval,'" + form.CategoryName+ "','" + form.Price +"')";
                Exception exception;
                if (connection.SQLQueryNoOutput(query, out exception))
                {
                    MessageBox.Show("Category: " + form.CategoryName + "  is succesfully returned");
                }
                else
                {
                    MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
                }
                RefreshMaterialList();
            }
            
        }

        /// <summary>
        /// Refresh the material list when filter states change
        /// </summary>
        private void checkboxes_CheckedChanged(object sender, EventArgs e)
        {
            RefreshMaterialList();
        }

    }
}
