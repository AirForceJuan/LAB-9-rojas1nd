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
    class Program
    {
        



        static void Main(string[] args)
        {
            

            

            List<string> HashedPasswords = File.ReadLines("C:\\words.txt").ToList();


            


            string Alphabet = "abcdefghijklmnopqrstuvwxyz";

           

            string test_1 = HashedPasswords[0];
            string test_2 = HashedPasswords[1];
            string test_3 = HashedPasswords[2];
            string test_4 = HashedPasswords[3];
            string test_5 = HashedPasswords[4];
            string test_6 = HashedPasswords[5];



            List<string> result_1 = CompareHash.Generate(8, Alphabet.ToCharArray(), test_1).ToList();
            CompareHash.toggle = false;
            List<string> result_2 = CompareHash.Generate(8, Alphabet.ToCharArray(), test_2).ToList();
            CompareHash.toggle = false;
            List<string> result_3 = CompareHash.Generate(8, Alphabet.ToCharArray(), test_3).ToList();
            //CompareHash.toggle = false;
            //List<string> result_4 = CompareHash.Generate(8, Alphabet.ToCharArray(), test_4).ToList(); //This crashed my Gaming Computer.... No Idea what it is?!?!?!?!
            CompareHash.toggle = false;
            List<string> result_5 = CompareHash.Generate(8, Alphabet.ToCharArray(), test_5).ToList();
            CompareHash.toggle = false;
            List<string> result_6 = CompareHash.Generate(8, Alphabet.ToCharArray(), test_6).ToList();






            Console.WriteLine("You Are Done");

            Console.Read();
        }
    }
}
