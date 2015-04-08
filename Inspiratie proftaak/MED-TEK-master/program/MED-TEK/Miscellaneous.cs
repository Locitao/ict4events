using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MED_TEK
{
    class Miscellaneous
    {

        public void miscellaneous()
        {
            
        }
        public string GetSubstringByString(string a, string b, string c)
        {
            // String a geeft aan welke tekens voor het resultaat moeten staan
            // String b geeft aan welke tekens achter het resultaat moet staan
            // String c geeft aan in welke tekens gezocht moet worden
            
            // return geeft de/het teken(s) terug die overblijven nadat string a en b eraf gehaald zijn
            return c.Substring((c.IndexOf(a) + a.Length), (c.IndexOf(b) - c.IndexOf(a) - a.Length));
        }

        

        public string versleutel(string source)
        {
            // First we need to convert the string into bytes, which
            // means using a text encoder.
            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

            // Create a buffer large enough to hold the string
            byte[] unicodeText = new byte[source.Length * 2];
            enc.GetBytes(source.ToCharArray(), 0, source.Length, unicodeText, 0, true);

            // Now that we have a byte array we can ask the CSP to hash it
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(unicodeText);

            // Build the final string by converting each byte
            // into hex and appending it to a StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString());
            }

            // And return it
            return sb.ToString();
            
        }

    }
}
