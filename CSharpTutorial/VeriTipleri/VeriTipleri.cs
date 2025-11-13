using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class VeriTipleri
    {
        static void Main()
        {
            int tamSayi = -2147483648;               // 32 bit işaretli tam sayı.
                                                     // -2,147,483,648 ile 2,147,483,647 arasında      


            long isikYili = 9223372036854775807;  // 64 bit işaretli tam sayı.
                                                  // -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasında


            short alınanYol = 32767;                   // 16 bit işaretli tam sayı.
                                                       // -32,768 ile 32,767 arasında


            byte yas = 50;                              // byte: 8 bit işaretsiz tam sayı.
                                                        // 0 ile 255 arasında


            float pi = 3.14f;                            // 32 bit ondalıklı sayı.
                                                         // Yaklaşık olarak ±1.5 x 10−45 ile ±3.4 x 1038 (3.402823e38 ile 3.402823e38 arasında)
                                                         // Virgülden sonra 7 basamağa kadar hassasiyet   


            double uzunluk = 20.4;                      // 64 bit ondalıklı sayı.
                                                        // Yaklaşık olarak ±5.0 × 10−324 ile ±1.7 × 10308 (1.79769313486232e308 ile 1.79769313486232e308 arasında)
                                                        // Virgülden sonra 15-16 basamağa kadar hassasiyet  

            char basHarfi = 'G';                        // 16 bit tek karakter saklamak için kullanılır. Tek tırnak içinde tanımlanır.  

            string ad = "Selami";                        // Metin verilerini temsil eden veri tipi. Çift tırnak işareti ile yazılır.                    

            Boolean boolValue = true;                  // true (doğru) veya false (yanlış) değerlerini alabilir. Mantıksal işlemler için kullanılır. 

            //Console.WriteLine("Tam Sayı: " + tamSayi+ "Long"+isikYili+ "short"+ alınanYol + "byte"+ yas + "float"+ pi + "double"+ uzunluk + "char"+ basHarfi + "string"+ ad + "Boolean" + boolValue);

            // $ işareti ile string interpolation kullanma
            Console.WriteLine($"Tam Sayı: {tamSayi}, Long: {isikYili}, short: {alınanYol}, byte: {yas}, float: {pi}, double: {uzunluk}, char: {basHarfi}, string: {ad}, Boolean: {boolValue}");
        }
    }
    }

