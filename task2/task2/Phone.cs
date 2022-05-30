using System;
namespace task2
{
    public class Phone:Product
    {
        public Phone(double price) : base(price)
        {

        }

        public byte Camera;
        public byte SimCount;
    }
}
