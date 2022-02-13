using System;

namespace less_4_3
{
    class Program
    {
        enum season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Введите порядковый номер месяца:");
            if ((Int32.TryParse(Console.ReadLine(), out i)==true) && (i > 0) && (i <= 12))
            {
                Console.WriteLine("Название времени года:");
                season s = GetTimeOfYearEnum(i);
                Console.WriteLine(GetTimeOfYear(s));
            }
            else
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            }
            Console.ReadKey();
        }

        static season GetTimeOfYearEnum(int mounth)
        {
            season result = season.Summer;
            switch (mounth)
            {
                case 12:
                case 1:
                case 2:
                    result = season.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    result = season.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    result = season.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    result = season.Autumn;
                    break;
                default:
                    break;
            }
            return result;
        }

        static string GetTimeOfYear(season s)
        {
            string result = "";
            switch (s)
            {
                case season.Autumn:
                    result = "осень";
                    break;
                case season.Spring:
                    result = "весна";
                    break;
                case season.Summer:
                    result = "лето";
                    break;
                case season.Winter:
                    result = "зима";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
