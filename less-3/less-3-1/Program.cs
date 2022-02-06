using System;

namespace less_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                { 1, 5, 2, 8, 7 },
                { 2, 3, 7, 8, 9 },
                { 4, 0, 2, 1, 7 },
                { 1, 5, 8, 3, 2 },
                { 4, 0, 5, 1, 7 }
            };

            string d1 = "";
            string d2 = "";

            for (int i = 0; i < matrix.GetLength(0) ; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    if (i==j)
                    {
                        d1 = d1 + Convert.ToString(matrix[i, j]) + " ";
                    }
                    if ((i+j) == (matrix.GetLength(0)-1))
                    {
                        d2 = Convert.ToString(matrix[i, j]) + " " + d2;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"d1 = {d1}");
            Console.WriteLine($"d2 = {d2}");
            Console.ReadKey();
        }
    }
}
