using System;
using System.IO;

namespace rakendus_ülesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = @"C:\Users\Laptop\samples\peeter";

            bool exists = File.Exists(@$"{rootdirect}\stars.txt");
            bool exists2 = File.Exists(@$"{rootdirect}\planets.txt");
            if (exists && exists2)
            {
                Console.WriteLine($"stars.txt and planets.txt already exist in Samples.");
            }
            else
            {
                File.Create(@$"{rootdirect}\stars.txt");
                File.Create(@$"{rootdirect}\planets.txt");
                Console.WriteLine($"planets.txt and stars.txt has been created.");
            }
        }
    }
}
