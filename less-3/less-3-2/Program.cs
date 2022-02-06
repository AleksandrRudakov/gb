using System;

namespace less_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] matrix = {
                { "Иванов", "8(000)000-00-00" },
                { "Петров", "petrov@petrov.ru" },
                { "Сидоров", "8(111)111-11-11" },
                { "Сергеев", "sergeev@sergeev.ru" },
                { "Алексеев", "8(222)222-22-22" }
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
