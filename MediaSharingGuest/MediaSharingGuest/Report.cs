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
        public Report(string content, int categoryId, int mediaId, int reactionId, string rfidCodeReporter)
        {
            Content = content;
            CategoryID = categoryId;
            MediaID = mediaId;
            ReactionID = reactionId;
            RFIDCodeReporter = rfidCodeReporter;

            //INSERT een report in de database, RETURNED ReportID.
            ReportID = 0;
        }
    }
}
