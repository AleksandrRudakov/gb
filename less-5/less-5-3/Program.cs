using System;
using System.IO;

namespace less_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор чисел (0...255) через пробел:");

            string[] str = Console.ReadLine().Split(' ');
            
            byte[] bytes = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                bytes[i] = Convert.ToByte(str[i]);
            }

            File.WriteAllBytes("bytes.bin", bytes);

            Console.WriteLine("Числа записаны в бинарный файл bytes.bin");

            Console.ReadKey();
        }
    }
}
