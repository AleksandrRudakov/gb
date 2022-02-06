using System;

namespace less_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            Console.WriteLine("Строка наоборот: ");
            int i = str.Length-1;
            while (i>=0)
            {
                Console.Write(str[i]);
                i--;
            }
            Console.ReadKey();
        }
    }
}
