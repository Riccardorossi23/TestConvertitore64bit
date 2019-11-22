using System;
using System.Text;

namespace ClassBase64
{
    public class Base64Class
    {

        public static string Base64()
        {
            string input = "Riccardo";
            byte[] toEncodeAsBytes = ASCIIEncoding.ASCII.GetBytes(input);

            string r = Convert.ToBase64String(toEncodeAsBytes);

            return r;
        }


    }
}