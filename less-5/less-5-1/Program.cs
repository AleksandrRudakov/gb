using System;
using System.IO;

namespace less_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст:");
            string str = Console.ReadLine();
            File.WriteAllText("test.txt", str);
            Console.WriteLine("Введенный текст сохранен в файл test.txt в директории проекта");
            Console.ReadKey();
        }
    }
}
