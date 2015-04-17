using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Event
    {
        public int CampingID { get; set; }
        public int EventID {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Event(int campingID, int eventID, string name, string description, DateTime startDate, DateTime endDate)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return Name + ", From: " + StartDate.ToString() + " To: " + EndDate.ToString();
        }
    }
}
