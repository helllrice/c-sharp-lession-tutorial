using System;
using System.Globalization;

//конвртация строки
//    parse и tryparse


namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // усложненный метод парсинга tryparse

            string str = "1";

            int a;

            bool result = int.TryParse(str, out a);

            Console.WriteLine(result);

            if (result)
            {
                Console.WriteLine("операция успешна, значение = " + a);
            }
            else
            {
                Console.WriteLine("Не удалось конвертировать!");
            }

            // простой метод парсинга 

            string str2 = "2";
            int a2 = int.Parse(str2);

            Console.WriteLine(a2);

            
        }


    }

}
