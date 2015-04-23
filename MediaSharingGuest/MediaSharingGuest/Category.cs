using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    /// <summary>
    /// The class category.
    /// </summary>
    public class Category
    {
        //Properties---------------------------------
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int ParentCategoryId { get; set; }
        public List<Media> MediaItems { get; set; }
        public string Rfidcode { get; set; }
        
        //Constructor--------------------------------
        public Category(string name, int categoryid, int parentcategoryid, string rfidcode)
        {
            Name = name;
            CategoryId = categoryid;
            ParentCategoryId = parentcategoryid;
            Rfidcode = Rfidcode;
        }
    }
}
