using System;
namespace CarData
{
    public class CarSystem
    {
        private Car[] carArray;

        CarInfoPrinter carInfoPrinter;

        public CarSystem(Car[] carArray)
        {
            this.carArray = carArray;
            carInfoPrinter = new CarInfoPrinter();
        }

        public int GetMappedIndex(int id)
        {
            return id - 1;
        }

        public bool IsMappedIdValid(int mappedId)
        {
            return mappedId < carArray.Length;
        }

        public void RentCar(int id)
        {
            int mappedIndex = GetMappedIndex(id);
            if (!IsMappedIdValid(mappedIndex))
            {
                carInfoPrinter.PrintCarNotAvailable(id);
                return;
            }

            Car car = carArray[mappedIndex];

            if (car.Rented)
            {
                carInfoPrinter.NotifyCarRentedFailed(car);
                return;
            }
            car.Rent();
            carInfoPrinter.NotifyCarRentedSuccessful(car);
        }

        public void Return(int id)
        {
            int mappedIndex = GetMappedIndex(id);
            if (!IsMappedIdValid(mappedIndex))
            {
                carInfoPrinter.PrintCarNotAvailable(id);
                return;
            }

            Car car = carArray[mappedIndex];

            if (car.Rented)
            {
                car.Return();
                carInfoPrinter.NotifyCarReturnedSuccessful(car);
                return;
            }
            carInfoPrinter.NotifyCarReturnedFailed(car);
        }

        public void PrintAllCars()
        {
            for (int i = 0; i < carArray.Length; i++)
            {
                carInfoPrinter.PrintCarInfo(i + 1, carArray[i]);
            }
        }
    }
}
