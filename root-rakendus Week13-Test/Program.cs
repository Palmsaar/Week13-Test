using System;
using System.IO;

namespace root_rakendus_Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = @"C:\Users\Laptop\samples";


            Console.WriteLine("Please enter a folder name.");
            string userFolder = Console.ReadLine();
            bool exists = Directory.Exists(@$"{rootdirect}\{userFolder}");
            if (exists)
            {
                Console.WriteLine($"{userFolder} already exists in Samples.");
            }
            else
            {
                Directory.CreateDirectory(@$"{rootdirect}\{userFolder}");
                Console.WriteLine($"{userFolder} has been created.");
            }
        }
    }
}
