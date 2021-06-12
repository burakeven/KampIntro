using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burak Even
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Burak";
            customer1.LastName = "Even";
            customer1.TcNo = "222222222222";

            //Even LLC
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "112233";
            customer2.CompanyName = "Even LLC";
            customer2.TaxNo = "1234567890";


            Customer customer3 = new IndividualCustomer();//New'den itibaren olan yer bellekte bir Ref NO'dur. 
            Customer customer4 = new CorporateCustomer();//New'den itibaren olan yer bellekte bir Ref NO'dur.
            //Customer ikisininde ref No'sunu tutar.                        

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3); // <-------

        }
    }
}
