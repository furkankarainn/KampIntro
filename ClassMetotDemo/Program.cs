using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Ad = "Furkan";
            customer1.Soyad = "Karain";

            Customer customer2 = new Customer();
            customer2.Ad = "Ömer";
            customer2.Soyad = "Diken";

            Customer customer3 = new Customer();
            customer3.Ad = "Hamza";
            customer3.Soyad = "Özkan";

            CustomerManager cm = new CustomerManager();
            cm.AddCustomer(customer1);

            Console.WriteLine("------------------------");
            cm.DeleteCustomer(customer2);

            Console.WriteLine("------------------------");
            cm.ListCustomer(customer1, customer2);

            Console.WriteLine("------------------------");
            cm.ListCustomer(customer1, customer2, customer3);
            
            Console.ReadLine();
        }
    }
}
