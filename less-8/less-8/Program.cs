using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = Properties.Settings.Default.Greeting;
            string name = Properties.Settings.Default.Name;
            string age = Properties.Settings.Default.Age;
            string activity = Properties.Settings.Default.Activity;

            if (name=="")
            {
                Console.WriteLine(greeting);

                Console.WriteLine("Введите имя:");
                Properties.Settings.Default.Name = Console.ReadLine();

                Console.WriteLine("Введите возраст:");
                string age_string = Console.ReadLine();
                if (Int32.TryParse(age_string, out int age_int)==true)
                {
                    Properties.Settings.Default.Age = age_string;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод!");
                }

                Console.WriteLine("Введите род деятельности:");
                Properties.Settings.Default.Activity = Console.ReadLine();

                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine(greeting);
                Console.WriteLine($"Ваше имя: {name}");
                Console.WriteLine($"Ваш возраст: {age}");
                Console.WriteLine($"Ваш род деятельности: {activity}");
            }

            Console.ReadKey();
        }
    }
}
