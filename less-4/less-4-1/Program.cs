using System;

namespace less_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Иван","Иванов","Иванович"));
            Console.WriteLine(GetFullName("Петр", "Петров", "Петрович"));
            Console.WriteLine(GetFullName("Сергей", "Сергеев", "Сергеевич"));
            Console.ReadKey();
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return lastName + " " + firstName + " " + patronymic;
        }
    }
}
