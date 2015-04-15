using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    class Material
    {
        /// <summary>
        /// This class is for identifying the materials, so we don't work with
        /// database objects in the program, but with objects.
        /// First some auto-properties.
        /// </summary>
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int MaterialId { get; set; }

        /// <summary>
        /// Constructor for materials.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="materialId"></param>
        public Material(string name, decimal price, int materialId)
        {
            Name = name;
            Price = price;
            MaterialId = materialId;
        }
        /// <summary>
        /// ToString method to be able to display the materials in a listbox.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string price = Convert.ToString(Price);
            string id = Convert.ToString(MaterialId);

            string final = "Material ID: " + id + ", " + Name + ", price to rent: " + price + ".";
            return final;

        }
    }
}
