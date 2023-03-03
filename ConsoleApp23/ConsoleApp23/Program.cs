using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Введите IP-адрес:");
            string a = Console.ReadLine();
            string pattern = @"^([0-9][0-9][0-9]+)(\.)([0-9][0-9][0-9]+)(\.)([0-9][0-9][0-9]+)(\.)([0-9][0-9][0-9]+)$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(a))
                Console.WriteLine("IP введен правильно!");
            else
                Console.WriteLine("IP введен не правильно!");

            //2
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            string[] gl = { "а", "о", "ю", "э", "ы", "и", "е", "я", "у" };
            Regex regex1 = new Regex(str);

            Console.WriteLine("Регистрозависимый поиск: ");
                if (regex.IsMatch(str))
                    Console.WriteLine("В исходной строке: \"{0}\" есть совпадения!", str);
            
            Console.WriteLine();

            //3   пример htps://www.reg.ru
            Console.WriteLine("Введите IP-адрес:");
            string u = Console.ReadLine();
            string pattern1 = @"^(\w*)(\:)(\//)(\w*)(\.)(\w*)(\.)(\w*)$";
            Regex regex2 = new Regex(pattern1);

            if (regex2.IsMatch(u))
                Console.WriteLine("URL введен правильно!");
            else
                Console.WriteLine("URL введен не правильно!");



            //4
            string str1 = "Hello World1!";
            string pattern2 = @"^(\w)$";
            Regex regex3 = new Regex(pattern2);
            if(regex3.IsMatch(str1))
            {
                Console.WriteLine("Строка содержит букву или цифру!");
            }
            else
                Console.WriteLine("Строка содержит лишние символы!");



            //5
            string str2 = "23:59:59";
            string pattern3 = @"^(([01][0-9])|([2][0-3]))(:)[0-5][0-9]((:)[0-5][0-9])?$";
            Regex regex4 = new Regex(pattern3);
            if (regex4.IsMatch(str2))
            {
                Console.WriteLine("Введено время");
            }
            else
                Console.WriteLine("ошибка!");


            //6 10000 - 14999
            string str3 = "23:59:59";
            string pattern4 = @"^(([1][0][0][0][0])(\-)([1][4][9][9][9]))$";
            Regex regex5 = new Regex(pattern4);
            if (regex5.IsMatch(str3))
            {
                Console.WriteLine("Почтовый индекс Нью-йрока введен верно");
            }
            else
                Console.WriteLine("ошибка!");
        }
    }
}
