using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class MathHelper
    {

        public static int Square(int number)
        {
            return number * number;
        }



        static int refAdd(ref int a, int b) // Ref yerine out da kullanılabilirdi.
                                            // Ref yerine out da kullanılabilirdi lakin out kullanıldığında a değişkenine metodun içinde bir değer ataması yapılması zorunludur.
        {
            a = 2; //Reference olarak gönderilen değişkenin değeri değişir.
            var resultref=a + b; 
            return resultref;
            // var ve return kullanımı yerine direkt olarak return a + b; da yazılabilirdi.
        }

        static int notrefAdd(int c, int d)
        {
            c = 1; //Değer olarak gönderilen değişkenin değeri değişmez.Referans olarak gönderilmediği için orijinal değişken etkilenmez.
            var resultnotref = c + d;
            return resultnotref;

        }

        static void Main()
        {
            // Square metodunu çağırma
            int result = MathHelper.Square(5); // Square metoduna 5 sayısını gönderiyoruz.
            Console.WriteLine(result);
            //---------------------------------------------




            // Metotlarda Ref ve Out kullanımı
            int a = 5;
            int b = 10;

            var resultref = refAdd(ref a, b); // a değişkeni ref olarak gönderildiği için değeri değişebilir.
                                              // Ref yerine out da kullanılabilirdi lakin out kullanıldığında a değişkenine metodun içinde bir değer ataması yapılması zorunludur.
            Console.WriteLine(resultref);



            int c = 4;
            int d = 8;           

            var resultnotref = notrefAdd(c, d);
            Console.WriteLine(resultnotref);  
        }

    }
}
