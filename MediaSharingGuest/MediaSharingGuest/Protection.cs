using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Protection
    {
        public string ProtectAgainstSQLInjection(string input)
        {
            string output;
            output = input.Replace(";", " ");
            output = input.Replace("'", " ");
            return output;
        }

        public string WordFilter(string input)
        {
            //THIS CODE IS NOT YET LINKED TO THE DATABASE

        }
    }
}
