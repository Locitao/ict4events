using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    /// <summary>
    /// This class is for every function that updates someting in the database.
    /// </summary>
    class Update
    {
        Connection conn = new Connection();
        /// <summary>
        /// Update_Location updates the correct location with a reservation ID, so it's clear
        /// it's reserved.
        /// </summary>
        /// <param name="locationId"></param>
        /// <param name="reservation_ID"></param>
        /// <returns></returns>
        public string Update_Location(string locationId, string reservation_ID)
        {
            try
            {
                string query = "UPDATE PT_EVENT_LOCATION SET reservation_ID = '" + reservation_ID +
                               "' WHERE location_ID = '" + locationId + "'";

                conn.Execute(query);
                const string succes = "Great succes, location has been updated!";
                return succes;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// This method reserves the selected material and updates
        /// the rfid_Code associated with it.
        /// </summary>
        /// <param name="matId"></param>
        /// <param name="rfid"></param>
        /// <returns></returns>
        public string Update_Material(string matId, string rfid)
        {

            try
            {
                string query = "UPDATE PT_MATERIAL SET rfid_CODE = '" + rfid + "' WHERE material_ID = '" + matId + "'";
                conn.Execute(query);
                const string succes = "Material successfully reserved!";
                return succes;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
    }
}
