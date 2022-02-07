using System;

namespace less_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество итераций:");
            string str = Console.ReadLine();

            Console.WriteLine("Итоговое число Фибоначчи:");

            int i = 0;

            if (Int32.TryParse(str, out i) == true)
            {
                Console.WriteLine(TryCalcFibonacciNumber(i, 1, 0, 1));
            }
            else
            {
                Console.WriteLine("Некоррректный ввод!");
            }
            Console.ReadKey();
        }

        static int TryCalcFibonacciNumber(int count, int i, int i1, int i2)
        {
            int temp = 0;
            int result = 0;

            if (count < 0)
            {
                return 0;
            }
            else if (count == 0)
            {
                return 0;
            }
            else if (count == 1)
            {
                return 1;
            }
            else if (i == count)
            {
                return i2;
            }
            else
            {
                temp = i1;
                i1 = i2;
                i2 = temp + i2;
                i++;
                result = TryCalcFibonacciNumber(count, i, i1, i2);
            }
            return result;
        }
    }
}
