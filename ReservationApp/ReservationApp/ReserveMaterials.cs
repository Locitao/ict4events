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
        Select select = new Select();
        Update update = new Update();

        List<Material> allMaterials = new List<Material>(); 
        

        private string rfid;
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
            foreach (Material m in allMaterials)
            {
                lbMaterials.Items.Add(m.ToString());
            }
        }
    }
}
