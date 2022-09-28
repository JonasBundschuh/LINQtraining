using System;
using System.Linq;

namespace LINQtraining
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Aufgabe 4 
            // int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //
            // var n = from x in arr1 group x by x into y select y;
            //
            // foreach(var x in n)
            // {
            //     Console.WriteLine($"Zahl: {x.Key}, Anzahl: {x.Count()} Multiplikation: {x.Key * x.Count()}");
            // }
            //
            // Console.ReadLine();

            //  //aufgabe 5
            //  Console.WriteLine("Bitte gebe dein Wort ein: ");
            //  string str = Console.ReadLine();
            //  var f = from e in str group e by e into g select g;
            //  foreach(var e in f)
            //  {
            //      Console.WriteLine($"Buchstabe: {e.Key}, Anzahl: {e.Count()}");
            //  }
            //
            //  Console.ReadLine();

            //Aufgabe 6
            // int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            //
            // var n = from x in arr1 group x by x into y select y;
            //
            // foreach(var x in n)
            // {
            //     Console.WriteLine($"Zahl: {x.Key}, Anzahl: {x.Count()} Multiplikation: {x.Key * x.Count()}");
            // }
            //
            // Console.ReadLine();

            //Aufgabe 7

            // string c1 = "A";
            // string c2 = "M";
            //
            // //Liste
            //List<string> cities = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            //
            // foreach(string city in cities)
            // {
            //     if (city.StartsWith(c1.ToUpper()) && city.EndsWith(c2.ToUpper()))
            //     {
            //         Console.WriteLine(city);
            //     }
            // }
            // Console.ReadKey();

            //Aufgabe 8
            // Console.WriteLine("gebe an wie viele einträge du hinzufügen möchtest: ");
            // int userAnzahl = Convert.ToInt32(Console.ReadLine());
            //
            // List<int> numb = new List<int>();
            // for (int i = 0; i < userAnzahl; i++)
            // {
            //     Console.WriteLine("Bitte gib an welche zahl du hinzufügen möchtest: ");
            //     numb.Add(Convert.ToInt32(Console.ReadLine()));
            //
            //     
            // }
            // foreach (int i in numb)
            // {
            //     if(i > userAnzahl)
            //     {
            //         Console.Clear();
            //         Console.WriteLine(i);
            //     }
            // }
            // Console.ReadLine();


            //Aufgabe 9
            //Console.WriteLine("Wie viele Einträge sollen ausgegeben werde?: ");
            //int userA = Convert.ToInt32(Console.ReadLine());
            //
            //List<int> num = new List<int>() { 20, 19, 18, 17, 16, 15, 14, 13 ,12 ,11, 10, 9, 7, 6, 5, 4, 3, 2, 1, 0};
            //foreach(int x in num.Take(userA))
            //{
            //    Console.WriteLine(x);
            //}
            //
            //Console.ReadKey();

            //Aufgabe 10
            //Console.WriteLine("Gib einen satz mit UPPER und lower case wörtern ein: ");
            //string userSentence = Console.ReadLine();
            //string[] strings = userSentence.Split(' ');
            //foreach (string s in strings.Where(s => s == s.ToUpper()))
            //{
            //    Console.Clear();
            //    Console.WriteLine(s);
            //}
            //
            //Console.ReadKey();





        }
    }
}
