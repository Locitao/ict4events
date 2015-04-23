using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Protection
    {
        /// <summary>
        /// This methods protects the database against sql injection statements.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ProtectAgainstSQLInjection(string input)
        {
            string output;
            output = input.Replace(";", " ");
            output = input.Replace("'", " ");
            output = input.Replace("%", " ");
            output = input.Replace("_", " ");
            output = input.Replace("*", " ");
            output = input.Replace("$", " ");
            output = input.Replace("NULL", " ");
            output = input.Replace("null", " ");
            return output;
        }

        public void WordFilter(string input)
        {
            //THIS CODE IS NOT YET LINKED TO THE DATABASE
        }
    }
}
