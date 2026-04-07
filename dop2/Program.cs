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
            PizzaOrder.SetShopName("Додо Пица");
            PizzaOrder.SetDiscount(10);

            Console.WriteLine($"Навзание заведения: {PizzaOrder.shopName}");
            Console.WriteLine($"Скидка в заведении: {PizzaOrder.discountPercent}%");
            Console.WriteLine();

            PizzaOrder order1 = new PizzaOrder("Маргарита", 2, 500);
            Console.WriteLine($"Заказ №1");
            order1.ProcessOrder();
            Console.WriteLine();

            PizzaOrder order2 = new PizzaOrder("Маргарита", 1, 600);
            Console.WriteLine($"Заказ №2");
            order2.ProcessOrder();
            Console.WriteLine();

            PizzaOrder.PrintStatistics();

            Console.WriteLine($"Изменение скидка в магазине на 20%");
            PizzaOrder.SetDiscount(20);
            Console.WriteLine();

            PizzaOrder order3 = new PizzaOrder("Гавайская", 3, 550);
            Console.WriteLine($"Заказ №3");
            order3.ProcessOrder();
            Console.WriteLine();

            Console.WriteLine($"Итогавая статистика:");
            PizzaOrder.PrintStatistics();
        }
    }
    class PizzaOrder
    {
        public string PizzaName;
        public int Quantity;
        public int PricePerPizza;

        private static double totalRevenue;
        private static int totalPizzaSold;
        public static string shopName;
        public static double discountPercent = 0;

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
                Console.WriteLine($"Скидка изменена");
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
