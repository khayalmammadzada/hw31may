using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //      1.Aşağıdakı classları yaradırsınız:
            //      Vehicle class:
            //         - Brand
            //         - Model
            //         - Millage

            //      Car class:
            //        - FuelCapacity
            //        - AddFuel() - parametr olaraq neçə litr benzin əlavə etmək istənildiyi
            //      daxil edilməlidir və capacity-ni aşmırsa əlavə edilməlidir\

            Car car = new Car()
            {
                Brand = "Ford",
                Model = "Mustang",
                Millage = 15000,
                FuelCapacity = 45,
                CurrentFuel = 10
            };

            car.AddFuel(45, 15, 10);

        }
    }
}
