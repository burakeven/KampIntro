using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Musteri kaydı olusturuldu: " + " Tc NO:" + customer.TcNo + " Ad: " + customer.customerName + " Soyad: " + customer.customerSurname);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri kaydı silindi: " + " Tc NO:" + customer.TcNo + " Ad: " + customer.customerName + " Soyad: " + customer.customerSurname);
        }
        public void Liste(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.customerName + " " + customer.customerSurname + " listed.");
            }
        }
    }
}
