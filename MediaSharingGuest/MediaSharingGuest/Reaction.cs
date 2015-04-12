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
        public int MediaID
        {
            get
            {
                return MediaID;
            }
            set
            {
                if (value == null)
                {
                    value = 0;
                }
                MediaID = value;
            }
        }
        public int ReactionID { get; set; }
        public List<Like> Likes { get; set; }

        public Reaction(string content, int mediaid)
        {
            Content = content;
            MediaID = mediaid;

            //INSERT reaction into db, RETURNS reactionID.
            ReactionID = 0;
        }

        public void EditReaction()
        {

        }

        public void AddLike()
        {

        }

        public void DeleteLike()
        {

        }
    }
}
