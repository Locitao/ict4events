using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Report
    {
        public string Content { get; set; }
        public int ReportId { get; set; }
        public int CategoryId { get; set; }
        public int MediaId {get; set;}
        public int ReactionId { get; set; }
        public string RFIDCodeReporter { get; set; }

        Insert insert = new Insert();
        public Report(int reportId, string content, int categoryId, int mediaId, int reactionId, string rfidCodeReporter)
        {
            ReportId = reportId;
            Content = content;
            CategoryId = categoryId;
            MediaId = mediaId;
            ReactionId = reactionId;
            RFIDCodeReporter = rfidCodeReporter;
           
        }
    }
}
