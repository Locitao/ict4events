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
        readonly Select select = new Select();
        readonly Update update = new Update();

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
            try
            {
                if (tbMatOne.Text != null)
                {
                    update.Update_Material(Convert.ToString(tbMatOne.Text), rfid);
                }

                if (tbMatTwo.Text != null)
                {
                    update.Update_Material(Convert.ToString(tbMatTwo.Text), rfid);
                }

                if (tbMatThree.Text != null)
                {
                    update.Update_Material(Convert.ToString(tbMatThree.Text), rfid);
                }

                MessageBox.Show("Thank you for placing your reservation. You will now be returned to the start.");
                Hide();
                Startup start = new Startup();
                start.Closed += (s, args) => Close();
                start.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Below I make sure users can only enter numbers in the text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbMatOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbMatTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbMatThree_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
