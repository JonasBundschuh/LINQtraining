using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LINQtraining
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe 8

            string c1 = "A";
            string c2 = "M";

            //Liste
           List<string> cities = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            foreach(string city in cities)
            {
                if (city.StartsWith(c1.ToUpper()) && city.EndsWith(c2.ToUpper()))
                {
                    Console.WriteLine(city);
                }
            }
            Console.ReadKey();
        }
    }
}
