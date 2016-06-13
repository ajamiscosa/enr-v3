using System;
using System.Text;
using System.Security.Cryptography;

namespace Enrollment.Classes
{
    public class SecurityUtils
    {
        public static string MD5(String str)
        {

            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(str);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();

            return encoded;
        }
    }
}
