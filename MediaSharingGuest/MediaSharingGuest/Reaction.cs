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
        public string RfidCode { get; set; }
        public List<Like> Likes { get; set; }

        Insert insert = new Insert();
        Select select = new Select();

        public Reaction(string content, int mediaid, string rfidCode)
        {
            Content = content;
            MediaID = mediaid;
            RfidCode = rfidCode;

            //INSERT reaction into db, RETURNS reactionID.
            insert.AddReaction(MediaID, RfidCode, Content);
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
            //Query to get the name of the reactor.


            string postername = Creator.Name;
            string content = Content;
            string likes = Convert.ToString(Likes.Count);

            string reaction = postername + ": - " + content + "+ " + likes;

            return reaction;
        }
    }
}
