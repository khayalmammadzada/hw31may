using System;
namespace task2
{
    public class Product
    {

        public Product(double price)
        {
            this.Price = price;
        }


        public string Brand;
        public string Name;
        public double Price;

            public void ShowInfo()
        {
            Console.WriteLine($"Name: {this.Name} - Brand: {this.Brand} - Price: {this.Price}");
        }

       
    }
}
