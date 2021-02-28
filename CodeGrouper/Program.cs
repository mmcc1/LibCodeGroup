using LibCodeGroup;
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

            string codedFile = CodeGroup.ConvertToCode(file);
            byte[] decodefile = CodeGroup.ConvertFromCode(codedFile);

            string coded5File = CodeGroup5.ConvertToCode(file);
            byte[] decode5file = CodeGroup5.ConvertFromCode(coded5File);

            Console.ReadLine();
        }
    }
}
