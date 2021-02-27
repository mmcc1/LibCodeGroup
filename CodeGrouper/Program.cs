using LibCodeGroup;
using System;
using System.Security.Cryptography;

namespace CodeGrouper
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] file = new byte[32768];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(file);

            string codedFile = CodeGroup.ConvertToCode(file);
            byte[] decodefile = CodeGroup.ConvertFromCode(codedFile);

            Console.ReadLine();
        }
    }
}
