using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Burak", LastName = "Even", City = "Bursa" };

            Customer customer2 = new Customer(2, "Derin", "Demirog", "Bursa");
            Console.WriteLine(customer2.FirstName);
        }
      
    }
    class Customer
    {
        public Customer() //parametresi olmayan constructor'a default constructor denir.
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city) //bu kod şeklini ctor ve ardından tab twice yaparak oluşturduk. bu bir constructor'dır.
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Console.WriteLine("Yapıcı blok çalıştı.");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
