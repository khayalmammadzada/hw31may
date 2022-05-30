using System;
namespace task2
{
    public class Notebook:Product
    {
        public Notebook(double price) : base(price)
        {

        }

        public string CPU;
        public int RAM;
        public int Storage;
    }
}
