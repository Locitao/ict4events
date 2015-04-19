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
        public List<Report> Reports { get; set; }

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
            Reports = new List<Report>();
        }
    }
}
