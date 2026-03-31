using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[4];

            books[0] = new Book();
            books[1] = new Book("Мертвые души", "Гоголь");
            books[2] = new Book("Преступление и наказание", "Достоевский", 2024, 3000);
            books[3] = new Book("Гарри Поттер", "Джоан Роулинг", 1990, 10000);

            books[2].ApplyDiscount(10);
            books[3].ApplyDiscount(20);

            foreach (var book in books)
            {
                book.PrintInfo();
            }

            Console.WriteLine($"Общее количество книг: {Book.GetTotalBooks()}");
        }
        public interface IDiscoutable
        {
            void ApplyDiscount(double percent);
            double GetDiscountedPrice();
        }
        class Book: IDiscoutable
        {
            public string Title;
            public string Author;
            public int Year;
            public double Price;
            private double discountPrecent = 0;
            private static int totalBooksCreated = 0;
            public void ApplyDiscount(double percent)
            {
                if (percent >= 0 && percent <= 50)
                {
                    discountPrecent = percent;
                    Console.WriteLine($"Скидка применена");
                }
                else
                {
                    Console.WriteLine($"Неверный ввод, скидка не применена");
                    discountPrecent = 0;
                }
            }
            public double GetDiscountedPrice()
            {
                return Price * (1 - discountPrecent / 100);
            }
            public Book(string t, string a, int y, double p)
            {
                Title = t;
                Author = a;
                Year = y;
                Price = p;
                totalBooksCreated++;
            }
            public Book(string t, string a, int y) : this(t, a, y, 0.0) { }
            public Book(string t, string a) : this(t, a, 2000) { }
            public Book(string t) : this(t, "Неизвестен") { }
            public Book() : this("Неизвестно") { }
            public void PrintInfo()
            {
                double discountPrecent = GetDiscountedPrice();
                Console.WriteLine($"Название: {Title}, Автор: {Author}, Год издания: {Year}, Цена: {Price:F2} Цена со скидкой: {discountPrecent:F2}");
            }
            public static int GetTotalBooks()
            {
                return totalBooksCreated;
            }
        }
    }
}
