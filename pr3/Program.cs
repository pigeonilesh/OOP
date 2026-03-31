using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите курс доллара");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите курс евра");
            double euro = Convert.ToDouble(Console.ReadLine());
        }
        class CorrencyConverter
        {
            private static double UsdToRubRate;
            private static double EuroToRubRate;
            public static void SetRates(double usdRate, double euroRate)
            {
                UsdToRubRate = usdRate;
                EuroToRubRate = euroRate;
            }
            public static double ConvertUsdToRub(double usd)
            {
                return usd * UsdToRubRate;
            }
            public static double ConvertEuroToRub(double euro)
            {
                return euro * EuroToRubRate;
            }
        }
    }
}
