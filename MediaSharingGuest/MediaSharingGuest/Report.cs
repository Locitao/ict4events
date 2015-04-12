using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Report
    {
        public string Content { get; set; }
        public int ReportID { get; set; }
        public int CategoryID { get; set; }
        public int MediaID {get; set;}
        public int ReactionID { get; set; }
        public string RFIDCodeReporter { get; set; }
        public Report(string content, int categoryid, int mediaid, int reactionid, string rfidCodeReporter)
        {
            Content = content;
            CategoryID = categoryid;
            MediaID = mediaid;
            ReactionID = reactionid;
            RFIDCodeReporter = rfidCodeReporter;

            //INSERT een report in de database, RETURNED ReportID.
            ReportID = 0;
        }
    }
}
