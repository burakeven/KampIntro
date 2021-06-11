using System;

namespace MyDictionaryDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cars = new MyDictionary<int, string>();
            cars.Add(1, "Mercedes");
            cars.Add(2, "BMW");
            cars.Add(3, "Hyundai");
            cars.Add(4, "Honda");
            cars.Add(5, "Chevrolet");
            cars.Add(6, "Fiat");

            cars.PrintAll();
            Console.ReadLine();
        }
    }
}
