using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");

            if(!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Ошибка ввода! Запустите повторно проект!");
                Console.ReadLine();
                return;
            }
            
            //int number = Convert.ToInt32(Console.ReadLine());

            if(number % 2 == 1)
                Console.WriteLine("Вы ввели НЕчетное число");
            else
                Console.WriteLine("Вы ввели четное число");

            Console.ReadLine();
        }
    }
}
