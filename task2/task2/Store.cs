using System;
namespace task2
{
    public class Store
    {
        public Store(int phoneCount)
        {
            this.Phones = new Phone[phoneCount];
        }

        public Phone[] Phones;
        public Notebook[] Notebooks;

        public void AddPhone(Phone phone)
        {

        }

    }
}
