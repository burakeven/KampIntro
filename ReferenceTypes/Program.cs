using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi1 = sayi2;
            //sayi2 = 100;
            //Console.WriteLine("Sayı 1: " + sayi1);

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;
            //Console.WriteLine("Sayilar 1'in 0'i: " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Burak";
            person2 = person1; //Burada person2'nin firstname'i de Burak olmuş olur çünkü referans adresini eşitler.
            person2.FirstName = "Derin"; // bunu derin yaparsak eğer person1'in de firstname'i derin olarak değişmiş olacaktır.
            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "0123456789";
            
            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Ahmet";
            //Console.WriteLine(((Customer)person3).CreditCardNumber); //Bu şekilde boxing yaptığımızda artık creditcardnumber'i da gördürebiliyoruz.
            PersonManager personmanager = new PersonManager();
            personmanager.Add(customer); //buraya hepsini yazabiliriz. employee'i de yazariz, customer'i da person'u da.

        }
    }
    //base class: Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person) //Person yaptığımızda hem Person'U hem Employee'i hemde Customer'i gönderebiliriz.
                                       //mesela parantez içerisine Employee yazsak sadece Employee'i göndeririz bu da bazı durumlarda işimize gelmez.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
