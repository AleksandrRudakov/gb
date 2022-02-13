using System;
using System.IO;

namespace less_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllText("startup.txt", Convert.ToString(DateTime.Now) + Environment.NewLine);
            Console.WriteLine("Текущее время добавлено в файл startup.txt");
            Console.ReadKey();
        }
    }
}
