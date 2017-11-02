using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace LAB_9_rojas1nd
{
    class GetHash
    {
        public GetHash() { }

        public static string Hash(string temp)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.ASCII.GetBytes(temp));
                return Convert.ToBase64String(hash);
            }
        }
    }
}
