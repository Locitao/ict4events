using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    /// <summary>
    /// This class uses select statements to get all the required information
    /// such as available spots.
    /// </summary>
    public class Select
    {

        /// <summary>
        /// Select_Locations returns a List of every location on the camping which isn't reserved yet
        /// </summary>
        /// <returns></returns>

        public List<Dictionary<string, object>> Select_locations()
        {
            const string sql = "SELECT loc.loc_type, loc.max_people, loc.price, loc.location_ID FROM PT_EVENT_LOCATION loc WHERE loc.reservation_ID IS NULL";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        /// <summary>
        /// This method returns a list of possible events.
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, object>> Select_Events()
        {
            const string sql = "SELECT * FROM PT_EVENT";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }
        /// <summary>
        /// Below a method that returns materials that haven't been reserved yet.
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, object>> Select_Materials()
        {
            const string sql =
                "SELECT PT_MAT_CATEGORY.mat_name, PT_MAT_CATEGORY.price, PT_MATERIAL.material_id FROM PT_MAT_CATEGORY, PT_MATERIAL WHERE PT_MATERIAL.mat_category = PT_MAT_CATEGORY.mat_category_ID AND PT_MATERIAL.rfid_CODE IS NULL";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }
        /// <summary>
        /// Method below returns a string of the needed RFID code, which is looked up with a phone number
        /// </summary>
        /// <returns>string of rfid_code</returns>
        public string Select_User(string phone)
        {
            try
            {
                //THEN WHO WAS PHONE?!
                string sql = "SELECT rfid_CODE FROM PT_USER_ACC WHERE user_phone = '" + phone + "'";
                string rfid = "Operation failed";

                var data = Connection.ExecuteQuery(sql);
                foreach (Dictionary<string, object> row in data)
                {
                    rfid = Convert.ToString(row["rfid_CODE"]);
                }
                return rfid;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
            
        }
        /// <summary>
        /// Users can create accounts when a friend for them has already reserved for them,
        /// they still need to be coupled to the correct reservation, which is found
        /// by their friends phone number.
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string Find_ReservationId(string phone)
        {
            try
            {
                string sql =
                    "SELECT res.reservation_ID FROM PT_RESERVATION res, PT_USER_ACC us WHERE res.rfid_CODE = us.rfid_CODE AND us.user_phone = '" +
                    phone + "'";
                string rfid = "Operation failed!";

                var data = Connection.ExecuteQuery(sql);
                foreach (Dictionary<string, object> row in data)
                {
                    rfid = Convert.ToString(row["RESERVATION_ID"]);
                }
                return rfid;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        

        /// <summary>
        /// Method below returns the correct reservation ID, to be coupled with an account.
        /// </summary>
        /// <param name="rfid"></param>
        /// <returns></returns>
        public string Find_Res_Id(string rfid)
        {
            try
            {
                string sql = "SELECT res.reservation_ID FROM PT_RESERVATION res WHERE res.rfid_CODE = '" + rfid + "'";
                string res = "Operation failed!";

                var data = Connection.ExecuteQuery(sql);

                foreach (Dictionary<string, object> row in data)
                {
                    res = Convert.ToString(row["RESERVATION_ID"]);
                }
                return res;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        

    }
 
}
