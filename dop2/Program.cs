using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class PizzaOrder
    {
        public string PizzaName;
        public int Quantity;
        public int PricePerPizza;

        private static double totalRevenue;
        private static int totalPizzaSold;
        private static string shopName;
        private static double discountPercent = 0;

        public PizzaOrder()
        {
            PizzaName = "Неизвестно";
            Quantity = 0;
            PricePerPizza = 0;
        }
        public PizzaOrder(string pizzaName, int quantity, int pricePerPizza): this()
        {
            PizzaName = pizzaName;
            Quantity = quantity;
            PricePerPizza = pricePerPizza;
        }

        public int CalculateTotalPrice()
        {
            return Quantity * PricePerPizza;
        }
        public double CalculateDiscountedPrice()
        {
            return (Quantity * PricePerPizza) - ((Quantity * PricePerPizza)*(discountPercent / 100));
        }
        public void ProcessOrder()
        {
            totalRevenue += CalculateDiscountedPrice();
            totalPizzaSold += Quantity;
            Console.WriteLine($"Пицца: {PizzaName}, Количество: {Quantity}, Цена за шт.:{PricePerPizza} руб.");
            Console.WriteLine($"Полная стоимость: {CalculateTotalPrice()} руб.");
            Console.WriteLine($"Стоимость со скидкой: {CalculateDiscountedPrice()} руб.");
            Console.WriteLine($"Заказ обработан!");
        }
        public void PrintOrderInfo()
        {
            Console.WriteLine($"Пицца: {PizzaName}, Количество: {Quantity}, Цена за шт.:{PricePerPizza} руб.");
            Console.WriteLine($"Полная стоимость: {CalculateTotalPrice()} руб.");
            Console.WriteLine($"Стоимость со скидкой: {CalculateDiscountedPrice()} руб.");
            Console.WriteLine($"Заказ обработан!");
        }
        public static void SetDiscount(double percent)
        {
            if (percent >= 0 && percent <= 30)
            {
                discountPercent = percent;
            }
            else
            {
                Console.WriteLine($"Неверная скидка");
                discountPercent = 0;
            }
        }
        public static void SetShopName(string name)
        {
            shopName = name;
            Console.WriteLine($"Имя заведения изменено");
        }
        public static void PrintStatistics()
        {
            Console.WriteLine($"Статистика пиццерии:");
            Console.WriteLine($"Общая выручка: {totalRevenue}");
            Console.WriteLine($"Всего продано пицц: {totalPizzaSold}");
        }
    }
}
