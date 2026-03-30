using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("BMW", "X8");
            Car car3 = new Car("lada", "vesta", 2000, 1000000);

            car1.Display();
            car2.Display();
            car3.Display();
        }
        class Car
        {
            public string Brand;
            public string Model;
            public int Year;
            public int Price;
            public Car()
            {
                Brand = "Неопределен";
                Model = "Неопределена";
                Year = 0;
                Price = 0;
                Console.WriteLine($"Машина созданна по умолчанию");
            }
            public Car(string brand, string model): this()
            {
                Brand = brand;
                Model = model;
                Console.WriteLine($"Машине присвоен бренд и модель");
            }
            public Car(string brand, string model, int year, int price)
            {
                Brand= brand;
                Model= model;   
                Year= year;
                Price = price;
                Console.WriteLine("Все данные введены");
            }
            public void Display()
            {
                Console.WriteLine($"Бренд: {Brand}, модель: {Model}, год выпуска: {Year}, цена: {Price}.");
            }
        }
    }
}
