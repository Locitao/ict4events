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
    public partial class ReserveMaterials : Form
    {
        Select select = new Select();
        Update update = new Update();

        List<Material> allMaterials = new List<Material>(); 
        

        private string rfid;
        public ReserveMaterials()
        {
            InitializeComponent();
            FillList();
            FillBox();

        }

        private void ReserveMaterials_Load(object sender, EventArgs e)
        {

        }

        public void FillList()
        {
            string name;
            decimal price;
            int id;

            try
            {
                var materials = select.Select_Materials();

                foreach (Dictionary<string, object> row in materials)
                {
                    name = Convert.ToString(row["MAT_NAME"]);
                    price = Convert.ToDecimal(row["PRICE"]);
                    id = Convert.ToInt32(row["MATERIAL_ID"]);

                    allMaterials.Add(new Material(name, price, id));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FillBox()
        {
            foreach (Material m in allMaterials)
            {
                lbMaterials.Items.Add(m.ToString());
            }
        }
    }
}
