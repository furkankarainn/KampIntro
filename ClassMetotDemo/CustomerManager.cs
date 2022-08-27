using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : " + customer.Ad);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.Ad);
        }

        public void ListCustomer(params Customer[] customers)
        {
            foreach (Customer cust in customers)
            {
                Console.WriteLine("Müşteriler : " + cust.Ad);
            }
        }
    }
}
