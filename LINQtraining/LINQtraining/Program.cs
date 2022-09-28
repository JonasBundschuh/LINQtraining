using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQtraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would u like to start?: (y/n)");
            char userStart = Convert.ToChar(Console.ReadLine());

            if (userStart == 'y')
            {
                Console.Clear();
                Console.WriteLine("Welcome!");
            }
            else {
                Console.Clear();
                Console.WriteLine("GoodBye");
            };

            Console.ReadKey();
        }
    }
}
