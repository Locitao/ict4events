using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Reaction
    {
        //Properties--------------------------
        public string Content { get; set; }
        public int MediaId { get; set; }
        public int ReactionId { get; set; }
        public string RfidCode { get; set; }
        public string Name { get; set; }
        public List<Like> Likes { get; set; }
        public List<Report> Reports { get; set; }
        public string AllInfo { get; set; }

        //Constructor-------------------------
        public Reaction(string content, int mediaid, string rfidCode)
        {
            Content = content;
            MediaId = mediaid;
            RfidCode = rfidCode;
            Likes = new List<Like>();
            Reports = new List<Report>();
        }

        /// <summary>
        /// This method updates the AllInfo property of the reaction class.
        /// </summary>
        public void UpdateAllInfoProperty()
        {
            if (Likes.Count == 0)
            {
                AllInfo = Name + ":  " + Content;
            }
            else if (Likes.Count == 1)
            {
                AllInfo = Name + ":  " + Content + " -> " + Likes.Count + " like.";
            }
            else if (Likes.Count > 1) 
            {
                AllInfo = Name + ":  " + Content + " -> " + Likes.Count + " likes.";
            }
        }
    }
}
