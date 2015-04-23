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

        /// <summary>
        /// A class similar to a row i the database table PT_EVENT
        /// </summary>
        /// <param name="campingID">The ID from the camping this event will take place on</param>
        /// <param name="eventID">The ID from this event</param>
        /// <param name="name">The name from this event</param>
        /// <param name="description">A description for this event</param>
        /// <param name="startDate">The date this event will start on</param>
        /// <param name="endDate">The date this event will end on</param>
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
