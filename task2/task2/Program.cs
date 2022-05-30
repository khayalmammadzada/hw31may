using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Phone phone = new Phone(2500)
            {
                Brand = "Samsung",
                Camera = 14,
                Name = "Note 20",
                SimCount = 2
            };

            phone.ShowInfo();

            Store elininMarketi = new Store();


        }
    }
}
