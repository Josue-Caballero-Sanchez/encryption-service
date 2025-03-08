using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Encrypts the input string using a seed value
        public string Cypherencrypt(string enstr, int seed)
        {
            string encryptedString = "";

            for (int i = 0; i < enstr.Length; i++)
            {
                int eo = (i % 2 == 0) ? 2 : 3;

                int encryptedAscii = enstr[i] + seed + eo;
                encryptedString += (char)encryptedAscii;
            }

            return encryptedString;
        }

        // Decrypts the input string using a seed value
        public string Cypherdecrypt(string destr, int seed)
        {
            string decryptedString = "";

            for (int i = 0; i < destr.Length; i++)
            {
                int eo = (i % 2 == 0) ? 2 : 3;

                int decryptedAscii = destr[i] - seed - eo;
                decryptedString += (char)decryptedAscii;
            }

            return decryptedString;
        }
    }
}
