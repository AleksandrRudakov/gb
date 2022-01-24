using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер текущего месяца");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Текущий месяц Январь");
                    break;
                case "2":
                    Console.WriteLine("Текущий месяц Февраль");
                    break;
                case "3":
                    Console.WriteLine("Текущий месяц Март");
                    break;
                case "4":
                    Console.WriteLine("Текущий месяц Апрель");
                    break;
                case "5":
                    Console.WriteLine("Текущий месяц Май");
                    break;
                case "6":
                    Console.WriteLine("Текущий месяц Июнь");
                    break;
                case "7":
                    Console.WriteLine("Текущий месяц Июль");
                    break;
                case "8":
                    Console.WriteLine("Текущий месяц Август");
                    break;
                case "9":
                    Console.WriteLine("Текущий месяц Сентябрь");
                    break;
                case "10":
                    Console.WriteLine("Текущий месяц Октябрь");
                    break;
                case "11":
                    Console.WriteLine("Текущий месяц Ноябрь");
                    break;
                case "12":
                    Console.WriteLine("Текущий месяц Декабрь");
                    break;
                default:
                    Console.WriteLine("Ошибка ввода: месяца с таким номером не существует");
                    break;
            }

            Console.ReadLine();
        }
        }
}
