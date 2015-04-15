using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    class Material
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int MaterialId { get; set; }

        public Material(string name, decimal price, int materialId)
        {
            Name = name;
            Price = price;
            MaterialId = materialId;
        }

        public override string ToString()
        {
            string price = Convert.ToString(Price);
            string id = Convert.ToString(MaterialId);

            string final = "Material ID: " + id + ", " + Name + ", price to rent: " + price + ".";
            return final;

        }
    }
}
