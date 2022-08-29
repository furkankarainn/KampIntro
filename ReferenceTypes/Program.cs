using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;

            person2.FirstName = "Furkan";
            Console.WriteLine(person1.FirstName);
            //yukarda person2=person1 yaptığımızda adresleri aynı oldu. Hangisini değiştirirsek ikiside aynı değişikliği almış olucak.
            
            Customer customer = new Customer();
            customer.FirstName = "Salih";

            Person person3 = customer;
            // Console.WriteLine(((Customer)person3).CreditCardNumber);
            Employee employee = new Employee();
            employee.FirstName = "KARA";


            PersonManager personManager = new PersonManager();
            personManager.Add(person2);

            //Ana class olarak person oluşturduk employee ve customer a kalıtım olarak person verdik. sonra personmanager classımızı da person cinsinden parametreledik. Yukarda employee customer olarak ayrı ayrı firstnameler verdik
            //ben artık personmanager a hangisini gönderirsem onun firstnameini adresinden çekicek. Kalıtım olduğu için person olarak görüp alabilcek. ama baktığı adresteki adı alıcak.
            

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //base class=>Person (ebeveyn)
    class Customer:Person//Inherits/Kalıtım. Dedik ki customer bir persondır. Yani person classındakileri içerir ek olarak burdakileri içerir.
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
