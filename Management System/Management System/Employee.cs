using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public int EmployeeRights { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string PhoneNumber { get; set; }

        public Employee(int employeeID, string loginName, string loginPassword, int employeeRights, string employeeName, string employeeAddress, string phoneNumber)
        {
            EmployeeID = employeeID;
            LoginName = loginName;
            LoginPassword = loginPassword;
            EmployeeRights = employeeRights;
            EmployeeName = employeeName;
            EmployeeAddress = employeeAddress;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            string tempString = "";
            if (EmployeeRights == 0)
            {
                tempString = "no rights";
            }
            else if (EmployeeRights == 1)
            {
                tempString = "employee";
            }
            else if (EmployeeRights == 2)
            {
                tempString = "admin";
            }
            return EmployeeName + ", " + tempString;
        }
    }
}
