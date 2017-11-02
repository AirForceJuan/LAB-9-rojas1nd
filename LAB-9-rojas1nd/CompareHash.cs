using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace LAB_9_rojas1nd
{
    class CompareHash 
    {
        


        public CompareHash() { }

       
        public static IEnumerable<string> Generate(int len,char[] Allowed_chars)
        {
            if(len == 1)
            {
                foreach (char c in Allowed_chars)
                {
                    yield return c.ToString();
                }
            }
            else
            {
                var sub_strings = Generate(len - 1, Allowed_chars);

                foreach (char c in Allowed_chars)
                {
                    foreach(string sub in sub_strings)
                    {
                        
                        yield return c + sub;
                    }
                }
            }
        }
      

    }
}
