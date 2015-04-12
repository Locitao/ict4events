using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Category
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int ParentCategoryId { get; set; }
        public List<Media> MediaItems { get; set; }

        public string Rfidcode { get; set; }

        public Category(string name, int categoryid, int parentcategoryid, string rfidcode)
        {
            Name = name;
            CategoryId = categoryid;
            ParentCategoryId = parentcategoryid;
            Rfidcode = Rfidcode;
        }

        public void ReturnMediaItems()
        {
            //SELECT statement to return all media items in this category
        }

        public void ReturnCategories()
        {
            //SELECT statement to return all categories in this category
        }
    }
}
