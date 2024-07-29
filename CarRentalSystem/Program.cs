using CarData;
using System;

namespace CarRentalSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[] { 
                new Car("Honda", "Civic", 50.0M, false), 
                new Car("Honda", "Accord", 40.0M, false) 
            };
             
            CarSystem carSystem = new CarSystem(cars);
            carSystem.PrintAllCars();
            carSystem.RentCar(1);
            carSystem.RentCar(1);
            carSystem.PrintAllCars();
            Console.ReadKey();
        }
    }
}
