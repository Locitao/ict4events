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
        public int MediaId { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string RfidCreator { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
        public List<Like> Likes { get; set; }
        public List<Reaction> Reactions { get; set; }

        Insert insert = new Insert();
        Select select = new Select();
        Connection connection = new Connection();
        List<List<string>> output = new List<List<string>>();

        public Media(string name, string path, string description, string rfidcreator, string location, int categoryid, int mediaId)
        {
            Name = name;
            Path = path;
            Description = description;
            RfidCreator = rfidcreator;
            Location = location;
            CategoryId = categoryid;
            MediaId = mediaId;
            Likes = new List<Like>();
            Reactions = new List<Reaction>();

            //INSERT statement to add new media item to the datab
            //insert.InsertImage(CategoryId, Name, Location, Description, RfidCreator);

            //SELECT statement to return the mediaID of the item. //RELOAD ALL MEDIAITEM SO NO ID IS NEEDED?

            //CODE that sets the mediaId.
        }

        public void DeleteReaction()
        {
            //REMOVE statement to remove a reaction. (Only works if user placed the message himself).
        }

    }
}
