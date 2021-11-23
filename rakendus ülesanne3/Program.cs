using System;
using System.Collections.Generic;
using System.IO;

namespace rakendus_ülesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirect = @$"C:\Users\Laptop\samples\peeter";

            string[] dataFormFile = File.ReadAllLines($@"{rootDirect}\MilkyWay.txt");
            List<string> dataForPlanets = new List<string>();
            List<string> dataForStars = new List<string>();

            for (int i = 0; i < dataFormFile.Length; i++)
            {
                if (dataFormFile[i].Contains("planet"))
                {
                    dataForPlanets.Add(dataFormFile[i]);
                }
                else if (dataFormFile[i].Contains("star"))
                {
                    dataForStars.Add(dataFormFile[i]);
                }
            }

            File.WriteAllLines($@"{rootDirect}\planets.txt", dataForPlanets);
            File.WriteAllLines($@"{rootDirect}\stars.txt", dataForStars);

        }
    }
}
