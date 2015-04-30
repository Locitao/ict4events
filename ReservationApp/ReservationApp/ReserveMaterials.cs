using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationApp
{
    /// <summary>
    /// This form will be used to reserve materials by the guest.
    /// </summary>
    public partial class ReserveMaterials : Form
    {
        /// <summary>
        /// Select and update classes, because both are needed here.
        /// </summary>
        readonly Select select = new Select();
        readonly Update update = new Update();

        /// <summary>
        /// List of materials which can be reserved.
        /// </summary>
        readonly List<Material> allMaterials = new List<Material>(); 
         
        

        private readonly string rfid;
        public ReserveMaterials(string Rfid)
        {
            InitializeComponent();
            FillList();
            FillBox();
            rfid = Rfid;

        }

        private void ReserveMaterials_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// FillList() fills the list of materials with materials
        /// that haven't been reserved yet.
        /// </summary>
        public void FillList()
        {
            try
            {
                var materials = select.Select_Materials();

                foreach (Dictionary<string, object> row in materials)
                {
                    var name = Convert.ToString(row["MAT_NAME"]);
                    var price = Convert.ToDecimal(row["PRICE"]);
                    var id = Convert.ToInt32(row["MATERIAL_ID"]);

                    allMaterials.Add(new Material(name, price, id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// FillBox() fills the listbox with the materials in the list of materials.
        /// </summary>
        public void FillBox()
        {
            foreach (var m in allMaterials)
            {
                lbMaterials.Items.Add(m.ToString());
            }
        }

        /// <summary>
        /// Reserving the selected materials is done with the below button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMat_Click(object sender, EventArgs e)
        {
            bool test = false;
            try
            {
                if (tbMatOne.Text != "")
                {
                    if (checkMaterial(tbMatOne.Text))
                    {
                        MessageBox.Show(update.Update_Material(Convert.ToString(tbMatOne.Text), rfid));
                        test = true;
                    }
                    else
                    {
                        MessageBox.Show("This material doesn't exist, enter a correct ID.");
                    }


                }
               

                if (tbMatTwo.Text != "")
                {
                    if (checkMaterial(tbMatTwo.Text))
                    {
                        MessageBox.Show(update.Update_Material(Convert.ToString(tbMatTwo.Text), rfid));
                        test = true;  
                    }
                    else
                    {
                        MessageBox.Show("This material doesn't exist, enter a correct ID.");
                    }

                }
                

                if (tbMatThree.Text != "" && checkMaterial(tbMatThree.Text))
                {
                    if (checkMaterial(tbMatThree.Text))
                    {
                        MessageBox.Show(update.Update_Material(Convert.ToString(tbMatThree.Text), rfid));
                        test = true; 
                    }
                    else
                    {
                        MessageBox.Show("This material doesn't exist, enter a correct ID.");
                    }
                }
                
                if (test)
                {
                    MessageBox.Show("Thank you for placing your reservation. You will now be returned to the start. Remember that your friends have to register their account as well, to receive their RFID tag!");
                    Hide();
                    Startup start = new Startup();
                    start.Closed += (s, args) => Close();
                    start.Show(); 
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Below I make sure users can only enter numbers in the text boxes.
        /// One KeyPress handlers for every textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbMatOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMatTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMatThree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool checkMaterial(string s)
        {
            foreach (Material m in allMaterials)
            {
                int x = Convert.ToInt32(s);
                if (x == m.MaterialId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
