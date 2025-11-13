using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SartBloklari
{
    internal class SartBloklari
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            Console.Write("Birinci sayıyı girin.");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin.");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin.");

            if (sayi1 > sayi2)
            {
                Console.WriteLine("1. sayı olan {0} daha büyük.", sayi1);
            }
            else
            {
                Console.WriteLine("2. sayı olan {0} daha büyük.", sayi2);

            }



            char harf;
            Console.Write("Bir karakter giriniz : ");
            harf = Convert.ToChar(Console.ReadLine());
            switch (harf)
            {
                case 'a': Console.WriteLine("Sesli Harf"); break;
                case 'e': Console.WriteLine("Sesli Harf"); break;
                case 'u': Console.WriteLine("Sesli Harf"); break;
                case 'ü': Console.WriteLine("Sesli Harf"); break;
                case 'ı': Console.WriteLine("Sesli Harf"); break;
                case 'i': Console.WriteLine("Sesli Harf"); break;  
                case 'o': Console.WriteLine("Sesli Harf"); break;
                case 'ö': Console.WriteLine("Sesli Harf"); break;
                default:
                    Console.WriteLine("\nGirilen karakter sessiz bir harf");
                    break;
            }
        }
    }
}
