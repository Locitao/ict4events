using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MediaSharingGuest
{
    /// <summary>
    /// This class converts files to be saved into the database.
    /// </summary>
    class Persistance
    {
        public void SerializeToByteArray(string imagePath)
        {
            FileStream fls;
            fls = new FileStream(@imagePath, FileMode.Open, FileAccess.Read);
            byte[] blob = new byte[fls.Length];
            fls.Read(blob, 0, System.Convert.ToInt32(fls.Length));
            fls.Close();
        }

        static void Deserialize(string imagePath)
        {
        }
    }
}
