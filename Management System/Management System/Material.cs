using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    public class Material

    {
        public int MaterialID { get; set; }
        public int ReservationID { get; set; }
        public string RFID_CODE { get; set; }
        public DateTime LendTime { get; set; }
        public DateTime ReturnTime { get; set; }

        public int MaterialCategoryID { get; set; }
        public string Name { get; set; }
        public MaterialStatus Status { get; set; }
        public int Price { get; set; }

        /// <summary>
        /// This class contains all info about a specific material
        /// </summary>
        /// <param name="materialID">The ID of this material</param>
        /// <param name="reservationID">The ID from the reservation that includes this material</param>
        /// <param name="rfid_code">The RFID code from the guest that reserves this material</param>
        /// <param name="lendTime">The date this material was/will be lend on</param>
        /// <param name="returnTime">The date this material should be returned on</param>
        /// <param name="materialCategoryID">The category ID this material belongs to</param>
        /// <param name="name">The name of the category this material belongs to</param>
        /// <param name="price">The price of this material</param>
        public Material(int materialID, int reservationID, string rfid_code, DateTime lendTime, DateTime returnTime, int materialCategoryID, string name, int price)
        {
            MaterialID = materialID;
            ReservationID = reservationID;
            RFID_CODE = rfid_code;
            LendTime = lendTime;
            ReturnTime = returnTime;
            MaterialCategoryID = materialCategoryID;
            Name = name;
            Price = price;

            if (RFID_CODE == "")
            {
                Status = MaterialStatus.free;
            }
            else if (lendTime <= DateTime.Now)
            {
                Status = MaterialStatus.lent;
            }
            else
            {
                Status = MaterialStatus.reserved;
            }

        }

        public override string ToString()
        {
            return MaterialID.ToString() + ", " + Name + ", " + Status.ToString();
        }
    }
}
