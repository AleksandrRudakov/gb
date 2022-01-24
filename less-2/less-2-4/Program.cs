using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string company_name = "СуперЧек.ru"; //Наименование компании
            int receipt_number = 4201; //Номер чека
            string cashiers_name = "Иванов И.И."; //Имя кассира
            int number = 1; //Порядковый номер
            string product_name = "Щебень фракция 20х40 т."; //Наименование товара
            double cost = 2400.00; //Стоимость
            double total = 2400.00; //Всего
            string KKM = "00000000"; //ККМ
            string INN = "000000000000"; //ИНН
            DateTime date = new DateTime(2022,1,20,15,0,0); //Дата

            Console.WriteLine($"          ООО {company_name}");
            Console.WriteLine($"             Чек №{receipt_number}");
            Console.WriteLine($"        Кассир: {cashiers_name}");
            Console.WriteLine($"{number}. {product_name}");
            Console.WriteLine($"   Стоимость................{string.Format("{0:f2}", cost)}");
            Console.WriteLine($"===================================");
            Console.WriteLine($"Всего.......................{string.Format("{0:f2}", total)}");
            Console.WriteLine($"ККМ {KKM} ИНН {INN} №{receipt_number}");
            Console.WriteLine($"{date.ToString("dd.MM.yyyy HH:mm")}        {cashiers_name}");

            Console.ReadLine();
        }
    }
}
