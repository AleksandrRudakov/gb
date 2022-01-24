using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Правила ввода расписания: необходимо вводить строку из нулей и единиц общей длиной 7 символов на каждый из дней недели, при этом единица означает рабочий день, а ноль - нерабочий");
            Console.WriteLine("");

            Console.WriteLine("Введите расписание первого офиса");
            int schedule1 = Convert.ToInt32(Console.ReadLine(),2);
            Console.WriteLine("Введите расписание второго офиса");
            int schedule2 = Convert.ToInt32(Console.ReadLine(),2);

            int schedule_result = schedule1 | schedule2;
            string schedule_result_str = Convert.ToString(schedule_result, 2);
            Console.WriteLine($"Итоговое расписание: {schedule_result_str}");

            Console.ReadLine();
        }
    }
}
