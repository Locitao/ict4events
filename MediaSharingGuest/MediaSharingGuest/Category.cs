using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Category
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }

        public Guest creator = new Guest();

        public string Description { get; set; }

        public Category()
        {

        }

        public void AddMedia()
        {

        }

        public void AddCategory()
        {

        }

        public void DeleteCategory()
        {

        }
    }
}
