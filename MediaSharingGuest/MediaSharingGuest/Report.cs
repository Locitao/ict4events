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
        public int CategoryID
        {
            get
            {
                return CategoryID;
            }
            set
            {
                if (value == null)
                {
                    value = 0;
                }
                CategoryID = value;
            }
        }
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
        public int ReactionID
        {
            get
            {
                return ReactionID;
            }
            set
            {
                if (value == null)
                {
                    value = 0;
                }
                ReactionID = value;
            }
        }
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
