using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace LAB_9_rojas1nd
{
    class CompareHash
    {
        public static bool toggle = false;
        public static IEnumerable<string> Generate(int len, char[] Allowed_chars, string TheOne)
        {
                if (len == 1)
                {
                    foreach (char c in Allowed_chars)
                    {
                        yield return c.ToString();
                    }
                }
                else
                {
                    var sub_strings = Generate(len - 1, Allowed_chars, TheOne);

                    foreach (char c in Allowed_chars)
                    {
                        foreach (string sub in sub_strings)
                        {
                            string hashcheck = (GetHash.Hash(c + sub));
                            if (hashcheck == TheOne)
                            {
                            Console.WriteLine(TheOne + " == " + (c + sub));
                            CompareHash.toggle = true;
                            yield return c+sub;
                            
                            }

                            yield return c + sub;
                        }

                        if (toggle)
                        {
                            yield break;
                        }
                    }
                    
                }   

       

        }
    }
}

