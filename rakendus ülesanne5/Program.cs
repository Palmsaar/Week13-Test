﻿using System;
using System.IO;

namespace rakendus_ülesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileDirect = @"C:\Users\Laptop\samples\peeter\funFacts.txt";
            string[] fileData = File.ReadAllLines(fileDirect);

            Random rnd = new Random();
            int rndNum = rnd.Next(1, fileData.Length);

            Console.WriteLine(fileData[0]);
            Console.WriteLine(fileData[rndNum]);
        }
    }
}
