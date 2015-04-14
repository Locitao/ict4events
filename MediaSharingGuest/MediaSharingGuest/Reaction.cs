using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Reaction
    {
        public string Content { get; set; }
        public int MediaID { get; set; }
        public int ReactionID { get; set; }
        public Guest Creator { get; set; }
        public List<Like> Likes { get; set; }

        Insert insert = new Insert();
        Select select = new Select();

        public Reaction(string content, int mediaid, Guest creator)
        {
            Content = content;
            MediaID = mediaid;
            Creator = creator;

            //INSERT reaction into db, RETURNS reactionID.
            insert.AddReaction(MediaID, Creator.RFIDcode, Content);
        }

        public void EditReaction(Reaction reaction)
        {

        }

        public void AddLike(Reaction reaction)
        {
            //INSERT like
        }

        public void DeleteLike(Reaction reaction, Guest user)
        {
            //Query to remove like
        }

        public override string ToString()
        {
            string postername = Creator.Name;
            string content = Content;
            string likes = Convert.ToString(Likes.Count);

            string reaction = postername + ": - " + content + "+ " + likes;

            return reaction;
        }
    }
}
