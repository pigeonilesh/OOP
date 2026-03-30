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
            Book book1 = new Book();
            Book book2 = new Book("Мертвые души", "Гоголь");
            Book book3 = new Book("Гарри Поттер", "Джоан Роулинг", 1990, 10000);
            Book book4 = new Book("Преступление и наказание", "Достоевский", 2024, 3000);
            double precent = 0;
            book3.ApplyDiscount(precent);
            book4.ApplyDiscount(precent);

            book1.PrintInfo();
            book2.PrintInfo();
            book3.PrintInfo();
            book4.PrintInfo();

            book1.GetTotalBooks();
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
            public int totalBooksCreated = 0;
            public void ApplyDiscount(double percent)
            {
                Console.WriteLine($"Введите скидку для книги");
                percent = Convert.ToInt32(Console.ReadLine());
                if (percent >= 0 && percent <= 50)
                {
                    discountPrecent = percent;
                }
                else
                {
                    Console.WriteLine($"Неверный ввод, скидка не применена");
                    discountPrecent = 0;
                }
            }
            public double GetDiscountedPrice()
            {
                if (discountPrecent != 0)
                {
                    Price = Price * (1 - discountPrecent / 100);
                    return Price;
                }
                else 
                {
                    return Price; 
                }
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
                Console.WriteLine($"Название: {Title}, Автор: {Author}, Год издания: {Year}, Цена: {Price} Цена со скидкой: {GetDiscountedPrice()}");
            }
            public int GetTotalBooks()
            {
                return totalBooksCreated;
            }
        }
    }
}
