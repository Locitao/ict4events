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

        Insert insert = new Insert();
        Select select = new Select();

        public Media(string name, string path, string description, string rfidcreator, string location, int categoryid)
        {
            Name = name;
            Path = path;
            Description = description;
            RfidCreator = rfidcreator;
            Location = location;
            CategoryID = categoryid;

            //INSERT statement to add new media item to the database.
            insert.InsertImage(CategoryID, Name, Location, Description, RfidCreator);

            //SELECT statement to return the mediaID of the item. //RELOAD ALL MEDIAITEM SO NO ID IS NEEDED?
            select.SelectImageNoMediaID(CategoryID, Name, Location, Description, RfidCreator);

            //CODE that sets the mediaId.

        }

        public void DeleteReaction()
        {
            //REMOVE statement to remove a reaction. (Only works if user placed the message himself).
        }

        public void Update()
        {
            //SELECT statement to select all the likes on the media item.
            select.GetLikesMediaItem(MediaID);

            //Foreach loop to add this info to the comment list.


            //Foreach loop to add likes to the comment list.
        }

        public void RemoveLike(Like like)
        {
            //REMOVE query to remove the like.
            Likes.Remove(like);
        }

    }
}
