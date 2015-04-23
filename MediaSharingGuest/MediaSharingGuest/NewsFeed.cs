using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    /// <summary>
    /// The newsfeed class.
    /// </summary>
    public class NewsFeed
    {
        //Fields----------------------------
        List<Reaction> messages = new List<Reaction>();

        //Properties------------------------
        List<Reaction> Messages
        {
            get { return messages; }
            set { messages = value; }
        }

        //Constructor----------------------
        public NewsFeed()
        {
        }
    }
}
