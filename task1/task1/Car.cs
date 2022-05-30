using System;
namespace task1
{
    public class Car : Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;

        public void AddFuel(int fuelCapacity, int fuelWanted, int CurrentFuel)
            
        {
            
            if(fuelCapacity>=fuelWanted+CurrentFuel)
            {
                Console.WriteLine("Elave Edildi");
            }
            if (fuelCapacity <= fuelWanted + CurrentFuel)
            {
                Console.WriteLine("Bak Doludur");
            }
        }

    }
}
