﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;


namespace LAB_9_rojas1nd
{
    class Program
    {
        public static IEnumerable<string> Generate(int len, char[] Allowed_chars)
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
                var sub_strings = Generate(len - 1, Allowed_chars);

                foreach (char c in Allowed_chars)
                {
                    foreach (string sub in sub_strings)
                    {
                        Console.WriteLine(GetHash.Hash(c + sub) + " " +c+sub);
                        yield return c + sub;
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            List<string> HashedPasswords = File.ReadLines("C:\\words.txt").ToList();




            string Alphabet = "abcdefghijklmnopqrstuvwxyz";


            List<string> result = Generate(8, Alphabet.ToCharArray()).ToList();




        
        }
    }
}
