using System;
using DidiSoft.Pgp;

namespace PGPEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var pgpLib = new PGPLib();
            Console.WriteLine("successfully created");
        }
    }
}