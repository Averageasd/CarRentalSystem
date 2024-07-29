using System;

namespace CarData
{
    public class CarInfoPrinter
    {

        public void PrintCarNotAvailable(int id)
        {
            Console.WriteLine($"Car with {id} does not exist");
        }

        public void PrintCarInfo(int id, Car car)
        {
            Console.WriteLine($"{id}./{car}");
        }

        public void NotifyCarRentedSuccessful(Car car)
        {
            Console.WriteLine($"Successfully rented Car {car.CarName()}.");
        }

        public void NotifyCarRentedFailed(Car car)
        {
            Console.WriteLine($"Car {car.CarName()} is already rented");
        }

        public void NotifyCarReturnedSuccessful(Car car)
        {
            Console.WriteLine($"Successfully returned Car {car.CarName()}.");
        }

        public void NotifyCarReturnedFailed(Car car)
        {
            Console.WriteLine($"Car {car.CarName()} is already returned.");
        }
    }
}
