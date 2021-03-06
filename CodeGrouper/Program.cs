﻿using LibCodeGroup;
using System;
using System.Security.Cryptography;

namespace CodeGrouper
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] file = new byte[256];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(file);

            string[] lookup = CodeGroup.GenerateLookup();  //Generate a random lookup

            string codedFile = CodeGroup.ConvertToCode(file);

            //CodeTalker.Speak(codedFile);  //This may only work on Windows - TTS output

            byte[] decodefile = CodeGroup.ConvertFromCode(codedFile);

            string[] lookup5 = CodeGroup5.GenerateLookup();  //Generate a random lookup

            string coded5File = CodeGroup5.ConvertToCode(file);
            //CodeTalker.Speak(coded5File);  //This may only work on Windows - TTS output
            byte[] decode5file = CodeGroup5.ConvertFromCode(coded5File);

            Console.ReadLine();
        }
    }
}
