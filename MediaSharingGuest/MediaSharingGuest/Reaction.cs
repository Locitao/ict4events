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
        public int MediaId { get; set; }
        public int ReactionId { get; set; }
        public string RfidCode { get; set; }
        public string Name { get; set; }

        public int Likes { get; set; }

        Insert insert = new Insert();
        Select select = new Select();
        Connection connection = new Connection();

        public Reaction(string content, int mediaid, string rfidCode)
        {
            Content = content;
            MediaId = mediaid;
            RfidCode = rfidCode;

            //INSERT reaction into db, RETURNS reactionID.
            List<List<string>> output = new List<List<string>>();
            insert.AddReaction(MediaId, RfidCode, Content);
            connection.SQLQueryWithOutput(select.SelectReactionNoReactionID(MediaId, RfidCode, Content), out output);

            foreach (List<string> stringList in output)
            {
                MediaId = Convert.ToInt32(stringList[0]);
            }
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
    }
}
