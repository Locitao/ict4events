using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    /// <summary>
    /// This class will be used to insert multiple things into the database.
    /// </summary>
    class Insert
    {
        Connection conn = new Connection();

        /// <summary>
        /// This method inserts a reservation with the given parameters into the database.
        /// Returns a string which says it has succeeded, or returns the error message from the try/catch.
        /// </summary>
        /// <param name="rfid_Code"></param>
        /// <param name="event_ID"></param>
        /// <param name="person_amount"></param>
        /// <param name="paid"></param>
        /// <returns></returns>
        public string Insert_Reservation(string rfid_Code, string event_ID, string person_amount, string paid)
        {
            try
            {
                string query =
                    "INSERT INTO PT_RESERVATION (reservation_ID, rfid_CODE, event_ID, person_amount, paid) VALUES (auto_inc_res.nextval, '" +
                    rfid_Code + "', '" + event_ID + "', '" + person_amount + "', '" + paid + "')";

                conn.Execute(query);
                const string succes = "Reservation created!";
                return succes;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            finally
            {
                conn.CloseConnection();
            }
            
        }
        /// <summary>
        /// Every visitor has to create an account, these accounts are inserted into the database
        /// with this method.
        /// </summary>
        /// <param name="user_name"></param>
        /// <param name="user_address"></param>
        /// <param name="user_phone"></param>
        /// <returns></returns>
        public string Insert_Account(string user_name, string user_address, string user_phone)
        {
            try
            {
                string query =
                    "INSERT INTO PT_USER_ACC (rfid_CODE, user_name, user_address, user_phone) VALUES (auto_inc_acc.nextval, '" +
                    user_name + "', '" + user_address + "', '" + user_phone + "' )";

                conn.Execute(query);
                const string success = "Account created!";
                conn.CloseConnection();
                return success;

            }
            catch (Exception ex)
            {
                conn.CloseConnection();
                return ex.Message;
            }

            
           
        }
        /// <summary>
        /// This insert for a new account that's immediately coupled with the person
        /// who reserved for them.
        /// </summary>
        /// <param name="user_name"></param>
        /// <param name="user_address"></param>
        /// <param name="user_phone"></param>
        /// <param name="reservation"></param>
        /// <returns></returns>
        public string Insert_Acc_Res(string user_name, string user_address, string user_phone, string reservation)
        {
            try
            {
                string query =
                    "INSERT INTO PT_USER_ACC (rfid_CODE, user_name, user_address, user_phone, reservation_ID, event_ID) VALUES (auto_inc_acc.nextval, '" +
                    user_name + "', '" + user_address + "', '" + user_phone + "', '" + reservation + "', '2')";
                conn.Execute(query);
                const string success = "Account created and coupled with your friends reservation!";
                conn.CloseConnection();
                return success;
            }
            catch (Exception ex)
            {
                conn.CloseConnection();
                return ex.Message;
            }
        }
    }
}
