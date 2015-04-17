using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Material
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
            else if (LendTime != DateTime.MinValue)
            {
                Status = MaterialStatus.reserved;
            }
            else
            {
                Status = MaterialStatus.lent;
            }

        }

        public override string ToString()
        {
            return MaterialID.ToString() + ", " + Name + ", " + Status.ToString();
        }
    }
}
