using System;

namespace less_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с числами разделенными пробелом:");
            
            string str = Console.ReadLine();
            string temp = "";
            double sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    sum = Sum(sum, temp);
                    temp = "";
                }
                else
                {
                    temp = temp + str[i];
                }
            }

            sum = Sum(sum, temp);

            Console.WriteLine($"Сумма чисел: {sum}");
            Console.ReadKey();
        }

        static double Sum(double sum, string temp)
        {
            double result = 0;
            if (double.TryParse(temp, out result) == true)
            {
                return sum + result;
            }
            return sum;
        }
    }
}
