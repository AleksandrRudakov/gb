using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца");
            string number_mounth = Console.ReadLine();
            
            Console.WriteLine("Введите среднюю температуру");
            
            if(!double.TryParse(Console.ReadLine(), out double avg_temp))
            {
                Console.WriteLine("Ошибка ввода! Запустите повторно проект!");
                Console.ReadLine();
                return;
            }

            //double avg_temp = Convert.ToDouble(Console.ReadLine());

            if ((number_mounth == "12" || number_mounth == "1" || number_mounth == "2") && (avg_temp > 0))
                Console.WriteLine("Дождливая зима");
            else
                Console.WriteLine("Спасибо");

            Console.ReadLine();
        }
    }
}
