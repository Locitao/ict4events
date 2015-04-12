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
        public int ParentCategoryId 
        { 
            get 
            { 
                return ParentCategoryId; 
            }
            set
            {
                if (value == null)
                {
                    value = 0;
                }
                ParentCategoryId = value;
            }
        }

        public string Rfidcode { get; set; }

        public Category(string name, int categoryid, int parentcategoryid, string rfidcode)
        {
            Name = name;
            CategoryId = categoryid;
            ParentCategoryId = parentcategoryid;
            Rfidcode = Rfidcode;
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
