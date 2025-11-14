using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Diziler
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5] { "mavi", "kırmızı", "sarı", "yeşil", "turuncu" };

            foreach (var renk in renkler)
            {
                Console.WriteLine(renk);
            }
            Console.WriteLine("Dizilerin uzunluğu: " + renkler.Length);






            string[] hayvanlar = { "kedi", "köpek", "kuş", "maymun", "tavşan" };

            foreach (var hayvan in hayvanlar)
            {
                Console.WriteLine(hayvan);
            }
            Console.WriteLine("Dizilerin uzunluğu: " + hayvanlar.Length);





            string[] bolgeler= new string[5]; // 5 elemanlı boş bir dizi tanımlandı.
            bolgeler[0] = "İç Anadolu";       // Dizide elemanlar tek tek atandı. Atanmayanlar null olarak kalır ve yansırlar.
            bolgeler[1] = "Marmara";
            bolgeler[2] = "Ege";

            foreach (var bolge in bolgeler)
            {
                Console.WriteLine(bolge);
            }
            Console.WriteLine("Dizilerin uzunluğu: " + bolgeler.Length);    
        }
    }
}
