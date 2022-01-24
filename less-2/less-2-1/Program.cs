using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");

            if(!double.TryParse(Console.ReadLine(), out double min_temp))
            {
                Console.WriteLine("Ошибка ввода! Запустите повторно проект!");
                Console.ReadLine();
                return;
            }

            //double min_temp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за сутки");

            if(!double.TryParse(Console.ReadLine(), out double max_temp))
            {
                Console.WriteLine("Ошибка ввода! Запустите повторно проект!");
                Console.ReadLine();
                return;
            }

            //double max_temp = Convert.ToDouble(Console.ReadLine());

            double result = (min_temp + max_temp) / 2;
            Console.WriteLine($"Среднесуточная температура {result}");

            Console.ReadLine();
        }
    }
}
