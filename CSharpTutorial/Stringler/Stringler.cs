using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringler
{
    internal class Stringler
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            foreach (var letter in city)
            {
                Console.WriteLine(letter);
            }
          


            string city2 = "İstanbul";
            string result = city + " " + city2;
            Console.Write(result);
            Console.ReadLine();
        }

    }
}
