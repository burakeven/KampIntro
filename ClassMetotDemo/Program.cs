using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri = new Customer();
            musteri.Id = 0;
            musteri.TcNo = 1111;
            musteri.customerName = "Burak";
            musteri.customerSurname = "Even";

            Customer musteri2 = new Customer();
            musteri2.Id = 1;
            musteri2.TcNo = 2222;
            musteri2.customerName = "Ayse";
            musteri2.customerSurname = "Deniz";

            Customer musteri3 = new Customer();
            musteri3.Id = 2;
            musteri3.TcNo = 3333;
            musteri3.customerName = "Irem";
            musteri3.customerSurname = "Yakali";

            Customer musteri4 = new Customer();
            musteri4.Id = 3;
            musteri4.TcNo = 4444;
            musteri4.customerName = "Tugba";
            musteri4.customerSurname = "Serce";

            Customer[] customers = new Customer[]
            {
                musteri,musteri2,musteri3,musteri4
            };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);
            Console.WriteLine("****************");
            customerManager.Liste(customers);
            Console.WriteLine("****************");
            customerManager.Delete(musteri2);

        }
    }
}
