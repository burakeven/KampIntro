using System;

namespace ProductList
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.productName = "El feneri";
            product1.productCargo = "MNG kargo";
            product1.productPrice = 60;

            Product product2 = new Product();
            product2.productName = "Kitaplık";
            product2.productCargo = "Aras kargo";
            product2.productPrice = 330;

            Product product3 = new Product();
            product3.productName = "Lamba";
            product3.productCargo = "MNG kargo";
            product3.productPrice = 92;

            Product product4 = new Product();
            product4.productName = "Telefon Tutacagi";
            product4.productCargo = "Aras kargo";
            product4.productPrice = 25;

            Product[] products = new Product[] { product1, product2, product3, product4 };
            foreach (Product items in products)
            {
                Console.WriteLine(items.productName + " " + items.productCargo + " " + items.productPrice);
            }
        }
    }
    class Product
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
        public string productCargo { get; set; }
    }
}
