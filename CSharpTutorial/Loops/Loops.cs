using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            //********************************
            //do-while döngüsü



            string password = "";
            do
            {
                Console.WriteLine("Şifre giriniz: ");
                password = Console.ReadLine();

            } while (password != "test123"); //kullanıcının girdiği başlangıç ve bitiş değerleri arasında sayıları yazdırır    
            Console.WriteLine("Şifre doğru!");



            //********************************

            Console.Write("Kaçtan başlayalım?");            //kullanıcıdan başlangıç değeri alır
            string kullanicigirdisi = Console.ReadLine();     //kullanıcıdan alınan ekran girdisi değişkene atanır
            int i = Convert.ToInt32(kullanicigirdisi);      //string türündeki değişken int türüne dönüştürülür

            Console.Write("Kaça kadar yazdıralım?");          //kullanıcıdan bitiş değeri alır
            string kullanicigirdisi2 = Console.ReadLine();    //kullanıcıdan alınan ekran girdisi değişkene atanır
            int j = Convert.ToInt32(kullanicigirdisi2);       //string türündeki değişken int türüne dönüştürülür
            

            //for döngüsü
            for (int h = i; h <= j; h++) //i'den j'e kadar olan sayıları yazdırır
            {
                Console.WriteLine(h);
            }


            //********************************
            //while döngüsü



            while (i <= j) //kullanıcının girdiği başlangıç ve bitiş değerleri arasında sayıları yazdırır
            {
                Console.WriteLine(i);
                i++; //i değerini 1 artırır
            }




            //********************************
            //Foreach döngüsü


            string[] renkler = new string[9] { "mavi", "kırmızı", "sarı", "yeşil", "turuncu", "mor", "pembe", "beyaz", "siyah" };

            foreach (var item in renkler)
            {
                Console.WriteLine(item);
            }

            if(IsPrimeNumber(29))
            {
                Console.WriteLine("Asal sayıdır.");
            }
            else
            {
                Console.WriteLine("Asal sayı değildir.");
            }


        }



        private static bool IsPrimeNumber(int number)
        {
            bool asalMi = true;

            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    asalMi = false;
                   
                }
            }
            return asalMi;
        }
    }

        //********************************
        //Asal Sayı Bulma




    }


