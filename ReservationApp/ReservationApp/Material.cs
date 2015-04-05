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
        public bool Reserved { get; set; }

        public Material(string name, decimal price, int materialId, bool reserved)
        {
            name = Name;
            price = Price;
            materialId = MaterialId;
            reserved = Reserved;
        }
    }
}
