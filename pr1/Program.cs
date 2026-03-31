using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("lada", "sedan", 250);
            Car car3 = new Car("lamborgini", "urus", 400);

            car1.PrintInfo();
            car2.PrintInfo();
            car3.PrintInfo();

            Console.WriteLine(Car.GetTotalCars());
        }
        class Car
        {
            public string Brand;
            public string Model;
            public int Speed;
            private static int totalCarsCreated = 0;
            public Car()
            {
                Brand = "Unknown";
                Model = "Unknown";
                Speed = 0;
                totalCarsCreated++;
            }
            public Car(string brand, string model, int speed)
            {
                Brand = brand;
                Model = model;
                Speed = speed;
                totalCarsCreated++;
            }
            public static int GetTotalCars()
            {
                return totalCarsCreated;
            }
            public void PrintInfo()
            {
                Console.WriteLine($"Бренд: {Brand}, Модель: {Model}, Скорость: {Speed}.");
            }
        }
    }
}
