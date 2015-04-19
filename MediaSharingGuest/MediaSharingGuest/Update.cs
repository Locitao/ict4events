using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Update
    {
        public void BanUser(string rfidCode)
        {

        }
        public void UnbanUser(string rfidCode)
        {

        }

        public string EditCategoryName (int CategoryId, string newName)
        {
            string query = "UPDATE PT_MED_CATEGORY SET CATEGORY_NAME = " + "'" + newName + "'" + "WHERE CATEGORY_ID = " + "'" + CategoryId + "'";
            return query;
        }

        public string ReportHandled(int reportId)
        {
            string query = "UPDATE PT_REPORT SET HANDLED = 1 WHERE REPORT_ID = " +"'" + reportId + "'";
            return query;
        }
    }
}
