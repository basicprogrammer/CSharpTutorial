using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Classes
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(); // instance - örnek
            customerManager.Add();
            customerManager.Update();



            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "X";
            customer.LastName = "Y";

            Customer customer2= new Customer
            {
                Id = 2,
                FirstName = "A",
                LastName = "B"
            };
            Console.WriteLine($"Musteri ID:{ customer2.Id}, Ad:{ customer2.FirstName}, Soyad:{ customer2.LastName}");  // get bloğundan dolayı sadece okunabilir        
            Console.ReadLine();
        }
    }
        
}
