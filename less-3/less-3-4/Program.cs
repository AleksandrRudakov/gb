using System;

namespace less_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = { 
                { 'O', 'O', 'X', 'X', 'O', 'X', 'O', 'O', 'X', 'X' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O' },
                { 'O', 'X', 'O', 'X', 'X', 'X', 'X', 'O', 'X', 'O' },
                { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O' },
                { 'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'X', 'O' },
                { 'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O' },
                { 'O', 'X', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O' },
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X' },
                { 'X', 'O', 'X', 'X', 'X', 'X', 'O', 'X', 'O', 'X' },
            };

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write(matrix[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
