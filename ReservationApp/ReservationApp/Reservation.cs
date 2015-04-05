using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    class Reservation
    {
        /// <summary>
        /// Every reservation has a list of materials belonging to that reservation, a boolean to check if it's been paid
        /// for, and an amount decimal to keep track of how much the reservation cost.
        /// </summary>
        private List<Material> reservedMaterials = new List<Material>();
        public bool Paid { get; set; }
        public decimal Amount { get; set; }
        public int EventId { get; set; }

        public Reservation(int eventId)
        {
            eventId = EventId;
        }
    }
}
