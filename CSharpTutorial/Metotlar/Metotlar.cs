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
    
   
   
        static void Main()
        {

            int result = MathHelper.Square(5);
            Console.WriteLine(result);



        }

    }
}
