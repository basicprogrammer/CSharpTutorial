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
            Console.WriteLine(String.Format("{0}{1}",city,city2));
            Console.WriteLine(city.Length);
            Console.WriteLine(city.Clone());
            bool result = city.EndsWith("ğ");
            bool result2 = city.StartsWith("ğ");
            var result3 = city.IndexOf("k"); // k harfinin indexini verir, bulamazsa -1 döner
            var result4 = city.LastIndexOf("a"); // sondan başlayarak a harfinin indexini verir 
            var result5 = city.Insert(0, "Hello "); // başa ekleme yapar
            Console.WriteLine(result5);
            var result6 = city.Substring(2,2); // 2. indexten başla 2 karakter al
            Console.WriteLine(result6);

            Console.ReadLine();
        }

    }
}
