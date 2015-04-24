using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    /// <summary>
    /// This class contains all the information about a media item.
    /// </summary>
    public class Media
    {
        //Properties-------------------------------
        public string Name { get; set; }
        public int MediaId { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string RfidCreator { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
        public List<Like> Likes { get; set; }
        public List<Reaction> Reactions { get; set; }
        public List<Report> Reports { get; set; }
        public string FileType { get; set; }

        //Constructor-----------------------------------------
        public Media(string name, string path, string description, string rfidcreator, string location, int categoryid, int mediaId, string fileType)
        {
            Name = name;
            Path = path;
            Description = description;
            RfidCreator = rfidcreator;
            Location = location;
            CategoryId = categoryid;
            MediaId = mediaId;
            FileType = fileType;

            Likes = new List<Like>();
            Reactions = new List<Reaction>();
            Reports = new List<Report>();
        }
    }
}
