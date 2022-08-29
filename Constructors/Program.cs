using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            Customer customer1 = new Customer { Id = 1, FirstName = "Furkan", LastName = "Karain", City = "İstanbul" };
            Customer customer2 = new Customer ( 2, "Ömer", "Diken", "İstanbul" );//Böyle kullanırsak aşağıdaki parametreli constructora gider.
            //customer1 kullanımı = customer3 kullanımı---ikisinde default constructorı çalıştırır.
            Customer customer3 = new Customer();
            customer3.Id = 3;
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //Default Constructor
        public Customer(int id, string firstName,string lastName, string city)
        {
            //Böyle overload olarak tanımlarsak default constructorı da ezmemiş ve böyle bir kullanımı da açmış oluruz.
            //Ama böyle kullanabilmemiz için aşağıdaki gibi classın parametrelerini gelen parametrelere eşitlememiz gerekiyor yoksa çalışmaz.
           
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
