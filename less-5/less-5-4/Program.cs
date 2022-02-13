using System;
using System.IO;
using System.Linq;

namespace less_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите каталог:");
            string dir = @Console.ReadLine();

            if (Directory.Exists(dir))
            {
                tree1(dir);
                tree2(dir);
            }
            else
            {
                Console.WriteLine("Каталог не существет!");
            }
            Console.ReadKey();
        }

        static void tree1(string dir)
        {
            string f1 = "tree1.txt";
            File.WriteAllText(f1, "");
            
            File.AppendAllText(f1, dir + Environment.NewLine);

            string[] files = Directory.GetFiles(dir);
            File.AppendAllLines(f1, files);

            string[] directories = Directory.GetDirectories(dir);
            for (int i = 0; i < directories.Length; i++)
            {
                File.AppendAllText(f1, directories[i] + Environment.NewLine);

                try
                {
                    string[] files_i = Directory.GetFiles(directories[i]);
                    File.AppendAllLines(f1, files_i);
                }
                catch (Exception)
                {

                }
            }
            Console.WriteLine("Дерево каталогов и файлов записано в файл tree1.txt");
        }

        static void tree2(string dir)
        {
            string f2 = "tree2.txt";
            File.WriteAllText(f2, "");

            SaveFiles(dir, f2);

            Console.WriteLine("Дерево каталогов и файлов рекурсивно записано в файл tree2.txt");
        }

        static void SaveFiles(string dir, string f2)
        {
            File.AppendAllText(f2, dir + Environment.NewLine);

            try
            {
                string[] files = Directory.GetFiles(dir);
                File.AppendAllLines(f2, files);
            }
            catch (Exception)
            {

            }

            try
            {
                string[] directories = Directory.GetDirectories(dir);
                for (int i = 0; i < directories.Length; i++)
                {
                    SaveFiles(directories[i], f2);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
