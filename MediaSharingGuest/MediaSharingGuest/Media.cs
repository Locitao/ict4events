using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Media
    {
        public string Name { get; set; }
        public int MediaID { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public List<Reaction> Comments { get; set; }
        public List<Like> Likes { get; set; }

        public string RfidCreator { get; set; }
        public string Location { get; set; }
        public int CategoryID { get; set; }

        public Media(string name, string path, string description, string rfidcreator, string location, int categoryid)
        {
            Name = name;
            Path = path;
            Description = description;
            RfidCreator = rfidcreator;
            Location = location;
            CategoryID = categoryid;

            //INSERT statement to add new media item to the database. RETURNS MediaID!

            MediaID = 0;
        }

        public void AddReaction()
        {
            //INSERT statement to add a reaction to this media item.
        }

        public void DeleteReaction()
        {
            //REMOVE statement to remove a reaction. (Only works if user placed the message himself).
        }

        public void Update()
        {
            //SELECT statement to select all the comments on the media item and the likes on the media item.

            //Foreach loop to add this info to the comment list.

            //Foreach loop to add likes to the comment list.
        }
    }
}
