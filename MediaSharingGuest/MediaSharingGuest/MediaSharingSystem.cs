using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class MediaSharingSystem
    {
        public string RfidCode {get; set;}
        public string Username {get; set;}

        public MediaSharingSystem(string rfidCode, string username)
        {
            RfidCode = rfidCode;
            Username = username;
        }
        public void AddCategory()
        {

        }

        public void DeleteCategory()
        {

        }

        public void AddReactionToNewsFeed()
        {

        }

        public void DeleteReactionFromNewsFeed()
        {

        }
    }
}
